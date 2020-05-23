import 'package:flutter/cupertino.dart';

Widget myText(String input,double mySize,Color myColor,String myFont ){
  return Text(
    input,
    style: TextStyle(
      fontFamily: myFont,
      fontSize: mySize,
      color: myColor,


    ),
  );
}