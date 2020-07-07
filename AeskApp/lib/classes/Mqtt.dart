import 'dart:typed_data';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:mqtt_client/mqtt_client.dart' as mqtt;
import 'package:flutter/foundation.dart';
import 'dart:async';

///bit işlemleri kütüğhaneleri byte array vs.

var old_iteration_date;

class MqttAesk extends ChangeNotifier {
  static String broker = '157.230.29.63';
  static int port = 1883;
  static String username = 'digital';
  static String password = 'aesk';
  static String clientIdentifier =
      DateTime.now().toString(); //cihaz isimlerine göre atama ya

  mqtt.MqttClient client;
  mqtt.MqttConnectionState connectionState;

//kilit eleman
  StreamSubscription subscription;

  Future connect() async {
    client = mqtt.MqttClient(broker, "40");
    client.port = port;
    client.logging(on: true);
    client.keepAlivePeriod = 30;
    client.onDisconnected = _onDisconnected;
    AeskData.bms_bat_current_f32 = AeskData.bms_bat_volt_f32 =
        AeskData.bms_dc_bus_state_u8 = AeskData.bms_soc_f32 = AeskData
            .driver_actual_velocity_u8 = AeskData.driver_dc_bus_current_f32 = 0;
    AeskData.driver_dc_bus_voltage_f32 = AeskData.driver_id_f32 =
        AeskData.driver_iq_f32 = AeskData.driver_motor_temperature_u8 = AeskData
            .driver_odometer_u32 = AeskData.driver_phase_a_current_f32 = 0;
    AeskData.driver_phase_b_current_f32 = AeskData.driver_vd_f32 =
        AeskData.driver_vq_f32 = AeskData.bms_bat_cons_f32 =
            AeskData.bms_temp_u8 = AeskData.bms_power_f32 = 0;

    //arastiracaz
    final mqtt.MqttConnectMessage connMess = mqtt.MqttConnectMessage()
        .withClientIdentifier(clientIdentifier)
        .startClean()
        .keepAliveFor(30)
        .withWillTopic('test/test')
        .withWillMessage('lamhx message test')
        .withWillQos(mqtt.MqttQos.atMostOnce);
    client.connectionMessage = connMess;

    //baglanilan yer burasi
    try {
      await client.connect(username, password);
    } catch (e) {
      print(e);
      disconnect();
    }

    /// Check if we are connected
    if (client.connectionState == mqtt.MqttConnectionState.connected) {
      print('MQTT client connected');
      connectionState = client.connectionState;
    } else {
      disconnect();
    }

    /// The client has a change notifier object(see the Observable class) which we then listen to to get
    /// notifications of published updates to each subscribed topic.
    subscription = client.updates.listen(_onMessage);

    if (client.connectionState == mqtt.MqttConnectionState.connected) {
      return true;
    } else {
      return false;
    }
  }

//baglanti kopmasi
  void disconnect() {
    client.disconnect();
    _onDisconnected();
  }

  void _onDisconnected() {
    connectionState = client.connectionState;
    client = null;
    subscription.cancel();
    subscription = null;
    notifyListeners();
  }

  void _onMessage(List<mqtt.MqttReceivedMessage> event) {
    old_iteration_date ??= DateTime.now();

    var new_iteration_date = DateTime.now();

    AeskData.ping =
        new_iteration_date.difference(old_iteration_date).inMilliseconds;
    AeskData.x_time += AeskData.ping;

    old_iteration_date = new_iteration_date;

    final mqtt.MqttPublishMessage recMess =
        event[0].payload as mqtt.MqttPublishMessage;
    var message = recMess.payload.message.buffer.asByteData(0);

    AeskData(message, Endian.little);

    notifyListeners();
  }

  void subscribeToTopic(String topic) {
    if (connectionState == mqtt.MqttConnectionState.connected) {
      client.subscribe(topic, mqtt.MqttQos.exactlyOnce);
    }
    notifyListeners();
  }

  void unsubscribeFromTopic(String topic) {
    if (connectionState == mqtt.MqttConnectionState.connected) {
      client.unsubscribe(topic);
    }
    notifyListeners();
  }
}
