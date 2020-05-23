import 'package:flutter/cupertino.dart';

Widget myText(String input,double mySize,Color myColor){
  return Text(
    input,
    style: TextStyle(
      fontFamily: "IndieFlower",
      fontSize: mySize,
      color: myColor,


    ),
  );
}