<<<<<<< HEAD
import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class Bms extends StatelessWidget {
=======
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';

class Bms extends StatefulWidget {
  @override
  _BmsState createState() => _BmsState();
}

class _BmsState extends State<Bms> {
>>>>>>> emreurcu
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
<<<<<<< HEAD
      myBody: SafeArea(
          child: Consumer<MqttAesk>(
              builder: (context, _, child){
                return Column(
                  children: <Widget>[
                    myText("BATARYA YÖNETİM SİSTEMİ", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal),
                    Consumer<MqttAesk>(
                      builder: (context,_,child){
                        return myText("${AeskData.bms_bat_volt_f32}", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold);
                      },
                    )

                  ],
                );
              }
          )
      ),
=======
      myBody: Center(child: Text("BMS")),
>>>>>>> emreurcu
    );
  }
}
