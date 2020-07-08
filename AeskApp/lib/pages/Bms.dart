import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

Widget Bms(){
  return SingleChildScrollView(
    child: SafeArea(
        child: Consumer<MqttAesk>(
            builder: (context, _, child){
              return Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  myText("   BATARYA YÖNETİM SİSTEMİ", 25, Theme.of(context).textTheme.headline3.color, FontWeight.bold),
                  Card(
                    margin: EdgeInsets.fromLTRB(20, 0, 20, 30),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: <Widget>[
                        SizedBox(height: 10,),
                        myText("    Batarya", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                          children: <Widget>[
                            Image(image: AssetImage("assets/images/battery-bms.png"), width: 175,),
                            Column(
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: <Widget>[
                                myText(AeskData.bms_bat_volt_f32.toStringAsFixed(2) + " V", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("Gerilim", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                SizedBox(height: 5,),
                                myText(AeskData.bms_temp_u8.toStringAsFixed(2) + " °C", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("Sıcaklık", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                SizedBox(height: 5,),
                                myText(AeskData.bms_bat_current_f32.toStringAsFixed(2) + " A", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("Akım", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                SizedBox(height: 5,),
                                myText(AeskData.bms_power_f32.toStringAsFixed(2) + " W", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("Güç", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                SizedBox(height: 5,),
                                myText(AeskData.bms_soc_f32.toStringAsFixed(2) + " %", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("SoC", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                SizedBox(height: 5,),
                                myText(AeskData.bms_bat_cons_f32.toStringAsFixed(2) + " Wh", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("Tüketim", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              ],
                            )
                          ],
                        ),
                        myText("    Hatalar", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                        Column(
                          children: <Widget>[
                            AeskConditionRow("HIGH VOLTAGE", AeskData.bms_error_high_voltage_u1, context),
                            AeskConditionRow("LOW VOLTAGE", AeskData.bms_error_low_voltage_u1, context),
                            AeskConditionRow("HIGH TEMPRATURE", AeskData.bms_error_high_temp_u1, context),
                            AeskConditionRow("OVER CURRENT", AeskData.bms_error_over_current_u1, context),
                            AeskConditionRow("ISOLATION", AeskData.bms_error_isolation_u1, context),
                            AeskConditionRow("FATAL", AeskData.bms_error_fatal_u1, context),
                          ],
                        ),
                        SizedBox(height: 15,),
                        myText("    DC BUS DURUMU", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                        Column(
                          children: <Widget>[
                            AeskConditionRow("PRECHARGE", AeskData.bms_state_precharge_u1, context),
                            AeskConditionRow("DISCHARGE", AeskData.bms_state_discharge_u1, context),
                            AeskConditionRow("CHARGE", AeskData.bms_state_charge_u1, context),
                            AeskConditionRow("DC BUS READY", AeskData.bms_state_dcbus_ready_u1, context),
                          ],
                        ),
                        SizedBox(height: 15,)
                      ],
                    ),
                  ),
                ],
              );
            }
        )
    ),
  );
}

class BmsPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Bms(),
    );
  }
}