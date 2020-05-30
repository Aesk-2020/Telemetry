import 'dart:typed_data';

import 'package:mqtt_client/mqtt_client.dart' as mqtt;
import 'package:flutter/foundation.dart';
import 'dart:async';

///bit işlemleri kütüğhaneleri byte array vs.



class MqttAesk extends ChangeNotifier{

  var vcu_wake_up_u8;
  var vcu_drive_command_u8;
  var vcu_set_velocity_u8;


  var driver_phase_a_current_f32;//100
  var driver_phase_b_current_f32;//100
  var driver_dc_bus_current_f32;//100
  var driver_dc_bus_voltage_f32;//10
  var driver_id_f32;//100
  var driver_iq_f32;//100
  var driver_vd_f32;//100
  var driver_vq_f32;//100
  var driver_drive_status_u8;
  var driver_driver_error_u8;
  var driver_odometer_u32;
  var driver_motor_temperature_u8;
  var driver_actual_velocity_u8;

  var bms_bat_volt_f32;//10
  var bms_bat_current_f32;//100
  var bms_bat_cons_f32;//10
  var bms_soc_f32;//100
  var bms_bms_error_u8;
  var bms_dc_bus_state_u8;
  var bms_worst_cell_voltage_f32;//10
  var bms_worst_cell_address_u8;
  var bms_temp_u8;

  var gpsTracker_gps_latitude_f64;  //1000000
  var gpsTracker_gps_longtitude_f64;
  var gpsTracker_gps_velocity_u8;
  var gpsTracker_gps_sattelite_number_u8;
  var gpsTracker_gps_efficiency_u8;

  //EMS
  /*


  var eys_bat_current_int16;//10
  var eys_fc_current_int16;//10
  var eys_out_current_int16;//10
  var eys_bat_volt_uint16;//10
  var eys_out_volt_uint16;//10
  var eys_bat_cons_uint16;//10
  var eys_fc_cons_uint16;//10
  var eys_fc_lt_cons_uint16;//10
  var eys_out_cons_uint16;//10
  var eys_penalty_int8;//10
  var eys_bat_soc_uint16;//100
  var eys_temp_uint8;
  var eys_error_uint8;


  */

  var MQTT_counter_int32;

  static String broker           = '157.230.29.63';
  static int port                = 1883;
  static String username         = 'digital';
  static String password           = 'aesk';
  static String clientIdentifier = 'ff'; //cihaz isimlerine göre atama yap

  mqtt.MqttClient client;
  mqtt.MqttConnectionState connectionState;

//kilit eleman
  StreamSubscription subscription;

  Future<bool> connect() async {

    client = mqtt.MqttClient(broker,"");
    client.port = port;


    client.logging(on: true);


    client.keepAlivePeriod = 30;


    client.onDisconnected = _onDisconnected;

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

    if(client.connectionState == mqtt.MqttConnectionState.connected){
      return true;
    }else{
      return false;
    }
  }

//baglanti kopmasi
  void disconnect() {
    client.disconnect();
    _onDisconnected();
  }

  void _onDisconnected() {
//
    connectionState = client.connectionState;
    client = null;
    subscription.cancel();
    subscription = null;
    notifyListeners();
  }

  void _onMessage(List<mqtt.MqttReceivedMessage> event) {


    final mqtt.MqttPublishMessage recMess = event[0].payload as mqtt.MqttPublishMessage;
    //Başka değişkenleri değiştir.

    var message = recMess.payload.message.buffer.asByteData(0);
    _mqttDecoder(message, Endian.little);

//  var x = recMess.payload.message.buffer.asByteData(0);

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

  void _mqttDecoder(ByteData message,Endian myEndian){

    int _startIndex =0;
    vcu_wake_up_u8 = message.getUint8(_startIndex);
    _startIndex++;

    vcu_drive_command_u8 = message.getUint8(_startIndex);
    _startIndex++;

    vcu_set_velocity_u8 = message.getUint8(_startIndex);
    _startIndex++;

    driver_phase_a_current_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex +=2;

    driver_phase_b_current_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_dc_bus_current_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_dc_bus_voltage_f32 = message.getUint16(_startIndex,myEndian)/10;
    _startIndex+=2;

    driver_id_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_iq_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_vd_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_vq_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_drive_status_u8 = message.getUint8(_startIndex);
    _startIndex++;

    driver_driver_error_u8 = message.getUint8(_startIndex);
    _startIndex++;

    driver_odometer_u32 = message.getUint32(_startIndex,myEndian);
    _startIndex+=4;

    driver_motor_temperature_u8 = message.getUint8(_startIndex);
    _startIndex++;

    driver_actual_velocity_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_bat_volt_f32 = message.getUint16(_startIndex,myEndian)/10;
    _startIndex+=2;

    bms_bat_current_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    bms_bat_cons_f32 = message.getUint16(_startIndex,myEndian)/10;
    _startIndex+=2;

    bms_bat_cons_f32 = message.getUint16(_startIndex,myEndian)/100;
    _startIndex+=2;

    bms_soc_f32 = message.getUint16(_startIndex,myEndian);
    _startIndex+=2;

    bms_bms_error_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_dc_bus_state_u8 = message.getUint8(_startIndex)/10;
    _startIndex++;

    bms_worst_cell_voltage_f32 = message.getUint16(_startIndex,myEndian);
    _startIndex+=2;

    bms_worst_cell_address_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_temp_u8 = message.getUint8(_startIndex);
    _startIndex++;

    gpsTracker_gps_latitude_f64 = message.getUint32(_startIndex,myEndian)/1000000;
    _startIndex+=4;

    gpsTracker_gps_longtitude_f64 = message.getUint32(_startIndex,myEndian)/1000000;
    _startIndex+=4;

    gpsTracker_gps_velocity_u8 = message.getUint8(_startIndex);
    _startIndex++;

    gpsTracker_gps_sattelite_number_u8 = message.getUint8(_startIndex);
    _startIndex++;

    gpsTracker_gps_efficiency_u8 = message.getUint8(_startIndex);
    _startIndex++;

    MQTT_counter_int32 = message.getInt32(_startIndex,myEndian);
    _startIndex+=4;
  }
}

