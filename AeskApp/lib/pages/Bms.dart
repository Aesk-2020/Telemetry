import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

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
                    Consumer<MqttAesk>(
                      builder: (context,_,child){
                        return Card(
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
                                      myText("12.0 V", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("Gerilim", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      SizedBox(height: 5,),
                                      myText("42 C", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("Sıcaklık", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      SizedBox(height: 5,),
                                      myText("2.0 A", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("Akım", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      SizedBox(height: 5,),
                                      myText("xx V", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("SoC Gerilimi", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      SizedBox(height: 5,),
                                      myText("xx Wh", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                      myText("Tüketim", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                                    ],
                                  )
                                ],
                              ),
                              myText("    Hatalar", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                              myText("    Yok", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              SizedBox(height: 15,),
                              myText("    DC BUS DURUMU", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                              myText("    PRECHARGCE", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                              SizedBox(height: 50,)
                            ],
                          ),
                        );
                      },
                    )

                  ],
                );
              }
          )
      ),
    );
  }
}
