import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/classes/theme.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:aeskapp/classes/Mqtt.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Consumer<MyThemeData>(
      builder: (context, ourTheme, child) {
        return aeskScaffold(
          context: context,
          myBody: Consumer<MqttAesk>(
            builder: (context, _, child) {
              return ListView(
                shrinkWrap: true,
                padding: const EdgeInsets.fromLTRB(2.0, 10.0, 2.0, 10.0),
                children: <Widget>[
                  Column(
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
                        veri: AeskData.driver_motor_temperature_u8.toString(),
                      ),
                      DataBox(
                        ad: "Phase A Current",
                        veri: AeskData.driver_phase_a_current_f32.toString(),
                      ),
                      DataBox(
                        ad: "Phase B Current",
                        veri: AeskData.driver_phase_b_current_f32.toString(),
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
                  )
                ],
              );
            },
          ),
        );
      },
    );
  }
}

class DataBox extends StatelessWidget {
  DataBox({Key key, this.ad, this.veri}) : super(key: key);
  final String ad;
  final String veri;

  Widget build(BuildContext context) {
    return Container(
      padding: EdgeInsets.all(0),
      height: 50,
      child: Card(
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          children: <Widget>[
            Expanded(
              child: Container(
                padding: EdgeInsets.all(5),
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  children: <Widget>[
                    Text(this.ad + " : " + this.veri),
                  ],
                ),
              ),
            )
          ],
        ),
      ),
    );
  }
}
