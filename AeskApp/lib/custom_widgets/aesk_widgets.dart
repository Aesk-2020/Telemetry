import 'dart:ui';

import 'package:aeskapp/classes/drawer_list_class.dart';
import 'package:flutter/material.dart';

List<DrawerListClass> drawerList = [
  DrawerListClass(image: "manzara.jpg", text: "AnaSayfa", destination: "/Home"),
  DrawerListClass(image: "manzara.jpg", text: "Kayıt Defteri", destination: "/Log"),
  DrawerListClass(image: "manzara.jpg", text: "Grafikler", destination: "/Graphs"),
  DrawerListClass(image: "manzara.jpg", text: "BMS Verileri", destination: "/Bms"),
];

//************************* Header Widget *****************************************
//Widget _header =

// **********************************Scaffold Widget****************************************************
Widget aeskScaffold({Widget myBody, BuildContext context}) {
  return Scaffold(
    backgroundColor: Theme.of(context).backgroundColor,
    body: myBody,
    endDrawer: Drawer(
      child: Container(
        color: Colors.grey[800],
        child: ListView(
          children: <Widget>[
            ListTile(
                title: Text(
              "asdasd",
              style: Theme.of(context).textTheme.body2,
            )),
          ],
        ),
      ),
    ),
    drawer: Drawer(
      child: Container(
        color: Colors.grey[800],
        child: SizedBox(
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
                      onPressed: () {
                        Navigator.popAndPushNamed(context, "/Settings");
                      },
                      alignment: Alignment.centerRight,
                    ),
                    leading: myText("AnaSayfa", 25, Theme.of(context).textSelectionColor, "GOTHIC", FontWeight.bold),
                  )
                ]
                + drawerList.map((index) {
                  return ListTile(
                    title: myText(index.text, 20, Colors.white, "gilroy-light",
                        FontWeight.bold),
                    leading: CircleAvatar(
                      backgroundImage:
                          AssetImage("assets/images/${index.image}"),
                    ),
                    onTap: () {
                      Navigator.pushReplacementNamed(
                          context, index.destination);
                    },
                  );
                }).toList(),
          ),
        ),
      ),
    ),
  );
}

//***************************************Text Widget************************************************
Widget myText(String input, double mySize, Color myColor, String myFont,
    FontWeight weight) {
  return Text(
    input,
    style: TextStyle(
        fontFamily: myFont,
        fontSize: mySize,
        color: myColor,
        fontWeight: weight),
  );
}

//***************************************Container Widget***************************************************
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