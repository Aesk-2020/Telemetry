import 'package:flutter/material.dart';

ThemeData DarkTheme() {
  return ThemeData(

  );
}

ThemeData LightTheme() {
  return ThemeData(
    backgroundColor: Colors.pink,
    buttonColor: Colors.pink,
    textSelectionColor: Colors.amber,
    textTheme: TextTheme(
        body1: TextStyle(
          color: Colors.yellow,
        ),
        title: TextStyle(
          color: Colors.amber,
        ),
    ),


  );
}