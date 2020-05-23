//Hız, süre, atılan tur, taranan açı

import 'package:aeskapp/custom_widgets/aesk_scaffold.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:aeskapp/custom_widgets/text_widget.dart';
import 'package:flutter/material.dart';

class General extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Center(
        child: myText("jkashdjkashdjk", 100, Colors.redAccent, "IndieFlower"),
      ),
    );
  }
}
