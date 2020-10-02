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
  static List<String> currentContent = List.filled(1, null,growable: true);
  static List<String> nameOfTilesLyra = ["MCU/VCU","BMS"];
  static List<String> nameOfTilesHydra = ["MCU/VCU","BMS","EMS"];
  static List<String> nameOfTiles = MqttAesk.isLyra ? nameOfTilesLyra : nameOfTilesHydra;

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
                    });
                  },
                ),
              )
            ],
          );
        break;
      case "list":
        return (nameOfTiles.length == 0 ? SizedBox(height: 0,) : modifiedExpansionTile(currentContent.length));
        break;
      default:
        return SizedBox(height: 0,);
        break;
    }
  }

  Widget modifiedExpansionTile(int index) {
    return ExpansionTile(
      title: myText("Ekle", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
      leading: Icon(Icons.graphic_eq),
      backgroundColor: Theme.of(context).backgroundColor,
      children: nameOfTiles.map((tileName) {
        return GestureDetector(
          child: Container(
            alignment: Alignment.centerLeft,
            padding: EdgeInsets.fromLTRB(15, 5, 5, 5),
            child: Row(
              children: <Widget>[
                Icon(Icons.add),
                SizedBox(width: 15,),
                myText(tileName, 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
              ],
            ),
          ),
          onTap: (){
            setState(() {
              currentContent.insert(index, tileName);
              nameOfTiles.remove(tileName);
            });
          },
        );
      }).toList(),
    );
  }
@override
  void initState() {
    currentContent[0] = "list";
    super.initState();
  }
  @override
  Widget build(BuildContext context) {
    print(nameOfTiles);
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
                childCount: currentContent.length,
              ),
            ),
          ),
        ],
      ),
    );
  }
}