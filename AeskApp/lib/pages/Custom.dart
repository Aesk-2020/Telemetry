import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
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
  static int contentCount = 1;

  Widget contentAdder(String content, int index) {
    switch (content) {
      case "bms":
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
      case "vcuDriver":
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
                    contentCount--;
                  });
                },
              ),
            )
          ],
        );
        break;
      case "gps":
        return Consumer<MqttAesk>(
          builder: (context, _, child){
            return Card(
              child: Column(
                children: <Widget>[
                  myText("GPS verileri burada", 20, Colors.black, FontWeight.bold),
                  IconButton(
                    icon: Icon(Icons.delete),
                    alignment: Alignment.bottomRight,
                    onPressed: () {
                      setState(() {
                        currentContent.removeAt(index);
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
      default:
        return modifiedExpansionTile(index);
        break;
    }
  }

  Widget modifiedExpansionTile(int index) {
    return ExpansionTile(
      title: Center(child: myText("     Ekle", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
      children: <Widget>[
        FlatButton(
          onPressed: () {
            setState(() {
              currentContent.insert(index, "vcuDriver");
              contentCount++;
            });
          },
          child: myText("Driver", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
        ),
        FlatButton(
          onPressed: () {
            setState(() {
              currentContent.insert(index, "bms");
              contentCount++;
            });
          },
          child: myText("BMS", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
        ),
        FlatButton(
          onPressed: () {
            setState(() {
              currentContent.insert(index, "gps");
              contentCount++;
            });
          },
          child: myText("GPS", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
        ),
      ],
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
