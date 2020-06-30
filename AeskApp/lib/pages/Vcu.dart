import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/gauge.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';


Widget Vcu(){
  return SafeArea(
    child: SingleChildScrollView(
      child: Consumer<MqttAesk>(
        builder: (context, _, child){
          return Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              myText("    MCU & VCU", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
              Card(
                margin: EdgeInsets.fromLTRB(20, 0, 20, 30),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                      children: <Widget>[
                        myText("Commands", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("Status", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                      ],
                    ),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline1.color,endIndent: 25,indent: 25,),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                      children: <Widget>[
                        myText("IGNI ON", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal), //MCU
                        myText("IGNI ON", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal), //VCU
                      ],
                    ),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                      children: <Widget>[
                        myText("BRAKE OFF", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal), //MCU
                        myText("BRAKE OFF", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal), //VCU
                      ],
                    ),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                      children: <Widget>[
                        myText("FORWARD", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal), //MCU
                        myText("FORWARD", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal), //VCU
                      ],
                    ),
                    SizedBox(height: 15,),
                    myText("     Hatalar", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline1.color,endIndent: 25,indent: 25,),
                    myText("     Yok", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal),
                    SizedBox(height: 15,),
                    myText("     MCU Akım ve Gerilim Seviyeleri", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline1.color,endIndent: 25,indent: 25,),

                    Container(
                      child: myText(" ID : xx         IQ : xx         IArms : xx ", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal),
                      alignment: Alignment.topCenter,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),

                    Container(
                      child: myText("Phase A : xx         Phase B : xx", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal),
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText("IDC : xx         VDC : xx", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal),
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    SizedBox(height: 15,),
                    myText("     Diğer Veriler", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline1.color,endIndent: 25,indent: 25,),
                    Container(
                      child: myText("Sıcaklık : 30°C", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal),
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText("Hız : 27 km/h", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal),
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    Container(
                      child: myText("Gidilen Mesafe : xx", 20, Theme.of(context).textTheme.headline1.color, FontWeight.normal),
                      alignment: Alignment.center,
                      margin: EdgeInsets.fromLTRB(25, 0, 25, 5),
                      decoration: BoxDecoration(
                        border: Border.all(width: 2,color: Theme.of(context).textTheme.headline1.color),
                        borderRadius: BorderRadius.circular(3),
                      ),
                    ),
                    SizedBox(height: 15,),
                    AeskGauge(),
                  ],
                ),
              ),
            ],
          );
        },
      ),
    ),
  );
}


class VcuPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Vcu(),
    );
  }
}
