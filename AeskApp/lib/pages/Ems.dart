import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

Widget Ems() {
  return SingleChildScrollView(
    child: SafeArea(
      child: Consumer<MqttAesk>(
        builder: (context, _, child){
          return Column(
            mainAxisAlignment: MainAxisAlignment.start,
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              myText("   ENERJİ YÖNETİM SİSTEMİ", 25, aeskBlue, FontWeight.bold),
              Card(
                margin: EdgeInsets.fromLTRB(20, 0, 20, 30),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    SizedBox(height: 10,),

                    Column(
                      mainAxisAlignment: MainAxisAlignment.start,
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: <Widget>[
                        myText("    Batarya", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                        myText("    Gerilim:   ${AeskData.eys_bat_volt_uint16} V", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Akım:      ${AeskData.eys_bat_current_int16} A", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Tüketim:   ${AeskData.eys_bat_cons_uint16} Wh", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    SoC:       ${AeskData.eys_bat_soc_uint16} %", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        SizedBox(height: 15,),

                        myText("    Fuel Cell", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                        myText("    Gerilim:   ${AeskData.eys_fc_volt_uint16} V", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Akım:      ${AeskData.eys_fc_current_int16} A", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Tüketim:   ${AeskData.eys_fc_cons_uint16} Wh", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Tüketim (Litre):   ${AeskData.eys_fc_lt_cons_uint16} L", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        SizedBox(height: 15,),

                        myText("    Çıktı", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                        myText("    Gerilim:   ${AeskData.eys_out_volt_uint16} V", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Akım:      ${AeskData.eys_out_current_int16} A", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Tüketim:   ${AeskData.eys_out_cons_uint16} Wh", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        myText("    Ceza:   ${AeskData.eys_penalty_int8} ", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                        SizedBox(height: 15,),

                        Container(
                          //SHARING GRAFİĞİ EKLENEBİLİR
                        ),
                      ],
                    ),

                    myText("    Hatalar", 20, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
                    Divider(thickness: 4,color: Theme.of(context).textTheme.headline3.color,endIndent: 25,indent: 25,),
                    AeskErrorCheck("BATTERY CURRENT", AeskData.eys_bat_cur_error_u1, context),
                    AeskErrorCheck("FUEL CELL CURRENT", AeskData.eys_fc_cur_error_u1, context),
                    AeskErrorCheck("OUT CURRENT", AeskData.eys_out_cur_error_u1, context),
                    AeskErrorCheck("BATTERY CURRENT", AeskData.eys_bat_volt_error_u1, context),
                    AeskErrorCheck("FUEL CELL CURRENT", AeskData.eys_fc_volt_error_u1, context),
                    AeskErrorCheck("OUT CURRENT", AeskData.eys_out_volt_error_u1, context),
                    SizedBox(height: 20,)
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
    return aeskScaffold(
      myBody: Ems(),
      context: context
    );
  }
}
