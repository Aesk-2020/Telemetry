import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';


class MyThemeData extends ChangeNotifier{
   // 1 ise darkTheme 0 lightTheme
  static bool myTheme;
  void setTheme(bool newTheme){
    myTheme ??= false;
    myTheme = newTheme;
    notifyListeners();
  }
}