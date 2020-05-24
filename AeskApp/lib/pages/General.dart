//Hız, süre, atılan tur, taranan açı
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';

class General extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Center(
        child: myText("jkashdjkashdjk", 100, Colors.redAccent, "IndieFlower",FontWeight.bold),
      ),
    );
  }
}
