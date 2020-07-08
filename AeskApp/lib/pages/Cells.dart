import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:provider/provider.dart';


class Cells extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: aeskScaffold(
        myBody: Center(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: <Widget>[
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: <Widget>[
                  myText("HATA", 20, aeskBlue, FontWeight.bold),
                  Icon(Icons.lens,color: Colors.red[800],size: 20,)
                ],
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: <Widget>[
                  myText("HATA", 20, aeskBlue, FontWeight.bold),
                  Icon(Icons.lens,color: Colors.green[800],size: 20,)
                ],
              )
            ],
          ),
        ),
        context: context
      ),
    );
  }
}
