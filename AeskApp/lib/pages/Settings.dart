import 'package:aeskapp/classes/theme.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';

import 'package:provider/provider.dart';

class Settings extends StatefulWidget {
  @override
  _SettingsState createState() => _SettingsState();
}
bool isDarkMode = false;
class _SettingsState extends State<Settings> {


  @override
  Widget build(BuildContext context) {

    MyThemeData myThemeData = Provider.of<MyThemeData>(context);

    return Scaffold(
      backgroundColor: Theme.of(context).backgroundColor,
      appBar: AppBar(
        title: Text(
          "Ayarlar",
          style: Theme.of(context).appBarTheme.textTheme.headline1,
        ),
        backgroundColor: Theme.of(context).appBarTheme.color,
      ),
      body: Column(
          mainAxisAlignment: MainAxisAlignment.spaceAround,
          children: <Widget>[
            Container(
              height: 55,
              margin: EdgeInsets.all(10),
              alignment: Alignment.center,
              decoration: BoxDecoration(
                color: Theme.of(context).appBarTheme.color,
                borderRadius: BorderRadius.all(Radius.circular(50)),
                border:Border.all(
                  color: Theme.of(context).appBarTheme.color,
                  width: 5,
                )
              ),
              child: SwitchListTile(

                title: Center(child: myText("Karanlık mod", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal)),
                value: isDarkMode,
                onChanged: (bool value){
                    isDarkMode = value;
                    myThemeData.setTheme((isDarkMode) ? DarkTheme() : LightTheme());
                }
              ),
            ),
            Container(

            ),
          ],
      ),
    );
  }
}
