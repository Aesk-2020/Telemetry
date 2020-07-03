import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/gauge.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';



Widget ErrorHandler(int index){

  return Consumer<MqttAesk>(
    builder: (context, _, child){

      if(AeskData.driver_error_ZPC_u1 && index == 0)
        return myText("ZPC HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.driver_error_PWM_u1 && index == 1)
        return myText("PWM HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.driver_error_DC_bara_u1 && index == 2)
        return myText("DC BARA HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.driver_error_temprature_u1 && index == 3)
        return myText("TEMPERATURE HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.driver_error_DC_bara_current_u1 && index == 4)
        return myText("DC BARA CURRENT HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.driver_error_WakeUp_u1 && index == 5)
        return myText("WAKE UP HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else
        return SizedBox(height: 0,);
    },
  );

}
Widget Vcu(){
  return SafeArea(
    child: SingleChildScrollView(
      child: Consumer<MqttAesk>(
        builder: (context, _, child){
          return Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              myText("    MCU & VCU", 25, Theme.of(context).textTheme.headline3.color, FontWeight.bold),
              Card(
                margin: EdgeInsets.fromLTRB(20, 0, 20, 30),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    SizedBox(height: 10,),
                    Padding(
                      padding: const EdgeInsets.fromLTRB(60, 0, 0, 0),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.start,
                        children: <Widget>[
                          myText("MCU Komutları  ", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                          myText("Durum", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
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
                              myText("ATEŞLEME", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText(AeskData.drive_status_ignition_u1 ? "AKTİF":"İNAKTİF", 20, AeskData.drive_status_ignition_u1 ? Colors.green : Colors.red , FontWeight.bold)
                            ],
                          ),
                          TableRow(
                            children: <Widget>[
                              myText("FRENLEME", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText(AeskData.drive_status_ignition_u1 ? "AKTİF":"İNAKTİF", 20, AeskData.drive_status_ignition_u1 ? Colors.green : Colors.red, FontWeight.bold)
                            ],
                          ),
                          TableRow(
                            children: <Widget>[
                              myText("YÖN", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText(AeskData.drive_status_ignition_u1 ? "İLERİ":"GERİ", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal)
                            ],
                          ),
                        ],
                      ),
                    ),
                    SizedBox(height: 15,),
                    myText("     Hatalar", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Padding(
                      padding: const EdgeInsets.symmetric(vertical: 0,horizontal: 25),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: <Widget>[
                          ErrorHandler(0),
                          ErrorHandler(1),
                          ErrorHandler(2),
                          ErrorHandler(3),
                          ErrorHandler(4),
                          ErrorHandler(5),
                          // altta gördüğünüz widget 2 tane ternary operator ve mytext widgetleri kullanıldığı için uzaya gidiyor
                          (AeskData.driver_driver_error_u8 == null) ? myText("NO DATA", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold) : ((AeskData.driver_driver_error_u8 == 0) ? myText("HATA YOK!", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold) : SizedBox(height: 0,)),
                        ]
                      ),
                    ),
                    SizedBox(height: 15,),
                    myText("     MCU Akım ve Gerilim Seviyeleri", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),

                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Table(
                        columnWidths: {
                          0 : FixedColumnWidth(40),
                          1 : FixedColumnWidth(70),
                          2 : FixedColumnWidth(30),
                          3 : FixedColumnWidth(70),
                          4 : FixedColumnWidth(60),
                        },
                        children: <TableRow>[
                          TableRow(
                              children: <Widget>[
                                myText("  ID:", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText(AeskData.driver_id_f32.toString(), 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("IQ:", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText(AeskData.driver_iq_f32.toString(), 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("IArms:", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("xx", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              ]
                          ),
                        ],
                      ),
                    ),

                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Table(
                        columnWidths: {
                          0 : FixedColumnWidth(90),
                          1 : FixedColumnWidth(50),
                          2 : FixedColumnWidth(90),
                          3 : FixedColumnWidth(50),
                        },
                        children: <TableRow>[
                          TableRow(
                            children: <Widget>[
                              myText("Phase A:", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText(AeskData.driver_phase_a_current_f32.toString(), 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText("Phase B:", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              myText(AeskData.driver_phase_b_current_f32.toString(), 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                            ]
                          ),
                        ],
                      ),
                    ),

                    Container(
                      height: 50,
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                      child: Table(
                        columnWidths: {
                          0 : FixedColumnWidth(60),
                          1 : FixedColumnWidth(70),
                          2 : FixedColumnWidth(60),
                          3 : FixedColumnWidth(40),
                        },
                        children: <TableRow>[
                          TableRow(
                              children: <Widget>[
                                myText("IDC:", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText(AeskData.driver_dc_bus_current_f32.toString(), 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText("VDC:", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                myText(AeskData.driver_dc_bus_voltage_f32.toString(), 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              ]
                          ),
                        ],
                      ),
                    ),
                    SizedBox(height: 15,),
                    myText("     Diğer Veriler", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    Container(
                      child: myText("Motor Sıcaklığı : ${AeskData.driver_motor_temperature_u8} °C", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText("Anlık Hız : ${AeskData.driver_actual_velocity_u8} km/h", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText("Gidilen Mesafe : ${AeskData.driver_odometer_u32}", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      alignment: Alignment.center,
                      height: 50,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
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
