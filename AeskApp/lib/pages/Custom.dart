import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';

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
        return Container(
          decoration: BoxDecoration(
            border: Border.all(color: Colors.grey, width: 10),
            color: Colors.white,
          ),
          padding: EdgeInsets.all(10),
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
        break;
      case "driver":
        return Container(
          decoration: BoxDecoration(
            border: Border.all(color: Colors.grey, width: 10),
            color: Colors.white,
          ),
          padding: EdgeInsets.all(10),
          child: Column(
            children: <Widget>[
              myText("Driver verileri burada", 20, Colors.black, FontWeight.bold),
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
        break;
      case "gps":
        return Container(
          decoration: BoxDecoration(
            border: Border.all(color: Colors.grey, width: 10),
            color: Colors.white,
          ),
          padding: EdgeInsets.all(10),
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
        break;
      default:
        return modifiedExpansionTile(index);
        break;
    }
  }

  Widget modifiedExpansionTile(int index) {
    return ExpansionTile(
      title: myText("Ekle", 25, Theme.of(context).textTheme.body1.color, FontWeight.bold),
      children: <Widget>[
        FlatButton(
          onPressed: () {
            setState(() {
              currentContent.insert(index, "driver");
              contentCount++;
            });
          },
          child: myText("Driver Verileri", 25, Theme.of(context).textTheme.body1.color, FontWeight.bold),
        ),
        FlatButton(
          onPressed: () {
            setState(() {
              currentContent.insert(index, "bms");
              contentCount++;
            });
          },
          child: myText("BMS Verileri", 25, Theme.of(context).textTheme.body1.color, FontWeight.bold),
        ),
        FlatButton(
          onPressed: () {
            setState(() {
              currentContent.insert(index, "gps");
              contentCount++;
            });
          },
          child: myText("GPS Verileri", 25, Theme.of(context).textTheme.body1.color, FontWeight.bold),
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
