import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';

class Bms extends StatefulWidget {
  @override
  _BmsState createState() => _BmsState();
}

class _BmsState extends State<Bms> {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Center(child: Text("BMS")),
    );
  }
}
