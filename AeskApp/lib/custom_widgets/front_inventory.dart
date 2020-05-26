import 'package:flutter/material.dart';

Color aeskBlue = Color.fromRGBO(47, 136, 202, 1.0);
Color aeskBlack = Color.fromRGBO(48, 51, 58, 1.0);

ThemeData LightTheme() {
  return ThemeData(
    // Aydınlık mod
    backgroundColor: Colors.white70,
    buttonColor: aeskBlue,
    appBarTheme: AppBarTheme(
      color: Colors.blueAccent,
      textTheme: TextTheme(
        title: TextStyle(
          color: Colors.amber,
          fontFamily: "GOTHIC",
          fontSize: 25,
          fontWeight: FontWeight.bold,
        ),
      ),
    ),
    textSelectionColor: Colors.blue,
    textTheme: TextTheme(
      body1: TextStyle(
        color: Colors.black,
      ),
      title: TextStyle(
        color: Colors.amber,
      ),
      body2: TextStyle(
        color: Colors.white,
      ),
    ),
  );
}

ThemeData DarkTheme() {
  return ThemeData(
    backgroundColor: aeskBlack,
    buttonColor: aeskBlue,
    appBarTheme: AppBarTheme(
      color: Colors.grey,
      textTheme: TextTheme(
        title: TextStyle(
          color: Colors.white,
          fontFamily: "GOTHIC",
          fontSize: 25,
          fontWeight: FontWeight.bold,
        ),
      ),
    ),
    textSelectionColor: Colors.blue,
    textTheme: TextTheme(
      body1: TextStyle(
        color: Colors.white,
      ),
      title: TextStyle(
        color: Colors.amber,
      ),
      body2: TextStyle(
        color: Colors.black,
      ),
    ),
  );
}
