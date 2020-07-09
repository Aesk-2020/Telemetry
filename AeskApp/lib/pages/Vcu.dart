import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:aeskapp/custom_widgets/gauge.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';



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
                        children: <TableRow>[
                          TableRow(
                            children: <Widget>[
                              myText("Komutlar", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText("Durum", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                            ],
                          ),
                        ],
                      ),
                    ),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Padding(
                      padding: const EdgeInsets.fromLTRB(60, 0, 0, 0),
                      child: Table(
                        children: <TableRow>[
                          TableRow(
                            children: <Widget>[
                              myText("IGNITION", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText(AeskData.drive_status_ignition_u1 ? "AKTİF":"İNAKTİF", scale.size.width/20.571428, AeskData.drive_status_ignition_u1 ? Colors.green : Colors.red , FontWeight.bold)
                            ],
                          ),
                          TableRow(
                            children: <Widget>[
                              myText("BRAKE", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText(AeskData.drive_status_brake_u1 ? "AKTİF":"İNAKTİF", scale.size.width/20.571428, AeskData.drive_status_brake_u1 ? Colors.green : Colors.red, FontWeight.bold)
                            ],
                          ),
                          TableRow(
                            children: <Widget>[
                              myText("DIRECTION", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText(AeskData.drive_status_direction_u1 ? "GERİ":"İLERİ", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold)
                            ],
                          ),
                        ],
                      ),
                    ),

                    SizedBox(height: 15,),
                    myText("     Hatalar", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Column(
                      children: <Widget>[
                        AeskErrorCheck(" ZPC", !AeskData.driver_error_ZPC_u1, context),
                        AeskErrorCheck(" PWM", !AeskData.driver_error_PWM_u1, context),
                        AeskErrorCheck(" DC BARA", AeskData.driver_error_DC_bara_u1, context),
                        AeskErrorCheck(" TEMPERATURE ", AeskData.driver_error_temprature_u1, context),
                        AeskErrorCheck(" DC BARA CURRENT", AeskData.driver_error_DC_bara_current_u1, context),
                        AeskErrorCheck(" TORQUE LIMIT", AeskData.driver_error_WakeUp_u1, context),
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
                            child: Text("ID:" + " " + AeskData.driver_id_f32.toStringAsFixed(2),style: TextStyle(fontWeight: FontWeight.bold,fontSize: scale.size.width/20.571428,color: Theme.of(context).textTheme.headline1.color,fontFamily: "GOTHIC",),textAlign: TextAlign.start,),),
                          Container(
                            margin: EdgeInsets.all(scale.size.width/41.142857),
                            alignment: Alignment.center,
                            child: Text("IQ:" + " " + AeskData.driver_iq_f32.toStringAsFixed(2), style: TextStyle(fontWeight: FontWeight.bold,fontSize: scale.size.width/20.571428,color: Theme.of(context).textTheme.headline1.color,fontFamily: "GOTHIC",),textAlign: TextAlign.center,),),
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
                                "IArms:" +" "+
                                    AeskData.driver_vd_f32
                                        .toStringAsFixed(2),
                                scale.size.width/20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                          Container(
                            margin: EdgeInsets.all(scale.size.width/41.142857),
                            child: myText(
                                "Torque:" +" "+
                                    AeskData.driver_vq_f32
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
                                "Phase A:" +
                                    " " +
                                    AeskData.driver_phase_a_current_f32
                                        .toStringAsFixed(2)+"   ",
                                scale.size.width/20.571428,
                                Theme.of(context).textTheme.headline1.color,
                                FontWeight.bold),
                          ),
                          Container(
                            //margin: EdgeInsets.all(scale.size.width/41.142857),
                            child: myText(
                                "Phase B:" +
                                    " " +
                                    AeskData.driver_phase_b_current_f32
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
                                    AeskData.driver_dc_bus_current_f32
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
                                    AeskData.driver_dc_bus_voltage_f32
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
                          "Motor Sıcaklığı : " +AeskData.driver_motor_temperature_u8.toStringAsFixed(2)+ " °C",
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
                          "Anlık Hız : "+AeskData.driver_actual_velocity_u8.toStringAsFixed(2)+" km/h",
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
                      child: myText("Set Hız: "+AeskData.vcu_set_velocity_u8.toStringAsFixed(2)+" km/h", scale.size.width/20.571428, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
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
                          "Gidilen Mesafe : "+AeskData.driver_odometer_u32.toStringAsFixed(2),
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