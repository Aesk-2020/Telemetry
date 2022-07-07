import 'dart:math';

import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/gauge.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';
import 'package:mqtt_client/mqtt_client.dart' as mqtt;
import 'dart:typed_data';

Widget ErrorHandler(int index) {
  return Consumer<MqttAesk>(
    builder: (context, _, child) {},
  );
}

var rnd = new Random();

Widget Vcu() {
  TextEditingController kpController = TextEditingController();
  TextEditingController kiController = TextEditingController();
  TextEditingController kdController = TextEditingController();
  TextEditingController krController = TextEditingController();
  return SafeArea(
    child: SingleChildScrollView(
      child: Consumer<MqttAesk>(
        builder: (context, _, child) {
          final scale = MediaQuery.of(context);
          MqttAesk mqttAesk = Provider.of<MqttAesk>(context);
          return Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  myText("    MCU & VCU", scale.size.width / 16.457142, Theme.of(context).textTheme.headline3.color,
                      FontWeight.bold),
                  Padding(
                    padding: const EdgeInsets.fromLTRB(0, 0, 20, 0),
                    child: ElevatedButton.icon(
                        icon: Icon(AeskData.isMQTTRunning ? CupertinoIcons.play : CupertinoIcons.stop,
                            color: Theme.of(context).textTheme.headline2.color),
                        label: myText("MQTT", 12, AeskData.isMQTTRunning ? Colors.green : Colors.red, FontWeight.bold),
                        onPressed: () async {
                          if (!AeskData.isMQTTRunning) {
                            mqttAesk.disconnect();
                            dynamic state;
                            try {
                              state = await mqttAesk.connect().timeout(Duration(seconds: 5));
                            } catch (e) {
                              state = false;
                            }
                            print(state);
                            if (state == true) {
                              if (MqttAesk.isLyra) {
                                mqttAesk.subscribeToTopic("vehicle_to_interface");
                              } else {
                                mqttAesk.subscribeToTopic("vehicle_to_interface_2");
                              }
                            }
                          }
                          ;
                        }),
                  ),
                ],
              ),
              Card(
                margin: EdgeInsets.fromLTRB(20, 0, 20, 30),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    SizedBox(
                      height: 10,
                    ),
                    Padding(
                      padding: const EdgeInsets.symmetric(horizontal: 60),
                      child: Table(
                        columnWidths: {
                          0: FlexColumnWidth(1.5),
                          1: FlexColumnWidth(1),
                        },
                      ),
                    ),
                    myText("     Sürüş Modu (VCU)", scale.size.width / 20.571428,
                        Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(
                      thickness: 4,
                      color: Theme.of(context).textTheme.headline3.color,
                      endIndent: 25,
                      indent: 25,
                    ),
                    Column(
                      children: <Widget>[
                        myText(
                            AeskData.vcu_command_ignition_u1
                                ? (AeskData.vcu_command_mode_u1 ? "     SPEED MODE" : "     TORQUE MODE")
                                : "     IGNITION OFF",
                            scale.size.width / 20.571428,
                            Theme.of(context).textTheme.headline1.color,
                            FontWeight.bold),
                      ],
                    ),
                    SizedBox(
                      height: 15,
                    ),
                    myText("     Sürüş Modu (MCU)", scale.size.width / 20.571428,
                        Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(
                      thickness: 4,
                      color: Theme.of(context).textTheme.headline3.color,
                      endIndent: 25,
                      indent: 25,
                    ),
                    Column(
                      children: <Widget>[
                        myText(
                            AeskData.driver_freewheeling_u1
                                ? "      FREEWHEELING"
                                : (AeskData.driver_torque_mode_u1 ? "     SPEED MODE" : "     TORQUE MODE"),
                            scale.size.width / 20.571428,
                            Theme.of(context).textTheme.headline1.color,
                            FontWeight.bold)
                      ],
                    ),
                    SizedBox(
                      height: 15,
                    ),
                    myText("     VCU Durumu", scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color,
                        FontWeight.bold),
                    Divider(
                      thickness: 4,
                      color: Theme.of(context).textTheme.headline3.color,
                      endIndent: 25,
                      indent: 25,
                    ),
                    Column(
                      children: <Widget>[
                        AeskConditionCheck(" BMS WAKE UP", AeskData.vcu_command_bms_wake_u1, context),
                        AeskConditionCheck(" MCU WAKE UP", AeskData.vcu_command_mcu_wake_u1, context),
                        AeskConditionCheck(" BRAKE", AeskData.vcu_command_brake_u1, context),
                        AeskDirectionCheck(" DIRECTION", AeskData.vcu_command_direction_u1, context),
                      ],
                    ),
//                    SizedBox(
//                      height: 15,
//                    ),
//                    myText("     Direksiyon", scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color,
//                        FontWeight.bold),
//                    Divider(
//                      thickness: 4,
//                      color: Theme.of(context).textTheme.headline3.color,
//                      endIndent: 25,
//                      indent: 25,
//                    ),
//                    Row(
//                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
//                      children: [
//                        myText("     Açı: " + AeskData.vcu_steering_s8.toString(), scale.size.width / 20.571428,
//                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
//                        Padding(
//                          padding: const EdgeInsets.fromLTRB(0, 0, 20, 0),
//                          child: Transform.rotate(
//                            angle: AeskData.vcu_steering_s8 * pi / 180,
//                            child: CircleAvatar(
//                              backgroundImage: AssetImage("assets/images/wheel.png"),
//                              backgroundColor: Color.fromRGBO(1, 1, 1, 0),
//                            ),
//                          ),
//                        ),
//                      ],
//                    ),
                    SizedBox(
                      height: 15,
                    ),
                    Center(
                      child: Text(
                        "MCU_L Akım ve Gerilim Seviyeleri",
                        style: TextStyle(
                          color: Theme.of(context).textTheme.headline1.color,
                          fontWeight: FontWeight.bold,
                          fontSize: scale.size.width / 20.571428,
                          fontFamily: "GOTHIC",
                        ),
                        overflow: TextOverflow.fade,
                      ),
                    ),
                    Divider(
                      thickness: 4,
                      color: Theme.of(context).textTheme.headline3.color,
                      endIndent: 25,
                      indent: 25,
                    ),
                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: <Widget>[
                          Container(
                            margin: EdgeInsets.all(scale.size.width / 41.142857),
                            child: Text(
                              "Act ID:" + " " + AeskData.driver_act_id_u16.toStringAsFixed(2),
                              style: TextStyle(
                                fontWeight: FontWeight.bold,
                                fontSize: scale.size.width / 20.571428,
                                color: Theme.of(context).textTheme.headline1.color,
                                fontFamily: "GOTHIC",
                              ),
                              textAlign: TextAlign.start,
                            ),
                          ),
                          Container(
                            margin: EdgeInsets.all(scale.size.width / 41.142857),
                            alignment: Alignment.center,
                            child: Text(
                              "Act IQ:" + " " + AeskData.driver_act_iq_u16.toStringAsFixed(2),
                              style: TextStyle(
                                fontWeight: FontWeight.bold,
                                fontSize: scale.size.width / 20.571428,
                                color: Theme.of(context).textTheme.headline1.color,
                                fontFamily: "GOTHIC",
                              ),
                              textAlign: TextAlign.center,
                            ),
                          ),
                        ],
                      ),
                    ),
                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: <Widget>[
                          Container(
                            margin: EdgeInsets.all(scale.size.width / 41.142857),
                            child: myText(
                                "VD:" + " " + AeskData.driver_act_vd_s16.toStringAsFixed(2),
                                scale.size.width / 20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                          Container(
                            margin: EdgeInsets.all(scale.size.width / 41.142857),
                            child: myText(
                                "VQ:" + " " + AeskData.driver_act_vq_s16.toStringAsFixed(2),
                                scale.size.width / 20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                        ],
                      ),
                    ),
//                    Container(
//                      height: 50,
//                      alignment: Alignment.center,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                      child: Row(
//                        mainAxisAlignment: MainAxisAlignment.center,
//                        children: <Widget>[
//                          Container(
//                            //margin: EdgeInsets.all(scale.size.width/41.142857),
//                            child: myText(
//                                "Set ID:" + " " + AeskData.driver_set_id_s16.toStringAsFixed(2) + "   ",
//                                scale.size.width / 20.571428,
//                                Theme.of(context).textTheme.headline1.color,
//                                FontWeight.bold),
//                          ),
//                          Container(
//                            //margin: EdgeInsets.all(scale.size.width/41.142857),
//                            child: myText(
//                                "Set IQ:" + " " + AeskData.driver_set_iq_s16.toStringAsFixed(2),
//                                scale.size.width / 20.571428,
//                                Theme.of(context).textTheme.headline1.color,
//                                FontWeight.bold),
//                          ),
//                        ],
//                      ),
//                    ),
                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: <Widget>[
                          Container(
                            margin: EdgeInsets.all(scale.size.width / 41.142857),
                            child: myText(
                                "IDC:" + " " + AeskData.driver_idc_s16.toStringAsFixed(2),
                                scale.size.width / 20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                          Container(
                            margin: EdgeInsets.all(scale.size.width / 41.142857),
                            child: myText(
                                "VDC:" + " " + AeskData.driver_vdc_s16.toStringAsFixed(2),
                                scale.size.width / 20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                        ],
                      ),
                    ),
//                    SizedBox(
//                      height: 15,
//                    ),
//                    Center(
//                      child: Text(
//                        "MCU_R Akım ve Gerilim Seviyeleri",
//                        style: TextStyle(
//                          color: Theme.of(context).textTheme.headline1.color,
//                          fontWeight: FontWeight.bold,
//                          fontSize: scale.size.width / 20.571428,
//                          fontFamily: "GOTHIC",
//                        ),
//                        overflow: TextOverflow.fade,
//                      ),
//                    ),
//                    Divider(
//                      thickness: 4,
//                      color: Theme.of(context).textTheme.headline3.color,
//                      endIndent: 25,
//                      indent: 25,
//                    ),
//                    Container(
//                      height: 50,
//                      alignment: Alignment.center,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                      child: Row(
//                        mainAxisAlignment: MainAxisAlignment.center,
//                        children: <Widget>[
//                          Container(
//                            margin: EdgeInsets.all(scale.size.width / 41.142857),
//                            child: Text(
//                              "Act ID:" + " " + AeskData.driver_act_id_u16_2.toStringAsFixed(2),
//                              style: TextStyle(
//                                fontWeight: FontWeight.bold,
//                                fontSize: scale.size.width / 20.571428,
//                                color: Theme.of(context).textTheme.headline1.color,
//                                fontFamily: "GOTHIC",
//                              ),
//                              textAlign: TextAlign.start,
//                            ),
//                          ),
//                          Container(
//                            margin: EdgeInsets.all(scale.size.width / 41.142857),
//                            alignment: Alignment.center,
//                            child: Text(
//                              "Act IQ:" + " " + AeskData.driver_act_iq_u16_2.toStringAsFixed(2),
//                              style: TextStyle(
//                                fontWeight: FontWeight.bold,
//                                fontSize: scale.size.width / 20.571428,
//                                color: Theme.of(context).textTheme.headline1.color,
//                                fontFamily: "GOTHIC",
//                              ),
//                              textAlign: TextAlign.center,
//                            ),
//                          ),
//                        ],
//                      ),
//                    ),
//                    Container(
//                      height: 50,
//                      alignment: Alignment.center,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                      child: Row(
//                        mainAxisAlignment: MainAxisAlignment.center,
//                        children: <Widget>[
//                          Container(
//                            margin: EdgeInsets.all(scale.size.width / 41.142857),
//                            child: myText(
//                                "VD:" + " " + AeskData.driver_act_vd_s16_2.toStringAsFixed(2),
//                                scale.size.width / 20.571428,
//                                Theme.of(context).textTheme.headline1.color,
//                                FontWeight.bold),
//                          ),
//                          Container(
//                            margin: EdgeInsets.all(scale.size.width / 41.142857),
//                            child: myText(
//                                "VQ:" + " " + AeskData.driver_act_vq_s16_2.toStringAsFixed(2),
//                                scale.size.width / 20.571428,
//                                Theme.of(context).textTheme.headline1.color,
//                                FontWeight.bold),
//                          ),
//                        ],
//                      ),
//                    ),
//                    Container(
//                      height: 50,
//                      alignment: Alignment.center,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                      child: Row(
//                        mainAxisAlignment: MainAxisAlignment.center,
//                        children: <Widget>[
//                          Container(
//                            //margin: EdgeInsets.all(scale.size.width/41.142857),
//                            child: myText(
//                                "Set ID:" + " " + AeskData.driver_set_id_s16_2.toStringAsFixed(2) + "   ",
//                                scale.size.width / 20.571428,
//                                Theme.of(context).textTheme.headline1.color,
//                                FontWeight.bold),
//                          ),
//                          Container(
//                            //margin: EdgeInsets.all(scale.size.width/41.142857),
//                            child: myText(
//                                "Set IQ:" + " " + AeskData.driver_set_iq_s16_2.toStringAsFixed(2),
//                                scale.size.width / 20.571428,
//                                Theme.of(context).textTheme.headline1.color,
//                                FontWeight.bold),
//                          ),
//                        ],
//                      ),
//                    ),
//                    Container(
//                      height: 50,
//                      alignment: Alignment.center,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                      child: Row(
//                        mainAxisAlignment: MainAxisAlignment.center,
//                        children: <Widget>[
//                          Container(
//                            margin: EdgeInsets.all(scale.size.width / 41.142857),
//                            child: myText(
//                                "IDC:" + " " + AeskData.driver_idc_s16_2.toStringAsFixed(2),
//                                scale.size.width / 20.571428,
//                                Theme.of(context).textTheme.headline1.color,
//                                FontWeight.bold),
//                          ),
//                          Container(
//                            margin: EdgeInsets.all(scale.size.width / 41.142857),
//                            child: myText(
//                                "VDC:" + " " + AeskData.driver_vdc_s16_2.toStringAsFixed(2),
//                                scale.size.width / 20.571428,
//                                Theme.of(context).textTheme.headline1.color,
//                                FontWeight.bold),
//                          ),
//                        ],
//                      ),
//                    ),
                    SizedBox(
                      height: 15,
                    ),
                    myText(
                        "     MCU_L Diğer Veriler", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(
                      thickness: 4,
                      color: Theme.of(context).textTheme.headline3.color,
                      endIndent: 25,
                      indent: 25,
                    ),
                    Container(
                      child: myText("Motor Sıcaklığı : " + AeskData.driver_motortemp_u8.toString() + " °C",
                          scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText("Anlık Hız : " + AeskData.driver_actspeed_s16.toStringAsFixed(2) + " km/h",
                          scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText("Set Hız: " + AeskData.vcu_speed_set_rpm_s16.toStringAsFixed(2) + " km/h",
                          scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
//                    Container(
//                      child: myText("Set Torque : " + AeskData.vcu_set_torque_s16.toString() + " N*m",
//                          scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
//                      alignment: Alignment.center,
//                      height: 50,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                    ),
//                    SizedBox(
//                      height: 15,
//                    ),
//                    myText(
//                        "     MCU_R Diğer Veriler", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
//                    Divider(
//                      thickness: 4,
//                      color: Theme.of(context).textTheme.headline3.color,
//                      endIndent: 25,
//                      indent: 25,
//                    ),
//                    Container(
//                      child: myText("Motor Sıcaklığı : " + AeskData.driver_motortemp_u8_2.toString() + " °C",
//                          scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
//                      alignment: Alignment.center,
//                      height: 50,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                    ),
//                    Container(
//                      child: myText("Anlık Hız : " + AeskData.driver_actspeed_s16_2.toStringAsFixed(2) + " km/h",
//                          scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
//                      alignment: Alignment.center,
//                      height: 50,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                    ),
//                    Container(
//                      child: myText("Set Hız: " + AeskData.vcu_speed_set_rpm_s16.toStringAsFixed(2) + " km/h",
//                          scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
//                      alignment: Alignment.center,
//                      height: 50,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                    ),
//                    Container(
//                      child: myText("Set Torque : " + AeskData.vcu_set_torque_2_s16.toString() + " N*m",
//                          scale.size.width / 20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
//                      alignment: Alignment.center,
//                      height: 50,
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      decoration: BoxDecoration(
//                        border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
//                        borderRadius: BorderRadius.circular(3),
//                      ),
//                    ),
//                    SizedBox(
//                      height: 15,
//                    ),
                    myText("     MCU_L Hatalar", scale.size.width / 20.571428,
                        Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(
                      thickness: 4,
                      color: Theme.of(context).textTheme.headline3.color,
                      endIndent: 25,
                      indent: 25,
                    ),
                    Column(
                      children: <Widget>[
//                        AeskErrorCheck(" OVER CUR I_A", AeskData.driver_overcur_ia_u1, context),
//                        AeskErrorCheck(" OVER CUR I_B", AeskData.driver_overcur_ib_u1, context),
//                        AeskErrorCheck(" OVER CUR I_C", AeskData.driver_overcur_ic_u1, context),
                        AeskErrorCheck(" OVER CUR I_DC ", AeskData.driver_overcur_idc_u1, context),
                        AeskErrorCheck(" OVER VOLT V_DC", AeskData.driver_overvolt_vdc_u1, context),
                        AeskErrorCheck(" UNDER VOLT V_DC", AeskData.driver_undervolt_vdc_u1, context),
//                        AeskErrorCheck(" UNDER SPEED", AeskData.driver_underspeed_u1, context),
//                        AeskErrorCheck(" OVER SPEED", AeskData.driver_overspeed_u1, context),
                        AeskErrorCheck(" OVER TEMP", AeskData.driver_overtemp_u1, context),
                        AeskConditionCheck(" ZPC FINISHED", AeskData.driver_zpcf_u1, context),
                        AeskConditionCheck(" PWM_ENABLED", AeskData.driver_pwm_enabled_u1, context),
                      ],
                    ),
//                    SizedBox(height: 15,),
//                    myText("     MCU_R Hatalar", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
//                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
//                    Column(
//                      children: <Widget>[
//                        AeskErrorCheck(" OVER CUR I_A", AeskData.driver_overcur_ia_u1_2, context),
//                        AeskErrorCheck(" OVER CUR I_B", AeskData.driver_overcur_ib_u1_2, context),
//                        AeskErrorCheck(" OVER CUR I_C", AeskData.driver_overcur_ic_u1_2, context),
//                        AeskErrorCheck(" OVER CUR I_DC ", AeskData.driver_overcur_idc_u1_2, context),
//                        AeskErrorCheck(" UNDER VOLT V_DC", AeskData.driver_undervolt_vdc_u1_2, context),
//                        AeskErrorCheck(" OVER VOLT V_DC", AeskData.driver_overvolt_vdc_u1_2, context),
//                        AeskErrorCheck(" UNDER SPEED", AeskData.driver_underspeed_u1_2, context),
//                        AeskErrorCheck(" OVER SPEED", AeskData.driver_overspeed_u1_2, context),
//                        AeskErrorCheck(" OVER TEMP", AeskData.driver_overtemp_u1_2, context),
//                        AeskConditionCheck(" ZPC FINISHED", AeskData.driver_zpcf_u1_2, context),
//                        AeskConditionCheck(" PWM_ENABLED", AeskData.driver_pwm_enabled_u1_2, context),
//                      ],
//                    ),
                    SizedBox(
                      height: 15,
                    ),
//                    myText("     Set Kp Kd Ki Kr", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
//                    Divider(
//                      thickness: 4,
//                      color: Theme.of(context).textTheme.headline3.color,
//                      endIndent: 25,
//                      indent: 25,
//                    ),
//                    SizedBox(
//                      height: 10,
//                    ),
//                    Container(
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      child: TextField(
//                        style: TextStyle(
//                            fontFamily: "GOTHIC",
//                            fontSize: 20,
//                            color: Theme.of(context).textTheme.headline1.color,
//                            fontWeight: FontWeight.bold),
//                        keyboardType: TextInputType.numberWithOptions(),
//                        controller: kpController,
//                        decoration: InputDecoration(
//                          border: OutlineInputBorder(),
//                          labelText: "Kp",
//                          suffixIcon: Icon(Icons.settings_input_component),
//                          labelStyle: TextStyle(
//                              fontFamily: "GOTHIC",
//                              fontSize: 20,
//                              color: Theme.of(context).textTheme.headline1.color,
//                              fontWeight: FontWeight.bold),
//                        ),
//                      ),
//                    ),
//                    Container(
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      child: TextField(
//                        style: TextStyle(
//                            fontFamily: "GOTHIC",
//                            fontSize: 20,
//                            color: Theme.of(context).textTheme.headline1.color,
//                            fontWeight: FontWeight.bold),
//                        controller: kiController,
//                        keyboardType: TextInputType.numberWithOptions(),
//                        decoration: InputDecoration(
//                          border: OutlineInputBorder(),
//                          labelText: "Ki",
//                          suffixIcon: Icon(Icons.settings_input_component),
//                          labelStyle: TextStyle(
//                              fontFamily: "GOTHIC",
//                              fontSize: 20,
//                              color: Theme.of(context).textTheme.headline1.color,
//                              fontWeight: FontWeight.bold),
//                        ),
//                      ),
//                    ),
//                    Container(
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      child: TextField(
//                        style: TextStyle(
//                            fontFamily: "GOTHIC",
//                            fontSize: 20,
//                            color: Theme.of(context).textTheme.headline1.color,
//                            fontWeight: FontWeight.bold),
//                        controller: kdController,
//                        keyboardType: TextInputType.numberWithOptions(),
//                        decoration: InputDecoration(
//                          border: OutlineInputBorder(),
//                          labelText: "Kd",
//                          suffixIcon: Icon(Icons.settings_input_component),
//                          labelStyle: TextStyle(
//                              fontFamily: "GOTHIC",
//                              fontSize: 20,
//                              color: Theme.of(context).textTheme.headline1.color,
//                              fontWeight: FontWeight.bold),
//                        ),
//                      ),
//                    ),
//                    Container(
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      child: TextField(
//                        style: TextStyle(
//                            fontFamily: "GOTHIC",
//                            fontSize: 20,
//                            color: Theme.of(context).textTheme.headline1.color,
//                            fontWeight: FontWeight.bold),
//                        controller: krController,
//                        keyboardType: TextInputType.numberWithOptions(),
//                        decoration: InputDecoration(
//                          suffixIcon: Icon(Icons.settings_input_component),
//                          border: OutlineInputBorder(),
//                          labelText: "Kr",
//                          labelStyle: TextStyle(
//                              fontFamily: "GOTHIC",
//                              fontSize: 20,
//                              color: Theme.of(context).textTheme.headline1.color,
//                              fontWeight: FontWeight
//                                  .bold), /*
//                            hintText: "Kp",
//                            hintStyle: TextStyle(
//                                fontFamily: "GOTHIC",
//                                fontSize: 20,
//                                color: Theme.of(context).textTheme.headline1.color,
//                                fontWeight: FontWeight.normal
//                            ),*/
//                        ),
//                      ),
//                    ),
//                    Container(
//                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
//                      child: Center(
//                        child: Row(
//                          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
//                          children: [
//                            ElevatedButton.icon(
//                              icon: Icon(CupertinoIcons.paperplane_fill,
//                                  color: Theme.of(context).textTheme.headline2.color),
//                              label: myText("Send", 20, Theme.of(context).textTheme.headline2.color, FontWeight.bold),
//                              onPressed: () async {
//                                final builder = mqtt.MqttClientPayloadBuilder();
//                                var kp = double.parse(kpController.text);
//                                var ki = double.parse(kiController.text);
//                                var kd = double.parse(kdController.text);
//                                var kr = double.parse(krController.text);
//
//                                builder.addByte(0x14); //SYNC1
//                                builder.addByte(0x04); //SYNC2
//                                builder.addByte(0x31); //VEHICLE
//                                builder.addByte(0x06); //TARGET
//                                builder.addByte(0x80); //SOURCE
//                                builder.addByte(0x19); //SOURCE_MSG_ID PID FROM MOBILE
//                                builder.addByte(0x20); //MSG SIZE
//                                builder.addDouble(kp);
//                                builder.addDouble(ki);
//                                builder.addDouble(kd);
//                                builder.addDouble(kr);
//                                builder.addByte(0xA0); //INDEX_L
//                                builder.addByte(0x01); //INDEX_H
//                                builder.addByte(0x01); //CRC_L - SALLAMA CRC
//                                builder.addByte(0x01); //CRC_H - GOMULUDE BYPASS EDILIYOR
//
//                                MqttAesk.client.publishMessage(
//                                    MqttAesk.isLyra ? "interface_to_vehicle" : "interface_to_vehicle_2",
//                                    mqtt.MqttQos.atMostOnce,
//                                    builder.payload);
//                                print("Kp: " +
//                                    kpController.text +
//                                    "\nKd: " +
//                                    kdController.text +
//                                    "\nKi: " +
//                                    kiController.text +
//                                    "\nKr: " +
//                                    krController.text);
//                                print(MqttAesk.isLyra.toString());
//                              },
//                            ),
//                            ElevatedButton.icon(
//                              icon: Icon(CupertinoIcons.question_circle_fill,
//                                  color: Theme.of(context).textTheme.headline2.color),
//                              label: myText("Query", 20, Theme.of(context).textTheme.headline2.color, FontWeight.bold),
//                              onPressed: () async {
//                                final builder = mqtt.MqttClientPayloadBuilder();
//                                builder.addByte(0x14); //SYNC1
//                                builder.addByte(0x04); //SYNC2
//                                builder.addByte(0x31); //VEHICLE
//                                builder.addByte(0x06); //TARGET
//                                builder.addByte(0x80); //SOURCE
//                                builder.addByte(0x1A); //SOURCE_MSG_ID QUERY FROM MOBILE
//                                builder.addByte(0x01); //MSG SIZE
//                                builder.addByte(0x00); //MSG
//                                builder.addByte(0xA0); //INDEX_L
//                                builder.addByte(0x01); //INDEX_H
//                                builder.addByte(0x01); //CRC_L - SALLAMA CRC
//                                builder.addByte(0x01); //CRC_H - GOMULUDE BYPASS EDILIYOR
//
//                                MqttAesk.client.publishMessage(
//                                    MqttAesk.isLyra ? "interface_to_vehicle" : "interface_to_vehicle_2",
//                                    mqtt.MqttQos.atMostOnce,
//                                    builder.payload);
//                                print("Query sent");
//                              },
//                            ),
//                          ],
//                        ),
//                      ),
//                    ),
                    SizedBox(
                      height: 1,
                    ),
                    Container(
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      child: Center(
                        child: Row(
                          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                          children: [
                            ElevatedButton.icon(
                              icon: Icon(CupertinoIcons.power, color: Theme.of(context).textTheme.headline2.color),
                              label:
                                  myText("Reset TCU", 12, Theme.of(context).textTheme.headline2.color, FontWeight.bold),
                              onPressed: () async {
                                final builder = mqtt.MqttClientPayloadBuilder();
                                builder.addByte(0x14); //SYNC1
                                builder.addByte(0x04); //SYNC2
                                builder.addByte(0x31); //VEHICLE
                                builder.addByte(0x06); //TARGET
                                builder.addByte(0x80); //SOURCE
                                builder.addByte(0x17); //SOURCE MSG ID RESET TCU
                                builder.addByte(0x01); //MSG SIZE
                                builder.addByte(0x0B); //MSG
                                builder.addByte(0xA0); //INDEX_L
                                builder.addByte(0x01); //INDEX_H
                                builder.addByte(0x01); //CRC_L - SALLAMA CRC
                                builder.addByte(0x01); //CRC_H - GOMULUDE BYPASS EDILIYOR

                                MqttAesk.client.publishMessage(
                                    MqttAesk.isLyra ? "interface_to_vehicle" : "interface_to_vehicle_2",
                                    mqtt.MqttQos.atMostOnce,
                                    builder.payload);
                              },
                            ),
                            ElevatedButton.icon(
                              icon: Icon(CupertinoIcons.time_solid, color: Theme.of(context).textTheme.headline2.color),
                              label: myText(
                                  "Set RTC TCU", 12, Theme.of(context).textTheme.headline2.color, FontWeight.bold),
                              onPressed: () async {
                                final builder = mqtt.MqttClientPayloadBuilder();
                                builder.addByte(0x14); //SYNC1
                                builder.addByte(0x04); //SYNC2
                                builder.addByte(0x31); //VEHICLE
                                builder.addByte(0x06); //TARGET
                                builder.addByte(0x80); //SOURCE
                                builder.addByte(0x1E); //SOURCE MSG ID SET RTC TCU
                                builder.addByte(0x06); //MSG SIZE
                                builder.addByte(DateTime.now().hour); //MSG
                                builder.addByte(DateTime.now().minute); //MSG
                                builder.addByte(DateTime.now().second); //MSG
                                builder.addByte(DateTime.now().year - 2000); //MSG
                                builder.addByte(DateTime.now().month); //MSG
                                builder.addByte(DateTime.now().day); //MSG
                                builder.addByte(0xA0); //INDEX_L
                                builder.addByte(0x01); //INDEX_H
                                builder.addByte(0x01); //CRC_L - SALLAMA CRC
                                builder.addByte(0x01); //CRC_H - GOMULUDE BYPASS EDILIYOR

                                MqttAesk.client.publishMessage(
                                    MqttAesk.isLyra ? "interface_to_vehicle" : "interface_to_vehicle_2",
                                    mqtt.MqttQos.atMostOnce,
                                    builder.payload);
                              },
                            ),
                          ],
                        ),
                      ),
                    ),
                    SizedBox(
                      height: 15,
                    ),
                  ],
                ),
              ),
            ],
          );
        },
      ),
    ),
  );
}

class VcuPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Vcu(),
    );
  }
}
