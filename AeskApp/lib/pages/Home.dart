import 'package:aeskapp/custom_widgets/aesk_scaffold.dart';
import 'package:aeskapp/custom_widgets/text_widget.dart';
import 'package:flutter/material.dart';

class Home extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      myBody: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          children: <Widget>[
            FlatButton(
              onPressed: (){},
              child: myText("DENEME BUTONU", 25, Colors.white, "CenturyGothic")
            ),
          ],
        ),
      ),
      context: context,
    );
  }
}
