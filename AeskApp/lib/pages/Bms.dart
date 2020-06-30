import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class Bms extends StatefulWidget {
  @override
  _BmsState createState() => _BmsState();
}

class _BmsState extends State<Bms> {
  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: SingleChildScrollView(
        child: Consumer<MqttAesk>(
          builder: (context, _, child){
            return Column(
              children: <Widget>[

              ],
            );
          }
        )
      ),
    );
  }
}
