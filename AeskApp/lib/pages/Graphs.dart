import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/chart.dart';
import 'package:flutter/material.dart';
import 'file:///F:/Yusuf/Ders%20Bolum/AESK/github/Telemetry/AeskApp/lib/custom_widgets/gauge.dart';

class Graphs extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: SafeArea(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.start,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: <Widget>[
            Expanded(
              flex: 5,
              child: AeskGauge(),
            ),
            Expanded(
              flex: 5,
              child: AeskChart(),
            )
          ],
        ),
      ),
    );
  }
}
