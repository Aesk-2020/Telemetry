import 'package:aeskapp/pages/Custom.dart';
import 'package:aeskapp/pages/General.dart';
import 'package:aeskapp/pages/Loading.dart';
import 'package:aeskapp/pages/Graphs.dart';
import 'package:aeskapp/pages/Home.dart';
import 'package:aeskapp/pages/Login.dart';

import 'package:flutter/material.dart';

void main() =>
    runApp(MaterialApp(
      // Burası maceramızın başlangıcı :D
      initialRoute: "/Login",
      routes: {
        "/Login": (context) => Logging(),
        "/Home": (context) => Home(),
        "/General": (context) => General(),
        "/Custom": (context) => Custom(),
        "/Graphs": (context) => Graphs(),
        "/Loading": (context) => Loading(),
      },
    ));

