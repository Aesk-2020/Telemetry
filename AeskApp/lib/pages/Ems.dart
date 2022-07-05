import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';
import 'package:mqtt_client/mqtt_client.dart' as mqtt;

Widget Ems() {
  TextEditingController sharingController = TextEditingController();

  return SingleChildScrollView(
    child: SafeArea(
      child: Consumer<MqttAesk>(
        builder: (context, _, child) {
          MqttAesk mqttAesk = Provider.of<MqttAesk>(context);
          return Column(
            mainAxisAlignment: MainAxisAlignment.start,
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  myText("   EMS", 25, aeskBlue, FontWeight.bold),
                  Padding(
                    padding: const EdgeInsets.fromLTRB(0, 0, 20, 0),
                    child: ElevatedButton.icon(
                        icon: Icon(AeskData.isMQTTRunning ? CupertinoIcons.play : CupertinoIcons.stop,
                            color: Theme.of(context).textTheme.headline2.color),
                        label: myText("MQTT", 12, AeskData.isMQTTRunning ? Colors.green : Colors.red, FontWeight.bold),
                        onPressed: () async {
                          if (!AeskData.isMQTTRunning) {
                            mqttAesk.disconnect();
                            dynamic state;
                            try {
                              state = await mqttAesk.connect().timeout(Duration(seconds: 5));
                            } catch (e) {
                              state = false;
                            }
                            print(state);
                            if (state == true) {
                              if (MqttAesk.isLyra) {
                                mqttAesk.subscribeToTopic("vehicle_to_interface");
                              } else {
                                mqttAesk.subscribeToTopic("vehicle_to_interface_2");
                              }
                            }
                          }
                          ;
                        }),
                  ),
                ],
              ),
              Card(
                margin: EdgeInsets.fromLTRB(20, 0, 20, 30),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    SizedBox(
                      height: 10,
                    ),
                    Column(
                      mainAxisAlignment: MainAxisAlignment.start,
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: <Widget>[
                        myText("    Batarya", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Divider(
                          thickness: 4,
                          color: Theme.of(context).textTheme.headline3.color,
                          endIndent: 25,
                          indent: 25,
                        ),
                        myText("    Gerilim:   ${AeskData.eys_bat_volt_int16} V", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Akım:      ${AeskData.eys_bat_current_int16} A", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Tüketim:   ${AeskData.eys_bat_cons_uint16} Wh", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Sharing Ratio:       ${AeskData.eys_sharing_ratio_uint16} %", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Sıcaklık:  ${AeskData.eys_temp_uint8} °C", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        SizedBox(
                          height: 15,
                        ),
                        myText("    Fuel Cell", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Divider(
                          thickness: 4,
                          color: Theme.of(context).textTheme.headline3.color,
                          endIndent: 25,
                          indent: 25,
                        ),
                        myText("    Gerilim:   ${AeskData.eys_fc_volt_int16} V", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Akım:      ${AeskData.eys_fc_current_int16} A", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Tüketim:   ${AeskData.eys_fc_cons_uint16 * 3} Wh", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Tüketim (Litre):   ${AeskData.eys_fc_lt_cons_uint16} L", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        SizedBox(
                          height: 15,
                        ),
                        myText("    Çıktı", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Divider(
                          thickness: 4,
                          color: Theme.of(context).textTheme.headline3.color,
                          endIndent: 25,
                          indent: 25,
                        ),
                        myText("    Gerilim:   ${AeskData.eys_out_volt_int16} V", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Akım:      ${AeskData.eys_out_current_int16} A", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Tüketim:   ${AeskData.eys_out_cons_uint16} Wh", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Ceza:   ${AeskData.eys_penalty_int8} ", 20,
                            Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        SizedBox(
                          height: 15,
                        ),
                        Container(
                            //SHARING GRAFİĞİ EKLENEBİLİR
                            ),
                      ],
                    ),
                    myText("    Hatalar", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(
                      thickness: 4,
                      color: Theme.of(context).textTheme.headline3.color,
                      endIndent: 25,
                      indent: 25,
                    ),
                    AeskErrorCheck("BATTERY CURRENT", AeskData.eys_bat_cur_error_u1, context),
                    AeskErrorCheck("FUEL CELL CURRENT", AeskData.eys_fc_cur_error_u1, context),
                    AeskErrorCheck("OUT CURRENT", AeskData.eys_out_cur_error_u1, context),
                    AeskErrorCheck("BATTERY CURRENT", AeskData.eys_bat_volt_error_u1, context),
                    AeskErrorCheck("FUEL CELL CURRENT", AeskData.eys_fc_volt_error_u1, context),
                    AeskErrorCheck("OUT CURRENT", AeskData.eys_out_volt_error_u1, context),
                    SizedBox(
                      height: 20,
                    ),
                    Divider(
                      thickness: 4,
                      color: Theme.of(context).textTheme.headline3.color,
                      endIndent: 25,
                      indent: 25,
                    ),
                    SizedBox(
                      height: 10,
                    ),
                    Container(
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      child: TextField(
                        inputFormatters: [
                          FilteringTextInputFormatter.digitsOnly,
                          LengthLimitingTextInputFormatter(
                            2,
                          ),
                        ],
                        style: TextStyle(
                            fontFamily: "GOTHIC",
                            fontSize: 20,
                            color: Theme.of(context).textTheme.headline1.color,
                            fontWeight: FontWeight.bold),
                        keyboardType: TextInputType.numberWithOptions(),
                        controller: sharingController,
                        decoration: InputDecoration(
                          border: OutlineInputBorder(),
                          labelText: "Sharing Ratio",
                          suffixIcon: Icon(Icons.settings_input_component),
                          labelStyle: TextStyle(
                              fontFamily: "GOTHIC",
                              fontSize: 20,
                              color: Theme.of(context).textTheme.headline1.color,
                              fontWeight: FontWeight.bold),
                        ),
                      ),
                    ),
                    Container(
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      child: ElevatedButton.icon(
                          icon:
                              Icon(CupertinoIcons.paperplane_fill, color: Theme.of(context).textTheme.headline2.color),
                          label: myText("Send", 12, Theme.of(context).textTheme.headline2.color, FontWeight.bold),
                          onPressed: () async {
                            final builder = mqtt.MqttClientPayloadBuilder();
                            var vall = int.parse(sharingController.value.text);
                            vall = (vall >= 50) ? (vall - 50) : vall;
                            builder.addByte(0x14); //SYNC1
                            builder.addByte(0x04); //SYNC2
                            builder.addByte(0x31); //VEHICLE
                            builder.addByte(0x14); //TARGET ID FOR EYS and TCU
                            builder.addByte(0x80); //SOURCE
                            builder.addByte(0x1F); //SOURCE MSG ID SET EYS SHARING
                            builder.addByte(0x01); //MSG SIZE
                            builder.addByte(vall); //MSG
                            builder.addByte(0xA0); //INDEX_L
                            builder.addByte(0x01); //INDEX_H
                            builder.addByte(0x01); //CRC_L - SALLAMA CRC
                            builder.addByte(0x01); //CRC_H - GOMULUDE BYPASS EDILIYOR

                            MqttAesk.client
                                .publishMessage("interface_to_vehicle_2", mqtt.MqttQos.atMostOnce, builder.payload);
                            print("eys_sharing_send");
                          }),
                    ),
                  ],
                ),
              )
            ],
          );
        },
      ),
    ),
  );
}

class EmsPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(myBody: Ems(), context: context);
  }
}
