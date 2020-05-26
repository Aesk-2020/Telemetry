import 'package:flutter/material.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';

class Logging extends StatefulWidget {
  @override
  _LoggingState createState() => _LoggingState();
}

class _LoggingState extends State<Logging> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Column(
          children: <Widget>[
            myText("AESKAPP", 35, Theme.of(context).appBarTheme.color, "GOTHIC", FontWeight.bold),
            Row(
              children: <Widget>[
                myText("Kullanıcı Adı:", 25, Theme.of(context).textTheme.title.color,"GOTHIC", FontWeight.normal),
                TextField(


                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
