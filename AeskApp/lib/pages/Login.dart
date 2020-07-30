import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:flutter/material.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter_spinkit/flutter_spinkit.dart';
import 'package:provider/provider.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'dart:async';

String ip;
String password;
bool checkbox = null; // true ise LYRA, false ise hydra

class Logging extends StatefulWidget {
  @override
  _LoggingState createState() => _LoggingState();
}

class _LoggingState extends State<Logging> {
  @override
  Widget build(BuildContext context) {

    MqttAesk mqttAesk = Provider.of<MqttAesk>(context);     // Mqtt connect methodunu dinlemek için provider ekliyoruz

    return Scaffold(
      backgroundColor: Theme.of(context).backgroundColor,
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            myText("AESKAPP", 35, Theme.of(context).appBarTheme.color, FontWeight.bold),
            SizedBox(height: 20,),
            //IP textfield
            Container(
              width: 350,
              child: TextField(

                style: TextStyle(
                  color: Theme.of(context).appBarTheme.color,
                ),
                enableInteractiveSelection: false,
                decoration: InputDecoration(
                  hintText: "IP Adresi",
                  icon: Icon(Icons.assignment_ind,color: Theme.of(context).appBarTheme.color)
                ),
                onChanged: (String value) {
                  ip = value;
                },
              ),
            ),
            SizedBox(height: 5,),
            //Şifre textfield
            Container(
              width: 350,
              child: TextField(
                style: TextStyle(
                  color: Theme.of(context).appBarTheme.color,
                ),
                obscureText: true,
                enableInteractiveSelection: false,
                decoration: InputDecoration(
                  hintText: "Şifre",
                  hoverColor: Colors.white,
                  icon: Icon(Icons.lock,color: Theme.of(context).appBarTheme.color),
                ),
                onChanged: (String value) {
                  password = value;
                },
              ),
            ),

            //Araç tipi seçin bölgesi
            SizedBox(height: 15,),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: <Widget>[
                Container(
                  width: 170,
                  child: CheckboxListTile(
                    title: myText("LYRA", 20, Theme.of(context).appBarTheme.color, FontWeight.bold),
                    value: checkbox == null ? false : checkbox,
                    controlAffinity: ListTileControlAffinity.leading,
                    onChanged: (value) {
                      setState(() {
                        if(checkbox == null || checkbox == false) checkbox = true;
                      });
                    },
                  ),
                ),
                Container(
                  width: 170,
                  child: CheckboxListTile(
                    title: myText("HYDRA", 20, Theme.of(context).appBarTheme.color, FontWeight.bold),
                    value: checkbox == null ? false : !checkbox,
                    controlAffinity: ListTileControlAffinity.leading,
                    onChanged: (value) {
                      setState(() {
                        if(checkbox == null || checkbox == true) checkbox = false;
                      });
                    },
                  ),
                ),
              ],

            ),
            //Giriş butonu
            SizedBox(height: 15,),
            RaisedButton(
              padding: EdgeInsets.symmetric(horizontal: 40),
              onPressed: () async {
                if (ip == "1" && password == MqttAesk.password && checkbox != null) {
                  showDialog(
                    context: context,
                    child: SpinKitCircle(color: Theme.of(context).appBarTheme.color,),
                    barrierDismissible: false,
                  );
                  dynamic state;
                  try{
                     state = await mqttAesk.connect().timeout(Duration(seconds: 5));
                  }catch(e){
                    state = false;
                  }
                  print(state);
                  if (state == true) {
                    MqttAesk.isLyra = checkbox;
                    checkbox ? mqttAesk.subscribeToTopic("LYRADATA") : mqttAesk.subscribeToTopic("HYDRADATA");
                    Navigator.pushNamed(context, checkbox ? "/Home" : "/HomeHydro");
                  } else {
                    Navigator.pushReplacementNamed(context, "/Login");
                    showDialog(
                      context: context,
                      child: AlertDialog(
                        title: myText("HATA", 30, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        content: myText("Bağlantı başarısız! Lütfen internet bağlantınızı kontrol edin", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        backgroundColor: Theme.of(context).backgroundColor,
                      ),
                    );
                  }
                } else if(checkbox != null) {
                  showDialog(
                    context: context,
                    child: AlertDialog(
                      title: myText("HATA", 30, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      content: myText("Girdiğiniz kullanıcı adı ile parola eşleşmedi!", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      backgroundColor: Theme.of(context).backgroundColor,
                    ),
                  );
                }else{
                  showDialog(
                    context: context,
                    child: AlertDialog(
                      title: myText("HATA", 30, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      content: myText("Lütfen bir araç tipi seçiniz.", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      backgroundColor: Theme.of(context).backgroundColor,
                    ),
                  );
                }
              },
              child: myText("Giriş", 20, Colors.white, FontWeight.normal),
            ),
          ],
        ),
      ),
    );
  }
}
