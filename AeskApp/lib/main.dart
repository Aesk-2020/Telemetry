import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:aeskapp/pages/Custom.dart';
import 'package:aeskapp/pages/General.dart';
import 'package:aeskapp/pages/Loading.dart';
import 'package:aeskapp/pages/Graphs.dart';
import 'package:aeskapp/pages/Home.dart';
import 'package:aeskapp/pages/Login.dart';
import 'package:aeskapp/pages/Log.dart';
import 'package:aeskapp/pages/Bms.dart';
import 'package:aeskapp/pages/Settings.dart';

import 'package:flutter/material.dart';

void main() => runApp(MaterialApp(
      // Burası maceramızın başlangıcı :D
      theme: LightTheme(),
      initialRoute: "/Home",
      routes: {
        "/Login": (context) => Logging(),
        "/Home": (context) => Home(),
        "/General": (context) => General(),
        "/Custom": (context) => Custom(),
        "/Graphs": (context) => Graphs(),
        "/Loading": (context) => Loading(),
        "/Log": (context) => Log(),
        "/Bms": (context) => Bms(),
        "/Settings": (context) => Settings(),
      },
    ));
