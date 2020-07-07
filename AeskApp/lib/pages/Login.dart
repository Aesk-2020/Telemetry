import 'package:aeskapp/classes/Mqtt.dart';
import 'package:flutter/material.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter_spinkit/flutter_spinkit.dart';
import 'package:provider/provider.dart';
//import 'dart:async';

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
              width: 170,
              child: TextField(
                style: TextStyle(
                  color: Theme.of(context).appBarTheme.color,
                ),
                enableInteractiveSelection: false,
                decoration: InputDecoration(
                  hintText: "IP Adresi",
                  icon: Icon(Icons.assignment_ind)
                ),
                onChanged: (String value) {
                  ip = value;
                },
              ),
            ),
            SizedBox(height: 5,),
            //Şifre textfield
            Container(
              width: 170,
              child: TextField(
                style: TextStyle(
                  color: Theme.of(context).appBarTheme.color,
                ),
                obscureText: true,
                enableInteractiveSelection: false,
                decoration: InputDecoration(
                  hintText: "Şifre",
                  icon: Icon(Icons.lock),
                ),
                onChanged: (String value) {
                  password = value;
                },
              ),
            ),

            //Giriş butonu
            SizedBox(height: 15,),
            RaisedButton(
              onPressed: () async {
                if (ip == "1" && password == MqttAesk.password) {
                  showDialog(
                    context: context,
                    child: SpinKitCircle(color: Theme.of(context).appBarTheme.color,),
                  );
                  dynamic state = await mqttAesk.connect()
                      .timeout(Duration(seconds: 5), onTimeout: () => false);
                  if (state == true) {
                    mqttAesk.subscribeToTopic("LYRADATA");
                    Navigator.pushNamed(context, "/Home");
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
                } else {
                  showDialog(
                    context: context,
                    child: AlertDialog(
                      title: myText("HATA", 30, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      content: myText("Girdiğiniz kullanıcı adı ile parola eşleşmedi!", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
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
