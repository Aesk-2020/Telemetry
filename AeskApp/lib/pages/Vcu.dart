import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/gauge.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';



Widget ErrorHandler(int index){

  return Consumer<MqttAesk>(
    builder: (context, _, child){

    },
  );

}
Widget Vcu(){
  return SafeArea(
    child: SingleChildScrollView(
      child: Consumer<MqttAesk>(
        builder: (context, _, child){
          final scale = MediaQuery.of(context);
          return Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              myText("    MCU & VCU", scale.size.width/16.457142, Theme.of(context).textTheme.headline3.color, FontWeight.bold),
              Card(
                margin: EdgeInsets.fromLTRB(20, 0, 20, 30),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    SizedBox(height: 10,),
                    Padding(
                      padding: const EdgeInsets.symmetric(horizontal: 60),
                      child: Table(
                        columnWidths: {
                          0 : FlexColumnWidth(1.5),
                          1 : FlexColumnWidth(1),
                        },
                      ),
                    ),
                    myText("     Sürüş Modu (VCU)", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Column(
                      children: <Widget>[
                        myText(AeskData.vcu_command_ignition_u1 ? "      IGNITION OFF" : (AeskData.vcu_command_mode_u1 ? "     TORQUE MODE" : "     SPEED MODE"), scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      ],
                    ),
                    SizedBox(height: 15,),
                    myText("     Sürüş Modu (MCU)", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Column(
                      children: <Widget>[
                        myText(AeskData.driver_freewheeling_u1 ? "      FREEWHEELING" : (AeskData.driver_torque_mode_u1 ? "     TORQUE MODE" : "     SPEED MODE"), scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold)
                      ],
                    ),
                    SizedBox(height: 15,),
                    myText("     VCU Durumu", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Column(
                      children: <Widget>[
                        AeskConditionCheck(" BMS WAKE UP", AeskData.vcu_command_bms_wake_u1, context),
                        AeskConditionCheck(" MCU WAKE UP", AeskData.vcu_command_mcu_wake_u1, context),
                        AeskConditionCheck(" BRAKE", AeskData.vcu_command_brake_u1, context),
                        AeskDirectionCheck(" DIRECTION", AeskData.vcu_command_direction_u1, context),
                      ],
                    ),
                    SizedBox(height: 15,),
                    myText("     Hatalar", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Column(
                      children: <Widget>[
                        AeskErrorCheck(" OVER CUR I_A", AeskData.driver_overcur_ia_u1, context),
                        AeskErrorCheck(" OVER CUR I_B", AeskData.driver_overcur_ib_u1, context),
                        AeskErrorCheck(" OVER CUR I_C", AeskData.driver_overcur_ic_u1, context),
                        AeskErrorCheck(" OVER CUR I_DC ", AeskData.driver_overcur_idc_u1, context),
                        AeskErrorCheck(" UNDER VOLT V_DC", AeskData.driver_undervolt_vdc_u1, context),
                        AeskErrorCheck(" OVER VOLT V_DC", AeskData.driver_overvolt_vdc_u1, context),
                        AeskErrorCheck(" UNDER SPEED", AeskData.driver_underspeed_u1, context),
                        AeskErrorCheck(" OVER SPEED", AeskData.driver_overspeed_u1, context),
                        AeskErrorCheck(" OVER TEMP", AeskData.driver_overtemp_u1, context),
                        AeskConditionCheck(" ZPC FINISHED", AeskData.driver_zpcf_u1, context),
                        AeskConditionCheck(" PWM_ENABLED", AeskData.driver_pwm_enabled_u1, context),
                          ],
                        ),
                    SizedBox(height: 15,),
                    Center(
                      child: Text("MCU Akım ve Gerilim Seviyeleri",
                        style: TextStyle(
                          color: Theme.of(context).textTheme.headline1.color,
                          fontWeight: FontWeight.bold,
                          fontSize: scale.size.width/20.571428,
                          fontFamily: "GOTHIC",
                        ),
                        overflow: TextOverflow.fade,),
                    ),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(
                            width: 2,
                            color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: <Widget>[
                          Container(
                            margin: EdgeInsets.all(scale.size.width/41.142857),
                            child: Text("Act ID:" + " " + AeskData.driver_act_id_u16.toStringAsFixed(2),style: TextStyle(fontWeight: FontWeight.bold,fontSize: scale.size.width/20.571428,color: Theme.of(context).textTheme.headline1.color,fontFamily: "GOTHIC",),textAlign: TextAlign.start,),),
                          Container(
                            margin: EdgeInsets.all(scale.size.width/41.142857),
                            alignment: Alignment.center,
                            child: Text("Act IQ:" + " " + AeskData.driver_act_iq_u16.toStringAsFixed(2), style: TextStyle(fontWeight: FontWeight.bold,fontSize: scale.size.width/20.571428,color: Theme.of(context).textTheme.headline1.color,fontFamily: "GOTHIC",),textAlign: TextAlign.center,),),
                        ],
                      ),
                    ),
                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(
                            width: 2,
                            color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: <Widget>[
                          Container(
                            margin: EdgeInsets.all(scale.size.width/41.142857),
                            child: myText(
                                "VD:" +" "+
                                    AeskData.driver_act_vd_s16
                                        .toStringAsFixed(2),
                                scale.size.width/20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                          Container(
                            margin: EdgeInsets.all(scale.size.width/41.142857),
                            child: myText(
                                "VQ:" +" "+
                                    AeskData.driver_act_vq_s16
                                        .toStringAsFixed(2),
                                scale.size.width/20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                        ],
                      ),
                    ),
                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(
                            width: 2,
                            color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: <Widget>[
                          Container(
                            //margin: EdgeInsets.all(scale.size.width/41.142857),
                            child: myText(
                                "Set ID:" +
                                    " " +
                                    AeskData.driver_set_id_s16
                                        .toStringAsFixed(2)+"   ",
                                scale.size.width/20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                          Container(
                            //margin: EdgeInsets.all(scale.size.width/41.142857),
                            child: myText(
                                "Set IQ:" +
                                    " " +
                                    AeskData.driver_set_iq_s16
                                        .toStringAsFixed(2),
                                scale.size.width/20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                        ],
                      ),
                    ),
                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(
                            width: 2,
                            color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: <Widget>[
                          Container(
                            margin: EdgeInsets.all(scale.size.width/41.142857),
                            child: myText(
                                "IDC:" +
                                    " " +
                                    AeskData.driver_idc_s16
                                        .toStringAsFixed(2),
                                scale.size.width/20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                          Container(
                            margin: EdgeInsets.all(scale.size.width/41.142857),
                            child: myText(
                                "VDC:" +
                                    " " +
                                    AeskData.driver_vdc_s16
                                        .toStringAsFixed(2),
                                scale.size.width/20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                        ],
                      ),
                    ),
                    SizedBox(height: 15,),
                    myText("     Diğer Veriler", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Container(
                      child: myText(
                          "Motor Sıcaklığı : " +AeskData.driver_motortemp_u8.toString()+ " °C",
                          scale.size.width/20.571428,
                          Theme.of(context).textTheme.headline1.color,
                          FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(
                            width: 2,
                            color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText(
                          "Anlık Hız : "+AeskData.driver_actspeed_s16.toStringAsFixed(2)+" km/h",
                          scale.size.width/20.571428,
                          Theme.of(context).textTheme.headline1.color,
                          FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(
                            width: 2,
                            color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText("Set Hız: "+AeskData.vcu_speed_set_rpm_s16.toStringAsFixed(2)+" km/h", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText(
                          "Set Torque : "+AeskData.vcu_set_torque_s16.toString() + " N*m",
                          scale.size.width/20.571428,
                          Theme.of(context).textTheme.headline1.color,
                          FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(
                            width: 2,
                            color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    SizedBox(height: 15,),
                    AeskGauge(),
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