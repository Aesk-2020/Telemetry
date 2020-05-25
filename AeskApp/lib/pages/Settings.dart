import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/main.dart';
import 'package:flutter/material.dart';

class Settings extends StatefulWidget {
  @override
  _SettingsState createState() => _SettingsState();
}
bool isDarkMode = false;
class _SettingsState extends State<Settings> {


  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Theme.of(context).backgroundColor,
      appBar: AppBar(
        title: Text(
          "Ayarlar",
          style: Theme.of(context).appBarTheme.textTheme.title,
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

                title: Center(child: myText("Karanlık mod", 20, Theme.of(context).textTheme.body1.color, "GOTHIC", FontWeight.normal)),
                value: isDarkMode,
                onChanged: (bool value){
                  setState(() {
                    isDarkMode = value;
                    print(isDarkMode);
                    var route = MaterialPageRoute(
                      builder: (BuildContext context) => MyApp(isDarkMode: isDarkMode,)
                    );
                    Navigator.of(context).push(route);
                  });
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
