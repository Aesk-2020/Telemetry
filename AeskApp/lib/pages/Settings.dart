import 'package:aeskapp/classes/theme.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:aeskapp/classes/SharedPreferences.dart';
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
        mainAxisAlignment: MainAxisAlignment.start,
        children: <Widget>[
          Container(
            height: 65,
            margin: EdgeInsets.fromLTRB(10, 10, 10, 10),
            alignment: Alignment.topLeft,
            decoration: BoxDecoration(
              color: Theme.of(context).cardColor,
              borderRadius: BorderRadius.all(Radius.circular(10)),
            ),
            child: SwitchListTile(
              title: myText("Karanlık mod", 20,
                  Theme.of(context).textTheme.headline1.color, FontWeight.bold),
              value: MyThemeData.myTheme,
              contentPadding: EdgeInsets.fromLTRB(17, 0, 0, 20),
              onChanged: (bool value) async{
                isDarkMode = value;
                myThemeData.setTheme(isDarkMode);
                SharedPrefs.setThemePref(value);
              },
              subtitle: myText(MyThemeData.myTheme ? "Açık" : "Kapalı", 15, Theme.of(context).textTheme.headline1.color, FontWeight.normal),
            ),
          ),
          Container(
            height: 55,
            margin: EdgeInsets.fromLTRB(10, 0, 10, 10),
            alignment: Alignment.topLeft,
            decoration: BoxDecoration(
              color: Theme.of(context).cardColor,
              borderRadius: BorderRadius.all(Radius.circular(10)),
            ),
            child: ListTile(
              title: myText("Hakkında", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
              onTap: () {
                showDialog(
                  context: context,
                  child: AlertDialog(
                    title: myText("Hakkında", 20, aeskBlue, FontWeight.bold),
                    backgroundColor: Theme.of(context).backgroundColor,
                    content: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: <Widget>[
                        myText(
                            "Bu uygulama AESK Nesne Yönelim Ekibi tarafından geliştirilmiştir",
                            20,
                            Theme.of(context).textTheme.headline1.color,
                            FontWeight.bold),
                        SizedBox(height: 10,),
                        Text(
                          "Geliştiriciler:",
                          style: TextStyle(
                              decoration: TextDecoration.underline,
                              color: Theme.of(context).textTheme.headline1.color,
                              fontWeight: FontWeight.bold,
                              fontSize: 20),
                        ),
                        myText("Ahmet Furkan Ünlü", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("Emre Urcu", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("Yusuf Kemal Palacı", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("Yusuf Yıldız", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      ],
                    ),
                  ),
                );
              },
            ),
          ),
        ],
      ),
    );
  }
}
