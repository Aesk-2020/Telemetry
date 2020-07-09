import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:provider/provider.dart';

Widget Cells(){
  return SafeArea(
    child: Consumer<MqttAesk>(
      builder: (context,_,child) {
        return Center(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: <Widget>[
                myText("    BATARYA HÜCRELERİ", 25, aeskBlue, FontWeight.bold),
                Card(
                  margin: EdgeInsets.fromLTRB(20, 0, 20, 30),
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                    children: <Widget>[
                      SizedBox(height: 20,),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellsRow("Cell-1 ", AeskData.battery_cells[0].toString(), context),
                          CellsRow("Cell-2 ", AeskData.battery_cells[1].toString(), context),
                          CellsRow("Cell-3 ", AeskData.battery_cells[2].toString(), context),
                          CellsRow("Cell-4 ", AeskData.battery_cells[3].toString(), context),
                        ],
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellsRow("Cell-5 ", AeskData.battery_cells[4].toString(), context),
                          CellsRow("Cell-6 ", AeskData.battery_cells[5].toString(), context),
                          CellsRow("Cell-7 ", AeskData.battery_cells[6].toString(), context),
                          CellsRow("Cell-8 ", AeskData.battery_cells[7].toString(), context),
                        ],
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellsRow("Cell-9 ", AeskData.battery_cells[8].toString(), context),
                          CellsRow("Cell-10", AeskData.battery_cells[9].toString(), context),
                          CellsRow("Cell-11", AeskData.battery_cells[10].toString(), context),
                          CellsRow("Cell-12", AeskData.battery_cells[11].toString(), context),
                        ],
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellsRow("Cell-13", AeskData.battery_cells[12].toString(), context),
                          CellsRow("Cell-14", AeskData.battery_cells[13].toString(), context),
                          CellsRow("Cell-15", AeskData.battery_cells[14].toString(), context),
                          CellsRow("Cell-16", AeskData.battery_cells[15].toString(), context),
                        ],
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellsRow("Cell-17", AeskData.battery_cells[16].toString(), context),
                          CellsRow("Cell-18", AeskData.battery_cells[17].toString(), context),
                          CellsRow("Cell-19", AeskData.battery_cells[18].toString(), context),
                          CellsRow("Cell-20", AeskData.battery_cells[19].toString(), context),
                        ],
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellsRow("Cell-21", AeskData.battery_cells[20].toString(), context),
                          CellsRow("Cell-22", AeskData.battery_cells[21].toString(), context),
                          CellsRow("Cell-23", AeskData.battery_cells[22].toString(), context),
                          CellsRow("Cell-24", AeskData.battery_cells[23].toString(), context),
                        ],
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellsRow("Cell-25", AeskData.battery_cells[24].toString(), context),
                          CellsRow("Cell-26", AeskData.battery_cells[25].toString(), context),
                          CellsRow("Cell-27", AeskData.battery_cells[26].toString(), context),
                          CellsRow("Cell-28", AeskData.battery_cells[27].toString(), context),
                        ],
                      ),
                      SizedBox(height: 20,)
                    ],
                  ),
                ),
              ],
            ),
          );
      }
    ),
  );
}

class CellsPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
        context: context,
        myBody: Cells()
    );
  }
}
