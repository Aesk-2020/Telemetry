import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:provider/provider.dart';

import 'package:aeskapp/pages/Vcu.dart';
import 'package:aeskapp/pages/Bms.dart';

import 'Ems.dart';

class Custom extends StatefulWidget {
  @override
  _CustomState createState() => _CustomState();
}

class _CustomState extends State<Custom> {
  static List<String> currentContent = List.filled(8, null,growable: true);
  static List<String> nameOfTiles = ["MCU/VCU","BMS",!MqttAesk.isLyra ? "EMS" : ""];
  static int contentCount = 1;

  Widget contentAdder(String content, int index) {
    final scale = MediaQuery.of(context);
    switch (content) {
      case "BMS":
        return Stack(
          children: <Widget>[
            Bms(),
            Positioned(
              bottom: 25,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentContent.removeAt(index);
                    nameOfTiles.add("BMS");
                    contentCount--;
                  });
                },
              ),
            )
          ],
        );
        break;
      case "MCU/VCU":
        return Stack(
          children: <Widget>[
            Vcu(),
            Positioned(
              bottom: 25,
              right: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
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
      case "EMS":
        if(!MqttAesk.isLyra)
          return Stack(
            children: <Widget>[
              Ems(),
              Positioned(
                bottom: 25,
                right: scale.size.width/2.22,
                child: IconButton(
                  icon: Icon(Icons.delete),
                  onPressed: () {
                    setState(() {
                      currentContent.removeAt(index);
                      nameOfTiles.add("EMS");
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
        if(tileName == "") return SizedBox(height: 0,);
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