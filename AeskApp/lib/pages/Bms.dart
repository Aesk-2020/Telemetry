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
      myBody: SafeArea(
        child: Padding(
          padding: const EdgeInsets.fromLTRB(25, 10, 25, 10),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.start,
            children: <Widget>[
              Row(
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  Text(
                    "Battery",
                    style: Theme.of(context).textTheme.headline3,
                  ),
                ],
              ),
              Divider(
                height: 8,
                thickness: 2,
                color: Colors.grey[600],
              ),
              SizedBox(
                height: 5,
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  Image(image: AssetImage("assets/images/battery.png"),),
                  Column(
                    children: <Widget>[
                      Text("sadsad"),
                      Text("sadsad"),
                      Text("sadsad"),
                      Text("sadsad"),
                    ],
                  )
                ],
              )
            ],
          ),
        ),
      ),
    );
  }
}
