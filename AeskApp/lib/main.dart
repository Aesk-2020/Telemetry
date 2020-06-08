import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/classes/theme.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import 'package:aeskapp/custom_widgets/front_inventory.dart';

import 'package:aeskapp/pages/Custom.dart';
import 'package:aeskapp/pages/General.dart';
import 'package:aeskapp/pages/Loading.dart';
import 'package:aeskapp/pages/Graphs.dart';
import 'package:aeskapp/pages/Home.dart';
import 'package:aeskapp/pages/Login.dart';
import 'package:aeskapp/pages/Bms.dart';
import 'package:aeskapp/pages/Settings.dart';
import 'package:aeskapp/pages/Location.dart';

import 'package:aeskapp/classes/Mqtt.dart';
import 'package:syncfusion_flutter_core/core.dart';

void main() {
  SyncfusionLicense.registerLicense(
      "NT8mJyc2IWhia31ifWN9Z2FoYmF8YGJ8ampqanNiYmlmamlmanMDHmgqJiAmNTg2PjI/IzI/MjA6EyoyMj06fTA8Pg==");
  return runApp(MyApp());
}

class MyApp extends StatelessWidget {

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      //Burda Tedarikçi ekliyoruz böylece istediğimiz sınıftaki değişikliği anında tespit edebiliriz
      providers: [
        ChangeNotifierProvider<MyThemeData>(
          create: (context) => MyThemeData(),
        ),
        ChangeNotifierProvider<MqttAesk>(
          create: (context) => MqttAesk(),
        ),
      ],
      child: Consumer<MyThemeData>(     //Burda tedarikçiden gelen bilgiyi kullanacak widget bulunmakta
        builder: (context, myTheme, child) {   /// builderda [MyThemeData] tipinde [context] içinde(sanırım) myTheme objesi oluşturuluyor
          return MaterialApp(
            theme: LightTheme(),
            darkTheme: DarkTheme(),
            themeMode: (myTheme.myTheme == DarkTheme()) ? ThemeMode.dark : ThemeMode.light,

            initialRoute: "/Login",
            routes: {
              "/Login": (context) => Logging(),
              "/Home": (context) => Home(),
              "/General": (context) => General(),
              "/Custom": (context) => Custom(),
              "/Graphs": (context) => Graphs(),
              "/Loading": (context) => Loading(),
              "/Bms": (context) => Bms(),
              "/Settings": (context) => Settings(),
              "/Location": (context) => Konum(),
            },
          );
        },
      ),
    );
  }
}
