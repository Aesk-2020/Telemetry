import 'package:flutter/material.dart';

Color aeskBlue = Color.fromRGBO(47, 136, 202, 1.0);
Color aeskBlack = Color.fromRGBO(48, 51, 58, 1.0);

ThemeData DarkTheme() {
  return ThemeData(
    backgroundColor: aeskBlack,
    buttonColor: aeskBlue,
    textTheme: TextTheme(
      bodyText1: TextStyle(
        color: Colors.white,
      )
    )
  );
}

ThemeData LightTheme() {
  return ThemeData(
    backgroundColor: Colors.pink,
    buttonColor: aeskBlue,
    textSelectionColor: Colors.blue,
    textTheme: TextTheme(
        body1: TextStyle(
          color: Colors.yellow,
        ),
        title: TextStyle(
          color: Colors.amber,
        ),
        body2: TextStyle(
          color: Colors.white,
        )
    ),
  );
}