import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

Widget ErrorHandler(int index){

  return Consumer<MqttAesk>(
    builder: (context, _, child){

      if(AeskData.bms_error_high_voltage_u1 && index == 0)
        return myText("YÜKSEK GERİLİM HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.bms_error_low_voltage_u1 && index == 1)
        return myText("DÜŞÜK GERİLİM HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.bms_error_high_temp_u1 && index == 2)
        return myText("YÜKSEK SICAKLIK HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.bms_error_communication_u1 && index == 3)
        return myText("HABERLEŞME HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.bms_error_over_current_u1 && index == 4)
        return myText("AŞIRI AKIM HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.bms_error_fatal_u1 && index == 5)
        return myText("ÖLÜMCÜL HATA", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else if(AeskData.bms_error_isolation_u1 && index == 6)
        return myText("İZOLASYON HATASI", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
      else
        return SizedBox(height: 0,);
    },
  );

}

class Bms extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: SafeArea(
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
                                      myText(AeskData.bms_bat_volt_f32.toString() + " V", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("Gerilim", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      SizedBox(height: 5,),
                                      myText(AeskData.bms_temp_u8.toString() + " °C", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("Sıcaklık", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      SizedBox(height: 5,),
                                      myText(AeskData.bms_bat_current_f32.toString() + " A", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("Akım", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      SizedBox(height: 5,),
                                      myText(AeskData.bms_soc_f32.toString() + " V", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("SoC Gerilimi", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      SizedBox(height: 5,),
                                      myText(AeskData.bms_bat_cons_f32.toString() + " Wh", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("Tüketim", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                    ],
                                  )
                                ],
                              ),
                              myText("    Hatalar", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
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
                                      ErrorHandler(6),
                                      // altta gördüğünüz widget 2 tane ternary operator ve mytext widgetleri kullanıldığı için uzaya gidiyor
                                      (AeskData.bms_bms_error_u8 == null) ? myText("NO DATA", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold) : ((AeskData.bms_bms_error_u8 == 0) ? myText("HATA YOK!", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold) : SizedBox(height: 0,)),
                                    ]
                                ),
                              ),
                              SizedBox(height: 15,),
                              myText("    DC BUS DURUMU", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                              myText("    PRECHARGCE", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              SizedBox(height: 50,),
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
}