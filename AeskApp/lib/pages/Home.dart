import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';
import 'package:aeskapp/classes/Mqtt.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    if(AeskData.bms_bat_current_f32!=null){
      return WillPopScope(
        onWillPop: () {
          return showDialog(
            context: context,
            child: CupertinoAlertDialog(
              //backgroundColor: Theme.of(context).backgroundColor,
              content: Text(
                "Çıkmak istediğinize emin misiniz?",
                style: TextStyle(fontSize: 20, color: Colors.black),
              ),
              actions: <Widget>[
                CupertinoDialogAction(
                  child: myText("HAYIR", 18, Colors.black, FontWeight.bold),
                  onPressed: () => Navigator.pop(context, false),
                ),
                CupertinoDialogAction(
                  child: myText("EVET", 18, Colors.black, FontWeight.bold),
                  onPressed: () =>
                      SystemChannels.platform.invokeMethod('SystemNavigator.pop'),
                ),
              ],
            ),
          );
        },
        child: SafeArea(
          child: aeskScaffold(
            context: context,
            myBody: Consumer<MqttAesk>(
              builder: (context, _, child) {
                final scale = MediaQuery.of(context);
                return Padding(
                  padding: EdgeInsets.all(5),
                  child: Card(
                    margin: EdgeInsets.all(10),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.center,
                      mainAxisAlignment: MainAxisAlignment.start,
                      children: <Widget>[
                        myText(
                            "\nANA SAYFA",
                            scale.size.width / 16.45714284,
                            Theme.of(context).textTheme.headline3.color,
                            FontWeight.bold),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: <Widget>[
                            Column(
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: <Widget>[
                                DataBox(
                                  ad: "Ping",
                                  veri: AeskData.ping.toString(),
                                ),
                                DataBox(
                                  ad: "BAT VOLT",
                                  veri:
                                  AeskData.bms_bat_volt_f32.toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "BAT CUR",
                                  veri: AeskData.bms_bat_current_f32
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "BAT CONS",
                                  veri:
                                  AeskData.bms_bat_cons_f32.toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "SOC",
                                  veri: AeskData.bms_soc_f32.toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "Phase B",
                                  veri: AeskData.driver_phase_b_current_f32
                                      .toStringAsFixed(2),
                                ),
                              ],
                            ),
                            Column(
                              children: <Widget>[
                                DataBox(
                                  ad: "MOTOR TEMP",
                                  veri: AeskData.driver_motor_temperature_u8
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "Phase A Current",
                                  veri: AeskData.driver_phase_a_current_f32
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "Torque",
                                  veri: AeskData.driver_vq_f32.toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "DC BUS CUR",
                                  veri: AeskData.driver_dc_bus_current_f32
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "DC BUS VOLT",
                                  veri: AeskData.driver_dc_bus_voltage_f32
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "IArms",
                                  veri: AeskData.driver_vd_f32.toStringAsFixed(2),
                                ),
                              ],
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                );
              },
            ),
          ),
        ),
      );
    }
    else if(AeskData.bms_bat_current_f32==null){
      AeskData.bms_bat_current_f32 = AeskData.bms_bat_volt_f32 =
          AeskData.bms_dc_bus_state_u8 = AeskData.bms_soc_f32 = AeskData
          .driver_actual_velocity_u8 = AeskData.driver_dc_bus_current_f32 = 0;
      AeskData.driver_dc_bus_voltage_f32 = AeskData.driver_id_f32 =
          AeskData.driver_iq_f32 = AeskData.driver_motor_temperature_u8 = AeskData
          .driver_odometer_u32 = AeskData.driver_phase_a_current_f32 = 0;
      AeskData.driver_phase_b_current_f32 = AeskData.driver_vd_f32 =
          AeskData.driver_vq_f32 = AeskData.bms_bat_cons_f32 =
          AeskData.bms_temp_u8 = AeskData.bms_power_f32 = 0;
      return WillPopScope(
        onWillPop: () {
          return showDialog(
            context: context,
            child: CupertinoAlertDialog(
              //backgroundColor: Theme.of(context).backgroundColor,
              content: Text(
                "Çıkmak istediğinize emin misiniz?",
                style: TextStyle(fontSize: 20, color: Colors.black),
              ),
              actions: <Widget>[
                CupertinoDialogAction(
                  child: myText("HAYIR", 18, Colors.black, FontWeight.bold),
                  onPressed: () => Navigator.pop(context, false),
                ),
                CupertinoDialogAction(
                  child: myText("EVET", 18, Colors.black, FontWeight.bold),
                  onPressed: () =>
                      SystemChannels.platform.invokeMethod('SystemNavigator.pop'),
                ),
              ],
            ),
          );
        },
        child: SafeArea(
          child: aeskScaffold(
            context: context,
            myBody: Consumer<MqttAesk>(
              builder: (context, _, child) {
                final scale = MediaQuery.of(context);
                return Padding(
                  padding: EdgeInsets.all(5),
                  child: Card(
                    margin: EdgeInsets.all(10),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.center,
                      mainAxisAlignment: MainAxisAlignment.start,
                      children: <Widget>[
                        myText(
                            "\nANA SAYFA",
                            scale.size.width / 16.45714284,
                            Theme.of(context).textTheme.headline3.color,
                            FontWeight.bold),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: <Widget>[
                            Column(
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: <Widget>[
                                DataBox(
                                  ad: "Ping",
                                  veri: AeskData.ping.toString(),
                                ),
                                DataBox(
                                  ad: "BAT VOLT",
                                  veri:
                                  AeskData.bms_bat_volt_f32.toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "BAT CUR",
                                  veri: AeskData.bms_bat_current_f32
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "BAT CONS",
                                  veri:
                                  AeskData.bms_bat_cons_f32.toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "SOC",
                                  veri: AeskData.bms_soc_f32.toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "Phase B",
                                  veri: AeskData.driver_phase_b_current_f32
                                      .toStringAsFixed(2),
                                ),
                              ],
                            ),
                            Column(
                              children: <Widget>[
                                DataBox(
                                  ad: "MOTOR TEMP",
                                  veri: AeskData.driver_motor_temperature_u8
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "Phase A Current",
                                  veri: AeskData.driver_phase_a_current_f32
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "Torque",
                                  veri: AeskData.driver_vq_f32.toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "DC BUS CUR",
                                  veri: AeskData.driver_dc_bus_current_f32
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "DC BUS VOLT",
                                  veri: AeskData.driver_dc_bus_voltage_f32
                                      .toStringAsFixed(2),
                                ),
                                DataBox(
                                  ad: "IArms",
                                  veri: AeskData.driver_vd_f32.toStringAsFixed(2),
                                ),
                              ],
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                );
              },
            ),
          ),
        ),
      );
    }
  }
}

class DataBox extends StatelessWidget {
  DataBox({Key key, this.ad, this.veri}) : super(key: key);
  final String ad;
  final String veri;

  Widget build(BuildContext context) {
    final scale = MediaQuery.of(context);
    return Container(
      height: scale.size.height / 13.6686,
      width: scale.size.width / 2.4935,
      alignment: Alignment.center,
      margin: EdgeInsets.fromLTRB(10, 20, 10, 10),
      decoration: BoxDecoration(
        color: Theme.of(context).cardColor,
        borderRadius: BorderRadius.all(Radius.circular(5)),
        border: Border.all(
          color: Theme.of(context).textTheme.headline1.color,
          width: 2,
        ),
      ),
      child: FittedBox(
        child: Center(
          child: Text(
            this.ad + " : " + this.veri,
            style: TextStyle(
                color: Theme.of(context).textTheme.headline1.color,
                fontWeight: FontWeight.bold,
                fontSize: scale.size.width / 29.387755),
          ),
        ),
      ),
    );
  }
}
