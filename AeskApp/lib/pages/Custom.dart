import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:provider/provider.dart';

import 'package:aeskapp/pages/Vcu.dart';

class Custom extends StatefulWidget {
  @override
  _CustomState createState() => _CustomState();
}

class _CustomState extends State<Custom> {
  static List<String> currentContent = List.filled(8, null,growable: true);
  static List<String> nameOfTiles = ["MCU/VCU","BMS"];
  static int contentCount = 1;

  Widget contentAdder(String content, int index) {
    switch (content) {
      case "BMS":
        return Consumer<MqttAesk>(
          builder: (context, _, child){
            return Card(
              child: Column(
                children: <Widget>[
                  myText("Bms verileri burada", 20, Colors.black, FontWeight.bold),
                  IconButton(
                    icon: Icon(Icons.delete),
                    alignment: Alignment.bottomRight,
                    onPressed: () {
                      setState(() {
                        currentContent.removeAt(index);
                        nameOfTiles.add("BMS");
                        contentCount--;
                      });
                    },
                  )
                ],
              ),
            );
          },
        );
        break;
      case "MCU/VCU":
        return Stack(
          children: <Widget>[
            Vcu(),
            Positioned(
              bottom: 25,
              right: 185,
              child: IconButton(
                icon: Icon(Icons.delete),
                alignment: Alignment.bottomRight,
                onPressed: () {
                  setState(() {
                    currentContent.removeAt(index);
                    nameOfTiles.add("MCU/VCU");
                    contentCount--;
                  });
                },
              ),
            )
          ],
        );
        break;
      default:
        return modifiedExpansionTile(index);
        break;
    }
  }

  Widget modifiedExpansionTile(int index) {
    return ExpansionTile(
      title: Center(child: myText("     Ekle", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
      backgroundColor: Theme.of(context).backgroundColor,
      children: nameOfTiles.map((tileName) {
        return FlatButton(
          child: myText(tileName, 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
          onPressed: (){
            setState(() {
              currentContent.insert(index, tileName);
              nameOfTiles.remove(tileName);
              contentCount++;
            });
          },
        );
      }).toList(),
    );
  }

  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: CustomScrollView(

        slivers: <Widget>[
          SliverSafeArea(
            sliver: SliverList(
              delegate: SliverChildBuilderDelegate(
                    (context, int index){
                  return contentAdder(currentContent[index], index);
                },
                childCount: contentCount,
              ),
            ),
          ),
        ],
      ),
    );
  }
}