import 'dart:async';
import 'package:shared_preferences/shared_preferences.dart';

class SharedPrefs{

  static Future<bool> setThemePref(bool value) async{
    SharedPreferences prefs = await SharedPreferences.getInstance();
    prefs.setBool("darkMode", value);
    return prefs.commit();
  }
  static Future<bool> getThemePref() async{
    SharedPreferences prefs = await SharedPreferences.getInstance();
    bool theme = prefs.getBool("darkMode") ??  false;
    return theme;
  }

}