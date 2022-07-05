import 'package:aeskapp/classes/Mqtt.dart';
import 'package:flutter/material.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter_spinkit/flutter_spinkit.dart';
import 'package:provider/provider.dart';
import 'package:mqtt_client/mqtt_client.dart' as mqtt;
import 'dart:async';

String ip;
String password;
bool checkbox = null; // true ise LYRA, false ise hydra

List<DropdownMenuItem<ListItem>> dropdownMenuItems;
ListItem selectedItem;

class Logging extends StatefulWidget {
  @override
  _LoggingState createState() => _LoggingState();
}

class ListItem {
  int value;
  String name;

  ListItem(this.value, this.name);
}

class _LoggingState extends State<Logging> {
  List<ListItem> dropdownItems = [
    ListItem(1, "broker.mqttdashboard.com"),
    ListItem(2, "mqtt.omerfurkandemircioglu.com.tr"),
    ListItem(3, "mqtt.omerustun.com.tr")
  ];

  List<DropdownMenuItem<ListItem>> buildDropDownMenuItems(List listItems) {
    List<DropdownMenuItem<ListItem>> items = List();
    for (ListItem listItem in listItems) {
      items.add(
        DropdownMenuItem(
          child: Text(listItem.name),
          value: listItem,
        ),
      );
    }
    return items;
  }

  void initState() {
    super.initState();
    dropdownMenuItems = buildDropDownMenuItems(dropdownItems);
    selectedItem = dropdownMenuItems[0].value;
  }

  @override
  Widget build(BuildContext context) {
    MqttAesk mqttAesk = Provider.of<MqttAesk>(context); // Mqtt connect methodunu dinlemek için provider ekliyoruz

    return Scaffold(
      backgroundColor: Theme.of(context).backgroundColor,
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            myText("AESKAPP", 35, Theme.of(context).appBarTheme.color, FontWeight.bold),
            SizedBox(
              height: 20,
            ),
            //IP textfield
            Container(
              padding: const EdgeInsets.only(left: 10.0, right: 10.0),
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10.0),
                  color: Theme.of(context).backgroundColor,
                  border: Border.all()),
              child: DropdownButtonHideUnderline(
                child: DropdownButton(
                    value: selectedItem,
                    items: dropdownMenuItems,
                    onChanged: (value) {
                      setState(() {
                        selectedItem = value;
                      });
                    }),
              ),
            ),

            //Araç tipi seçin bölgesi
            SizedBox(
              height: 15,
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: <Widget>[
                Container(
                  width: 170,
                  child: CheckboxListTile(
                    title: myText("NOVA", 20, Theme.of(context).appBarTheme.color, FontWeight.bold),
                    value: checkbox == null ? false : checkbox,
                    controlAffinity: ListTileControlAffinity.leading,
                    onChanged: (value) {
                      setState(() {
                        if (checkbox == null || checkbox == false) checkbox = true;
                      });
                    },
                  ),
                ),
                Container(
                  width: 170,
                  child: CheckboxListTile(
                    title: myText("CASTOR", 20, Theme.of(context).appBarTheme.color, FontWeight.bold),
                    value: checkbox == null ? false : !checkbox,
                    controlAffinity: ListTileControlAffinity.leading,
                    onChanged: (value) {
                      setState(() {
                        if (checkbox == null || checkbox == true) checkbox = false;
                      });
                    },
                  ),
                ),
              ],
            ),
            //Giriş butonu
            SizedBox(
              height: 15,
            ),
            RaisedButton(
              padding: EdgeInsets.symmetric(horizontal: 40),
              onPressed: () async {
                if (checkbox != null) {
                  showDialog(
                    context: context,
                    barrierDismissible: false,
                    builder: (BuildContext context) {
                      return SpinKitCircle(
                        color: Theme.of(context).appBarTheme.color,
                      );
                    },
                  );
                  dynamic state;
                  try {
                    state = await mqttAesk.connect().timeout(Duration(seconds: 5));
                  } catch (e) {
                    state = false;
                  }
                  print(state);
                  if (state == true) {
                    MqttAesk.isLyra = checkbox;
                    if (MqttAesk.isLyra) {
                      mqttAesk.subscribeToTopic("vehicle_to_interface");
                    } else {
                      mqttAesk.subscribeToTopic("vehicle_to_interface_2");
                    }
                    Navigator.pushNamed(context, checkbox ? "/Home" : "/HomeHydro");
                  } else {
                    Navigator.pushReplacementNamed(context, "/Login");
                    showDialog(
                        context: context,
                        builder: (BuildContext context) {
                          return AlertDialog(
                            title: myText("HATA", 30, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                            content: myText("Bağlantı başarısız! Lütfen internet bağlantınızı kontrol edin", 25,
                                Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                            backgroundColor: Theme.of(context).backgroundColor,
                          );
                        });
                  }
                } else {
                  showDialog(
                    context: context,
                    builder: (BuildContext context) {
                      return AlertDialog(
                        title: myText("HATA", 30, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        content: myText("Lütfen bir araç tipi seçiniz.", 25,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        backgroundColor: Theme.of(context).backgroundColor,
                      );
                    },
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
