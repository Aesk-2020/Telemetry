import 'package:flutter/material.dart';

Color aeskBlue = Color.fromRGBO(47, 136, 202, 1.0);
Color aeskBlack = Color.fromRGBO(48, 51, 58, 1.0);

ThemeData LightTheme() {
  return ThemeData(
    backgroundColor: Colors.white70,
    buttonColor: aeskBlue,
<<<<<<< HEAD
    cardColor: Colors.white70,
    iconTheme: IconThemeData(
      color: Colors.black,
    ),
=======
>>>>>>> emreurcu
    appBarTheme: AppBarTheme(
      color: Colors.blueAccent,
      textTheme: TextTheme(
        headline1: TextStyle(color: Colors.amber, fontFamily: "GOTHIC", fontSize: 25, fontWeight: FontWeight.bold,),
      ),
    ),
    textSelectionColor: Colors.blue,
    textTheme: TextTheme(
      headline1: TextStyle(color: Colors.black,),
      headline2: TextStyle(color: Colors.amber,),
<<<<<<< HEAD
      headline3: TextStyle(color: aeskBlue,),
=======
      headline3: TextStyle(color: Colors.white,),
>>>>>>> emreurcu
    ),
  );
}

ThemeData DarkTheme() {
  return ThemeData(
    backgroundColor: aeskBlack,
    buttonColor: aeskBlue,
<<<<<<< HEAD
    cardColor: Colors.black26,
    iconTheme: IconThemeData(
      color: Colors.white,
    ),
=======
>>>>>>> emreurcu
    appBarTheme: AppBarTheme(
      color: Colors.grey,
      textTheme: TextTheme(
        headline1: TextStyle(color: Colors.white, fontFamily: "GOTHIC", fontSize: 25, fontWeight: FontWeight.bold,),
      ),
    ),
    textSelectionColor: Colors.blue,
    textTheme: TextTheme(
      headline1: TextStyle(color: Colors.white,),
      headline2: TextStyle(color: Colors.amber,),
<<<<<<< HEAD
      headline3: TextStyle(color: aeskBlue,),
=======
      headline3: TextStyle(color: Colors.black,),
>>>>>>> emreurcu
    ),
  );
}
