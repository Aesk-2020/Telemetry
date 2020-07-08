import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:provider/provider.dart';


class Cells extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: aeskScaffold(
        myBody: Center(
          child: CellsRow("Cell-1", "Cell-5", "Cell-9", "Cell-13","Cell-17","Cell-21","Cell-25",context),
        ),
        context: context
      ),
    );
  }
}
