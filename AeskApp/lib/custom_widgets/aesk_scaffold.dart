import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:aeskapp/custom_widgets/text_widget.dart';
import 'package:flutter/material.dart';

Widget aeskScaffold({Widget myBody, BuildContext context}) {
  return Scaffold(
    backgroundColor: Aesk_background,
    drawer: Drawer(
      child: Container(
        color: Colors.grey,
        child: ListView(
          itemExtent: 70,
          children: <Widget>[
            Container(
              color: Colors.grey,
              child: ListTile(
                title: myText("AeskApp", 20, Colors.white, "IndieFlower"),
                leading: Icon(
                  Icons.dehaze,
                ),
              ),
            ),
            Container(
              color: Colors.grey,
              child: ListTile(
                title: myText("Genel Durum", 20, Colors.white, "IndieFlower"),
                leading: CircleAvatar(
                  backgroundImage: AssetImage("assets/images/aesk-logo.png"),
                ),
                onTap: () {
                  Navigator.pushReplacementNamed(context, "/General");
                },
              ),
            ),
            Container(
              color: Colors.grey,
              child: ListTile(
                title: myText("BMS", 20, Colors.white, "IndieFlower"),
                leading: CircleAvatar(
                  backgroundImage: AssetImage("assets/images/aesk-logo.png"),
                ),
                onTap: () {
                  Navigator.pushReplacementNamed(context, "/BMS");
                },
              ),
            ),
          ],
        ),
      ),
    ),
    body: myBody,
  );
}
