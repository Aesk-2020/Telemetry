import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class Bms extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: aeskScaffold(
        context: context,
        myBody: Center(
          child: myText("Batarya Yönetim Sistemi", 40, Theme.of(context).textTheme.headline3.color, FontWeight.bold),
        )
      ),
    );
  }
}

