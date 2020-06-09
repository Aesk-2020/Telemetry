import 'package:aeskapp/classes/Mqtt.dart';
import 'package:flutter/material.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:provider/provider.dart';
import 'dart:async';

String ip;
String password;

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
              width: 140,
              child: TextField(
                style: TextStyle(
                  color: Theme.of(context).appBarTheme.color,
                ),
                enableInteractiveSelection: false,
                decoration: InputDecoration(
                  hintText: "IP Adresi",
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.all(Radius.circular(10))
                  ),
                ),
                onChanged: (String value) {
                  ip = value;
                },
              ),
            ),
            SizedBox(height: 5,),
            //Şifre textfield
            Container(
              width: 140,
              child: TextField(
                style: TextStyle(
                  color: Theme.of(context).appBarTheme.color,
                ),
                obscureText: true,
                enableInteractiveSelection: false,
                decoration: InputDecoration(
                  hintText: "Şifre",
                  icon: Icon(Icons.lock),
                  border: OutlineInputBorder(),
                ),
                onChanged: (String value) {
                  password = value;
                },
              ),
            ),
            //Giriş butonu
            RaisedButton(
              onPressed: () async {
                if (ip == "1" && password == MqttAesk.password) {
                  dynamic state = await mqttAesk.connect();
                  if(state){
                    mqttAesk.subscribeToTopic("/home/sensor");
                    Navigator.pushNamed(context, "/Home");
                  }else{
                    showDialog(
                      context: context,
                      child: AlertDialog(
                        title: myText("HATA", 30, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        content: myText("Bağlantı başarısız!", 25,Theme.of(context).textTheme.headline1.color , FontWeight.bold),
                        backgroundColor: Theme.of(context).backgroundColor,
                      ),
                    );
                  }
                } else {
                  showDialog(
                      context: context,
                      child: AlertDialog(
                        title: myText("HATA", 30, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        content: myText("Girdiğiniz kullanıcı adı ile parola eşleşmedi!", 25,Theme.of(context).textTheme.headline1.color, FontWeight.bold),
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
