import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';


class Custom extends StatefulWidget {
  @override
  _CustomState createState() => _CustomState();
}

class _CustomState extends State<Custom> {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Row(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,

        children: <Widget>[

          Column(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,

            children: <Widget>[
              FlatButton(
                onPressed: (){},
                color: Colors.black,
              ),
              Container(
                color: Colors.redAccent,
                height: 100,
                width: 100,

              ),
              Container(
                color: Colors.blue,
                height: 100,
                width: 100,

              ),
              Container(
                color: Colors.yellow,
                height: 100,
                width: 100,

              ),
            ],
          ),
          Column(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,

            children: <Widget>[
              FlatButton(
                onPressed: (){},
                color: Colors.black,
              ),
              Container(
                color: Colors.redAccent,
                height: 100,
                width: 100,

              ),
              Container(
                color: Colors.blue,
                height: 100,
                width: 100,

              ),
              Container(
                color: Colors.yellow,
                height: 100,
                width: 100,

              ),
            ],
          ),
          Column(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,

            children: <Widget>[
              FlatButton(
                onPressed: (){},
                color: Colors.black,
              ),
              Container(
                color: Colors.redAccent,
                height: 100,
                width: 100,

              ),
              Container(
                color: Colors.blue,
                height: 100,
                width: 100,

              ),
              Container(
                color: Colors.yellow,
                height: 100,
                width: 100,

              ),
            ],
          ),
        ],
      ),

    );
  }
}
