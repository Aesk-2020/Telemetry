import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';


class MyThemeData extends ChangeNotifier{
  ThemeData _myTheme;

  ThemeData get myTheme => _myTheme;

  void setTheme(ThemeData newTheme){
    _myTheme = newTheme;
    notifyListeners();
  }
}