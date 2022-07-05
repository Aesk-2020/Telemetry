import 'dart:ui';

import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/drawer_list_class.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:overlay_support/overlay_support.dart';

List<DrawerListClass> drawerListLyra = [
  DrawerListClass(image: "home-icon.png", text: "AnaSayfa", destination: "/Home"),
  DrawerListClass(image: "mcu-icon.png", text: "ECU", destination: "/Vcu"),
  DrawerListClass(image: "bms-icon.png", text: "BMS", destination: "/Bms"),
  DrawerListClass(image: "cells-icon.png", text: "Batarya Hücreleri", destination: "/Cells"),
  DrawerListClass(image: "map-icon.png", text: "Harita", destination: "/Location"),
  DrawerListClass(image: "chart-icon.png", text: "Grafikler", destination: "/Graphs"),
  DrawerListClass(image: "custom-icon.png", text: "Özelleştirme Ekranı", destination: "/Custom"),
  DrawerListClass(image: "chronometer.png", text: "Test Ekranı", destination: "/Test"),
];
List<DrawerListClass> drawerListHydra = [
  DrawerListClass(image: "home-icon.png", text: "AnaSayfa", destination: "/HomeHydro"),
  DrawerListClass(image: "mcu-icon.png", text: "ECU", destination: "/Vcu"),
  DrawerListClass(image: "bms-icon.png", text: "BMS", destination: "/Bms"),
  DrawerListClass(image: "ems-icon.png", text: "EMS", destination: "/Ems"),
  DrawerListClass(image: "cells-icon.png", text: "Batarya Hücreleri", destination: "/CellsHydro"),
  DrawerListClass(image: "map-icon.png", text: "Harita", destination: "/Location"),
  DrawerListClass(image: "chart-icon.png", text: "Grafikler", destination: "/GraphsHydro"),
  DrawerListClass(image: "custom-icon.png", text: "Özelleştirme Ekranı", destination: "/Custom"),
  DrawerListClass(image: "chronometer.png", text: "Test Ekranı", destination: "/Test"),
];

Color crimsonRed = Color.fromRGBO(220, 20, 60, 1.0);

//********************************** Scaffold Widget ****************************************************//
Widget aeskScaffold({Widget myBody, BuildContext context}) {
  List<DrawerListClass> drawerList = MqttAesk.isLyra ? drawerListLyra : drawerListHydra;
  return Scaffold(
    backgroundColor: Theme.of(context).backgroundColor,
    body: myBody,
    drawerEdgeDragWidth: 70,
    drawer: Drawer(
      child: Container(
        color: Theme.of(context).textTheme.headline4.color,
        height: 50,
        child: ListView(
          scrollDirection: Axis.vertical,
          children: [
                ListTile(
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
                )
              ] +
              drawerList.map((element) {
                return ListTile(
                  title: myText(element.text, 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                  leading: Image(
                      image: AssetImage(
                    "assets/images/${element.image}",
                  )),
                  onTap: () => (ModalRoute.of(context).settings.name == "/Home" ||
                          ModalRoute.of(context).settings.name == "/HomeHydro")
                      ? Navigator.popAndPushNamed(context, element.destination)
                      : Navigator.pushReplacementNamed(context, element.destination),
                  enabled: (ModalRoute.of(context).settings.name == element.destination) ? false : true,
                  trailing: (ModalRoute.of(context).settings.name == element.destination)
                      ? Icon(
                          Icons.arrow_back_ios,
                          color: aeskBlue,
                        )
                      : SizedBox(
                          height: 0,
                        ),
                );
              }).toList(),
        ),
      ),
    ),
  );
}

//*************************************** Text Widget ************************************************//
Widget myText(String input, double mySize, Color myColor, FontWeight weight) {
  return Text(
    input,
    style: TextStyle(
      fontFamily: "GOTHIC",
      fontSize: mySize,
      color: myColor,
      fontWeight: weight,
    ),
  );
}

//*************************************** Container Widget ***************************************************//
Widget MyContainer({
  List<Widget> arrayOfWidgets,
  EdgeInsets myMargin,
  EdgeInsets myPadding,
  Color myColor,
}) {
  return Container(
    margin: myMargin,
    padding: myPadding,
    color: myColor,
    child: Column(
      children: arrayOfWidgets,
    ),
  );
}

//**************************************** Row Widget for Errors & States *************************************//
Widget AeskErrorCheck(String text, bool condition, BuildContext context) {
  return Padding(
    padding: EdgeInsets.fromLTRB(25, 0, 25, 0),
    child: Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        myText(text, 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
        Icon(
          Icons.lens,
          size: 20,
          color: (condition ? crimsonRed : Colors.transparent),
        )
      ],
    ),
  );
}

Widget AeskConditionCheck(String text, bool condition, BuildContext context) {
  return Padding(
    padding: EdgeInsets.fromLTRB(25, 0, 25, 0),
    child: Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        myText(text, 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
        Icon(
          Icons.lens,
          size: 20,
          color: (condition ? Colors.green : Colors.transparent),
        )
      ],
    ),
  );
}

Widget AeskDirectionCheck(String text, bool condition, BuildContext context) {
  return Padding(
    padding: EdgeInsets.fromLTRB(25, 0, 25, 0),
    child: Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        myText(text, 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
        Icon(
          condition ? Icons.arrow_back : Icons.arrow_forward,
          size: 20,
          color: aeskBlue,
        )
      ],
    ),
  );
}

Widget CellWidget(String text, String data, BuildContext context, Color color) {
  return Container(
    child: Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: <Widget>[
        Container(
          child: myText(text, 20, color, FontWeight.bold),
          decoration:
              BoxDecoration(border: Border(bottom: BorderSide(color: color, style: BorderStyle.solid, width: 2))),
        ),
        myText(data + " mV", 20, color, FontWeight.bold)
      ],
    ),
  );
}

showOverlayNotification(BuildContext context) {
  return Card(
    margin: const EdgeInsets.symmetric(horizontal: 4),
    child: SafeArea(
      child: ListTile(
        leading: SizedBox.fromSize(
            size: const Size(40, 40),
            child: ClipOval(
                child: Container(
              color: Colors.black,
            ))),
        title: Text('FilledStacks'),
        subtitle: Text('Thanks for checking out my tutorial'),
        trailing: IconButton(
            icon: Icon(Icons.close),
            onPressed: () {
              OverlaySupportEntry.of(context).dismiss();
            }),
      ),
    ),
  );
}
