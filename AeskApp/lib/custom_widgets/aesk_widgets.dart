import 'dart:ui';

import 'package:aeskapp/classes/drawer_list_class.dart';
import 'package:flutter/material.dart';

List<DrawerListClass> drawerList = [
  DrawerListClass(image: "home-icon.png", text: "AnaSayfa", destination: "/Home"),
  DrawerListClass(image: "mcu-icon.png", text: "MCU & VCU", destination: "/Vcu"),
  DrawerListClass(image: "bms-icon.png", text: "BMS", destination: "/Bms"),
  DrawerListClass(image: "map-icon.png", text: "Harita", destination: "/Location"),
  DrawerListClass(image: "chart-icon.png", text: "Grafikler", destination: "/Graphs"),
  DrawerListClass(image: "custom-icon.png", text: "Özelleştirme Ekranı", destination: "/Custom"),
];

//********************************** Scaffold Widget ****************************************************//
Widget aeskScaffold({Widget myBody, BuildContext context}) {
  return Scaffold(
    backgroundColor: Theme.of(context).backgroundColor,
    body: myBody,
    drawerEdgeDragWidth: 25,
    endDrawer: Drawer(
      child: Container(
        color: Colors.grey[800],
        child: ListView(
          children: <Widget>[
            ListTile(
                title: Text(
              "Sağ çekmece",
              style: Theme.of(context).textTheme.headline2,
            )),
          ],
        ),
      ),
    ),
    drawer: Drawer(
      child: Container(
        color: Theme.of(context).textTheme.headline4.color,
        height: 50,
        child: ListView(
          scrollDirection: Axis.vertical,
          children: [ListTile(
                title: IconButton(
                  icon: Icon(
                    Icons.settings,
                    textDirection: TextDirection.rtl,
                    color: Theme.of(context).buttonColor,
                  ),
                  onPressed: () => Navigator.popAndPushNamed(context, "/Settings"),
                  alignment: Alignment.centerRight,
                ),
                leading: myText("AeskApp", 25, Theme.of(context).textSelectionColor, FontWeight.bold),
              )]
              + drawerList.map((index) {
                return ListTile(
                  title: myText(index.text, 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                  leading: Image(image: AssetImage("assets/images/${index.image}",)),
                  onTap: () => Navigator.pushReplacementNamed(context, index.destination),
                );
              }).toList(),
        ),
      ),
    ),
  );
}

//*************************************** Text Widget ************************************************//
Widget myText(String input, double mySize, Color myColor,
    FontWeight weight) {
  return Text(
    input,
    style: TextStyle(
        fontFamily: "GOTHIC",
        fontSize: mySize,
        color: myColor,
        fontWeight: weight),
  );
}

//*************************************** Container Widget ***************************************************//
Widget MyContainer({List<Widget> arrayOfWidgets, EdgeInsets myMargin, EdgeInsets myPadding, Color myColor,}) {
  return Container(
    margin: myMargin,
    padding: myPadding,
    color: myColor,
    child: Column(
      children: arrayOfWidgets,
    ),
  );
}
