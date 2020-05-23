import 'package:aeskapp/custom_widgets/aesk_scaffold.dart';
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
              child: Text("deneme butonu"),
            ),
          ],
        ),
      ),
      context: context,
    );
  }
}
