import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

Widget Ems() {
  return SingleChildScrollView(
    child: SafeArea(
      child: Consumer<MqttAesk>(
        builder: (build,_,child){
          return Column(
            mainAxisAlignment: MainAxisAlignment.start,
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              myText("   ENERJİ YÖNETİM SİSTEMİ", 25, aeskBlue, FontWeight.bold),
              Card(
                margin: EdgeInsets.fromLTRB(20, 0, 20, 30),

              )
            ],
          );
        },
      ),
    ),
  );
}

class EmsPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      myBody: Ems(),
      context: context
    );
  }
}
