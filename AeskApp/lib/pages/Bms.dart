import 'package:aeskapp/custom_widgets/aesk_scaffold.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:aeskapp/custom_widgets/text_widget.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class Bms extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            myText("BATTERY VOLTAGE",     20, Aesk_blue, "CenturyGothic"),
            myText("BATTERY CURRENT",     20, Aesk_blue, "CenturyGothic"),
            myText("BATTERY CONSUMPTION", 20, Aesk_blue, "CenturyGothic"),
            myText("SOC",                 20, Aesk_blue, "CenturyGothic"),
            myText("TEMPRATURE",          20, Aesk_blue, "CenturyGothic"),
            myText("WORST CELL VOLTAGE",  20, Aesk_blue, "CenturyGothic"),
            myText("WORST CELL ADDRESS",  20, Aesk_blue, "CenturyGothic"),
            myText("ERRORS",              20, Aesk_blue, "CenturyGothic"),
          ],
        ),
      )
    );
  }
}
