import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';


class MyThemeData extends ChangeNotifier{
  static bool myTheme = false; // 1 ise darkTheme 0 lightTheme

  void setTheme(bool newTheme){
    myTheme = newTheme;
    notifyListeners();
  }
}