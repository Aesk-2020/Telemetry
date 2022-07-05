import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'dart:async';
import 'package:flutter_markdown/flutter_markdown.dart';

final stopWatchTotal = Stopwatch();
final stopWatchLap = Stopwatch();
bool isRunning = false;
Timer timer;
Timer speedTimer;
Timer mqttConnectionTimer;
var sumOfSpeed = 0.0;
var averageSpeed = 0.0;
var lapCount = 0;
var timePassed = 0;
var maxPower = 0.0;
var tempRTCSecond = 0;

var totalConsumption = 0.0;
var lapConsumption = 0.0;
List<double> consList = List<double>();
List<String> lapTimes = List<String>();
List<String> averageSpeedList = List<String>();
List<String> maxPowerList = List<String>();

class TestPage extends StatefulWidget {
  @override
  _TestPageState createState() => _TestPageState();
}

class _TestPageState extends State<TestPage> {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Test(),
    );
  }

  @override
  void initState() {
    timer = Timer.periodic(Duration(milliseconds: 10), updateTime);

    super.initState();
  }

  @override
  void dispose() {
    //...
    timer.cancel();
    super.dispose();
  }

  Widget Test() {
    MqttAesk mqttAesk = Provider.of<MqttAesk>(context);
    return SingleChildScrollView(
      child: SafeArea(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          mainAxisAlignment: MainAxisAlignment.start,
          children: <Widget>[
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                myText("   Tur Kronometre", 25, Theme.of(context).textTheme.headline3.color, FontWeight.bold),
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
            SizedBox(
              height: 10,
            ),
            Card(
              margin: EdgeInsets.fromLTRB(20, 0, 20, 30),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: <Widget>[
                  SizedBox(
                    height: 20,
                  ),
                  Container(
                    height: 50,
                    alignment: Alignment.center,
                    margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                    decoration: BoxDecoration(
                      border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
                      borderRadius: BorderRadius.circular(3),
                    ),
                    child: Row(
                      mainAxisAlignment: MainAxisAlignment.spaceAround,
                      children: <Widget>[
                        myText("Total", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Container(
                          //margin: EdgeInsets.all(scale.size.width/41.142857),
                          child: myText(stopWatchTotal.elapsed.toString().substring(0, 10), 25,
                              Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        ),
                      ],
                    ),
                  ),
                  Container(
                    height: 50,
                    alignment: Alignment.center,
                    margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                    decoration: BoxDecoration(
                      border: Border.all(width: 2, color: Theme.of(context).textTheme.headline1.color),
                      borderRadius: BorderRadius.circular(3),
                    ),
                    child: Row(
                      mainAxisAlignment: MainAxisAlignment.spaceAround,
                      children: <Widget>[
                        myText("Lap", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Container(
                          //margin: EdgeInsets.all(scale.size.width/41.142857),
                          child: myText(stopWatchLap.elapsed.toString().substring(2, 10), 25,
                              Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        ),
                      ],
                    ),
                  ),
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                    children: [
                      ElevatedButton.icon(
                          icon: Icon(!isRunning ? CupertinoIcons.play : CupertinoIcons.stop,
                              color: Theme.of(context).textTheme.headline2.color),
                          label: myText(!isRunning ? "Start" : "Stop", 12, Theme.of(context).textTheme.headline2.color,
                              FontWeight.bold),
                          onPressed: () async {
                            setState(() {
                              if (!isRunning) {
                                stopWatchTotal.start();
                                stopWatchLap.start();
                                timer = Timer.periodic(Duration(milliseconds: 10), updateTime);
                                speedTimer = Timer.periodic(Duration(seconds: 1), SpeedSum);
                                isRunning = true;
                                print("inananan kahya");
                              } else {
                                timer.cancel();
                                speedTimer.cancel();
                                stopWatchLap.stop();
                                stopWatchTotal.stop();
                                isRunning = false;
                                print("inanmayan kahya");
                              }
                            });
                          }),
                      ElevatedButton.icon(
                        icon: Icon(isRunning ? CupertinoIcons.plus : CupertinoIcons.clear,
                            color: Theme.of(context).textTheme.headline2.color),
                        label: myText(isRunning ? "Lap" : "Clear", 12, Theme.of(context).textTheme.headline2.color,
                            FontWeight.bold),
                        onPressed: () async {
                          setState(() {
                            if (isRunning) {
                              lapTimes.add(stopWatchLap.elapsed.toString());

                              lapConsumption = AeskData.bms_bat_cons_f32 - totalConsumption;
                              totalConsumption += lapConsumption;
                              consList.add(lapConsumption);
                              lapCount++;
                              averageSpeed = sumOfSpeed / timePassed;
                              timePassed = 0;
                              sumOfSpeed = 0;
                              averageSpeedList.add(averageSpeed.toStringAsFixed(1));
                              maxPowerList.add(maxPower.toStringAsFixed(1));
                              maxPower = 0;
                              stopWatchLap.reset();
                            } else {
                              stopWatchTotal.reset();
                              stopWatchLap.reset();
                              consList.clear();
                              lapTimes.clear();
                              averageSpeedList.clear();
                              maxPowerList.clear();
                              timePassed = 0;
                              sumOfSpeed = 0;
                              maxPower = 0;
                              lapCount = 0;
                            }
                          });
                        },
                      ),
                    ],
                  ),
                  SizedBox(
                    height: 15,
                  ),
                  Divider(
                    thickness: 4,
                    color: Theme.of(context).textTheme.headline3.color,
                    endIndent: 1,
                    indent: 1,
                  ),
                  SizedBox(
                    height: 10,
                  ),
                  Center(
                    child: Row(
                      mainAxisAlignment: MainAxisAlignment.spaceAround,
                      children: [
                        Expanded(
                            flex: 1,
                            child: myText(" Lap", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
                        Expanded(
                            flex: 2,
                            child:
                                myText("Lap Time", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
                        Expanded(
                            flex: 2,
                            child: myText("Cons", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
                        Expanded(
                            flex: 2,
                            child: myText(
                                "Average Speed", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
                        Expanded(
                            flex: 2,
                            child:
                                myText("Max Pow.", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
                      ],
                    ),
                  ),
                  SizedBox(
                    height: 15,
                  ),
                  Divider(
                    thickness: 4,
                    color: Theme.of(context).textTheme.headline3.color,
                    endIndent: 1,
                    indent: 1,
                  ),
                  ListView.builder(
                      padding: const EdgeInsets.all(8),
                      itemCount: lapCount,
                      shrinkWrap: true,
                      itemBuilder: (BuildContext context, int index) {
                        return LapList(context, index);
                      }),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  Widget LapList(BuildContext context, int index) {
    return Center(
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        children: [
          Expanded(
              flex: 1,
              child: myText((index + 1).toString(), 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
          Expanded(
              flex: 2,
              child: myText(
                  lapTimes[index].substring(2, 7), 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
          Expanded(
              flex: 2,
              child: myText(consList[index].toStringAsFixed(1) + " Wh", 15, Theme.of(context).textTheme.headline1.color,
                  FontWeight.bold)),
          Expanded(
              flex: 2,
              child: myText(
                  averageSpeedList[index] + " km/h", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
          Expanded(
              flex: 2,
              child: myText(
                  " " + maxPowerList[index] + " W", 15, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
        ],
      ),
    );
  }

  void updateTime(Timer timer) {
    if (stopWatchTotal.isRunning && mounted) {
      setState(() {
        maxPower = AeskData.bms_power_f32 > maxPower ? AeskData.bms_power_f32 : maxPower;
      });
    }
  }

  void SpeedSum(Timer timer) {
    sumOfSpeed += AeskData.driver_actspeed_s16;
    timePassed++;
  }
}
