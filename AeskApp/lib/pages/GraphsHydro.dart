import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/chartHydro.dart';
import 'package:flutter/material.dart';

class GraphsHydro extends StatelessWidget {
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
              child: AeskChartHydro(),
            )
          ],
        ),
      ),
    );
  }
}
