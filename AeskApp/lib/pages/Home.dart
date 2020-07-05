import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';
import 'package:aeskapp/classes/Mqtt.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return WillPopScope(
      onWillPop: () {
        showDialog(
          context: context,
          child: CupertinoAlertDialog(
            //backgroundColor: Theme.of(context).backgroundColor,
            content: Text(
              "Çıkmak istediğinize emin misiniz?",
              style: TextStyle(fontSize: 20, color: Colors.black),
            ),
            actions: <Widget>[
              CupertinoDialogAction(
                child: myText("HAYIR", 18, Colors.black, FontWeight.bold),
                onPressed: () => Navigator.pop(context, false),
              ),
              CupertinoDialogAction(
                child: myText("EVET", 18, Colors.black, FontWeight.bold),
                onPressed: () =>
                    SystemChannels.platform.invokeMethod('SystemNavigator.pop'),
              ),
            ],
          ),
        );
      },
      child: SafeArea(
        child: aeskScaffold(
          context: context,
          myBody: Consumer<MqttAesk>(
            builder: (context, _, child) {
              return Column(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.start,
                children: <Widget>[
                  myText(
                      "\nANA SAYFA",
                      25,
                      Theme.of(context).textTheme.headline3.color,
                      FontWeight.bold),
                  Divider(
                    thickness: 5,
                    height: 10,
                    indent: 134,
                    endIndent: 134,
                    color: Theme.of(context).textTheme.headline3.color,
                  ),
                  Row(
                    children: <Widget>[
                      Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: <Widget>[
                          DataBox(
                            ad: "Ping",
                            veri: AeskData.ping.toString(),
                          ),
                          DataBox(
                            ad: "BAT VOLT",
                            veri: AeskData.bms_bat_volt_f32.toString(),
                          ),
                          DataBox(
                            ad: "BAT CUR",
                            veri: AeskData.bms_bat_current_f32.toString(),
                          ),
                          DataBox(
                            ad: "BAT CONS",
                            veri: AeskData.bms_bat_cons_f32.toString(),
                          ),
                          DataBox(
                            ad: "SOC",
                            veri: AeskData.bms_soc_f32.toString(),
                          ),
                        ],
                      ),
                      Column(
                        children: <Widget>[
                          DataBox(
                            ad: "MOTOR TEMP",
                            veri:
                                AeskData.driver_motor_temperature_u8.toString(),
                          ),
                          DataBox(
                            ad: "Phase A Current",
                            veri:
                                AeskData.driver_phase_a_current_f32.toString(),
                          ),
                          DataBox(
                            ad: "Phase B Current",
                            veri:
                                AeskData.driver_phase_b_current_f32.toString(),
                          ),
                          DataBox(
                            ad: "DC BUS CUR",
                            veri: AeskData.driver_dc_bus_current_f32.toString(),
                          ),
                          DataBox(
                            ad: "DC BUS VOLT",
                            veri: AeskData.driver_dc_bus_voltage_f32.toString(),
                          ),
                        ],
                      ),
                    ],
                  ),
                ],
              );
            },
          ),
        ),
      ),
    );
  }
}

class DataBox extends StatelessWidget {
  DataBox({Key key, this.ad, this.veri}) : super(key: key);
  final String ad;
  final String veri;

  Widget build(BuildContext context) {
    return Container(
      height: 50,
      width: 180,
      alignment: Alignment.center,
      margin: EdgeInsets.fromLTRB(14, 20, 10, 20),
      decoration: BoxDecoration(
        color: Theme.of(context).textTheme.subtitle1.color,
        borderRadius: BorderRadius.all(Radius.circular(20)),
        border: Border.all(
          color: Theme.of(context).textTheme.subtitle1.color,
          width: 5,
        ),
      ),
      child: Center(
        child: Text(
          this.ad + " : " + this.veri,
          style: TextStyle(
              color: Theme.of(context).textTheme.headline1.color,
              fontWeight: FontWeight.bold,
              fontSize: 15),
        ),
      ),
    );
  }
}
