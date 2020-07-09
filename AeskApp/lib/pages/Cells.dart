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
                          CellWidget("Cell-1 ", AeskData.battery_cells[0].toString(), context),
                          CellWidget("Cell-2 ", AeskData.battery_cells[1].toString(), context),
                          CellWidget("Cell-3 ", AeskData.battery_cells[2].toString(), context),
                          CellWidget("Cell-4 ", AeskData.battery_cells[3].toString(), context),
                        ],
                      ),
                      SizedBox(height: 20,),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellWidget("Cell-5 ", AeskData.battery_cells[4].toString(), context),
                          CellWidget("Cell-6 ", AeskData.battery_cells[5].toString(), context),
                          CellWidget("Cell-7 ", AeskData.battery_cells[6].toString(), context),
                          CellWidget("Cell-8 ", AeskData.battery_cells[7].toString(), context),
                        ],
                      ),
                      SizedBox(height: 20,),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellWidget("Cell-9 ", AeskData.battery_cells[8].toString(), context),
                          CellWidget("Cell-10", AeskData.battery_cells[9].toString(), context),
                          CellWidget("Cell-11", AeskData.battery_cells[10].toString(), context),
                          CellWidget("Cell-12", AeskData.battery_cells[11].toString(), context),
                        ],
                      ),
                      SizedBox(height: 20,),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellWidget("Cell-13", AeskData.battery_cells[12].toString(), context),
                          CellWidget("Cell-14", AeskData.battery_cells[13].toString(), context),
                          CellWidget("Cell-15", AeskData.battery_cells[14].toString(), context),
                          CellWidget("Cell-16", AeskData.battery_cells[15].toString(), context),
                        ],
                      ),
                      SizedBox(height: 20,),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellWidget("Cell-17", AeskData.battery_cells[16].toString(), context),
                          CellWidget("Cell-18", AeskData.battery_cells[17].toString(), context),
                          CellWidget("Cell-19", AeskData.battery_cells[18].toString(), context),
                          CellWidget("Cell-20", AeskData.battery_cells[19].toString(), context),
                        ],
                      ),
                      SizedBox(height: 20,),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellWidget("Cell-21", AeskData.battery_cells[20].toString(), context),
                          CellWidget("Cell-22", AeskData.battery_cells[21].toString(), context),
                          CellWidget("Cell-23", AeskData.battery_cells[22].toString(), context),
                          CellWidget("Cell-24", AeskData.battery_cells[23].toString(), context),
                        ],
                      ),
                      SizedBox(height: 20,),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        children: <Widget>[
                          CellWidget("Cell-25", AeskData.battery_cells[24].toString(), context),
                          CellWidget("Cell-26", AeskData.battery_cells[25].toString(), context),
                          CellWidget("Cell-27", AeskData.battery_cells[26].toString(), context),
                          CellWidget("Cell-28", AeskData.battery_cells[27].toString(), context),
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
