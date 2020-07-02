import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/classes/theme.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:aeskapp/classes/Mqtt.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Consumer<MyThemeData>(
      builder: (context, ourTheme, child) {
        return aeskScaffold(
          context: context,
          myBody: Center(
            child: Column(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: <Widget>[
                Text((ourTheme.myTheme == DarkTheme()) ? "bu bir karanlık moddur" : "bu aydınlık moddur"),
                Consumer<MqttAesk>(
                  builder: (context, _, child){
                    return myText("${AeskData.gpsTracker_gps_latitude_f64}", 40, Colors.pink, FontWeight.bold);
                  },
                ),
              ],
            ),
          ),
        );
      },
    );
  }
}
