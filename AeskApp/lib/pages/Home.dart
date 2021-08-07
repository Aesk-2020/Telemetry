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
            builder: (BuildContext context)
            {
              return CupertinoAlertDialog(
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
              );
            }
          );
        },
        child: SafeArea(
          child: aeskScaffold(
            context: context,
            myBody: Consumer<MqttAesk>(
              builder: (context, _, child) {
                final scale = MediaQuery.of(context);
                return SingleChildScrollView(
                  child: Padding(
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
                                    ad: "TCU RTC",
                                    veri: AeskData.tcu_hour_u8.toString()   + ":"
                                        + AeskData.tcu_minute_u8.toString() + ":"
                                        + AeskData.tcu_second_u8.toString(),
                                  ),
                                  DataBox(
                                    ad: "SD result",
                                    veri: AeskData.sd_result_u8.toString(),
                                  ),
                                  DataBox(
                                    ad: "Set Velocity",
                                    veri: AeskData.vcu_speed_set_rpm_s16.toString(),
                                  ),
                                  DataBox(
                                    ad: "Act Speed L",
                                    veri: AeskData.driver_actspeed_s16.toStringAsFixed(1),
                                  ),
                                  DataBox(
                                    ad: "Set Torque L",
                                    veri: AeskData.vcu_set_torque_s16.toString(),
                                  ),
                                  DataBox(
                                    ad: "IDC L",
                                    veri: AeskData.driver_idc_s16.toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "VDC L",
                                    veri: AeskData.driver_vdc_s16
                                        .toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "Bat Cur",
                                    veri: AeskData.bms_bat_current_f32
                                        .toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "Bat Cons",
                                    veri:
                                    AeskData.bms_bat_cons_f32.toStringAsFixed(1),
                                  ),
                                  DataBox(
                                    ad: "Kp",
                                    veri: AeskData.kp.toString(),
                                  ),
                                ],
                              ),
                              Column(
                                children: <Widget>[
                                  DataBox(
                                    ad: "Motor Temp",
                                    veri: AeskData.driver_motortemp_u8.toString(),
                                  ),
                                  DataBox(
                                    ad: "SD result write",
                                    veri: AeskData.sd_result_write_u8.toString(),
                                  ),
                                  DataBox(
                                    ad: "Steering Angle",
                                    veri: AeskData.vcu_steering_s8.toString(),
                                  ),
                                  DataBox(
                                    ad: "Act Speed R",
                                    veri: AeskData.driver_actspeed_s16_2.
                                    toStringAsFixed(1),
                                  ),
                                  DataBox(
                                    ad: "Set Torque R",
                                    veri: AeskData.vcu_set_torque_2_s16.
                                    toString(),
                                  ),
                                  DataBox(
                                    ad: "IDC R",
                                    veri: AeskData.driver_idc_s16_2
                                        .toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "VDC R",
                                    veri: AeskData.driver_vdc_s16_2
                                        .toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "Bat Volt",
                                    veri:
                                    AeskData.bms_bat_volt_f32.toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "SoC",
                                    veri: AeskData.bms_soc_f32.toStringAsFixed(1),
                                  ),
                                  DataBox(
                                    ad: "Ki",
                                    veri: AeskData.ki.toString(),
                                  ),
                                ],
                              ),
                            ],
                          ),
                        ],
                      ),
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
          .driver_set_torque_s16 = AeskData.driver_act_iq_u16 = 0;
      AeskData.driver_set_id_s16 = AeskData.driver_set_iq_s16 =
          AeskData.driver_act_id_u16 = 0; AeskData.driver_motortemp_u8 = 0; AeskData
          .driver_idc_s16 = 0; AeskData.driver_vdc_s16 = 0;
      AeskData.driver_acttorque_s8 = 0; AeskData.driver_errorstatus_u16 = 0;
          AeskData.vcu_set_torque_s16 = 0; AeskData.bms_bat_cons_f32 = 0;
          AeskData.bms_temp_u8 = AeskData.bms_power_f32 = 0;
      return WillPopScope(
        onWillPop: () {
          return showDialog(
              context: context,
              builder: (BuildContext context)
              {
                return CupertinoAlertDialog(
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
                );
              }
          );
        },
        child: SafeArea(
          child: aeskScaffold(
            context: context,
            myBody: Consumer<MqttAesk>(
              builder: (context, _, child) {
                final scale = MediaQuery.of(context);
                return SingleChildScrollView(
                  child: Padding(
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
                                    ad: "TCU RTC",
                                    veri: AeskData.tcu_hour_u8.toString()   + ":"
                                        + AeskData.tcu_minute_u8.toString() + ":"
                                        + AeskData.tcu_second_u8.toString(),
                                  ),
                                  DataBox(
                                    ad: "SD result",
                                    veri: AeskData.sd_result_u8.toString(),
                                  ),
                                  DataBox(
                                    ad: "Set Velocity",
                                    veri: AeskData.vcu_speed_set_rpm_s16.toString(),
                                  ),
                                  DataBox(
                                    ad: "Act Speed L",
                                    veri: AeskData.driver_actspeed_s16.toStringAsFixed(1),
                                  ),
                                  DataBox(
                                    ad: "Set Torque L",
                                    veri: AeskData.vcu_set_torque_s16.toString(),
                                  ),
                                  DataBox(
                                    ad: "IDC L",
                                    veri: AeskData.driver_idc_s16.toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "VDC L",
                                    veri: AeskData.driver_vdc_s16
                                        .toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "Bat Cur",
                                    veri: AeskData.bms_bat_current_f32
                                        .toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "Bat Cons",
                                    veri:
                                    AeskData.bms_bat_cons_f32.toStringAsFixed(1),
                                  ),
                                  DataBox(
                                    ad: "Kp",
                                    veri: AeskData.kp.toString(),
                                  ),
                                ],
                              ),
                              Column(
                                children: <Widget>[
                                  DataBox(
                                    ad: "Motor Temp",
                                    veri: AeskData.driver_motortemp_u8.toString(),
                                  ),
                                  DataBox(
                                    ad: "SD result write",
                                    veri: AeskData.sd_result_write_u8.toString(),
                                  ),
                                  DataBox(
                                    ad: "Steering Angle",
                                    veri: AeskData.vcu_steering_s8.toString(),
                                  ),
                                  DataBox(
                                    ad: "Act Speed R",
                                    veri: AeskData.driver_actspeed_s16_2.
                                    toStringAsFixed(1),
                                  ),
                                  DataBox(
                                    ad: "Set Torque R",
                                    veri: AeskData.vcu_set_torque_2_s16.
                                    toString(),
                                  ),
                                  DataBox(
                                    ad: "IDC R",
                                    veri: AeskData.driver_idc_s16_2
                                        .toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "VDC R",
                                    veri: AeskData.driver_vdc_s16_2
                                        .toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "Bat Volt",
                                    veri:
                                    AeskData.bms_bat_volt_f32.toStringAsFixed(2),
                                  ),
                                  DataBox(
                                    ad: "SoC",
                                    veri: AeskData.bms_soc_f32.toStringAsFixed(1),
                                  ),
                                  DataBox(
                                    ad: "Ki",
                                    veri: AeskData.ki.toString(),
                                  ),
                                ],
                              ),
                            ],
                          ),
                        ],
                      ),
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
            this.ad + ":  " + this.veri,
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
