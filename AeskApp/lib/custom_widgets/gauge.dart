import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_gauges/gauges.dart';
import 'package:provider/provider.dart';
class AeskGauge extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Consumer<MqttAesk>(
        builder:(context, _, child){
          return Container(
            child: SfRadialGauge(axes: <RadialAxis>[
              RadialAxis(
                  axisLabelStyle: GaugeTextStyle(
                      fontFamily: "Raleway",
                      fontWeight: FontWeight.bold,
                      color: aeskBlue),
                  minorTicksPerInterval: 1,
                  minorTickStyle:
                  MinorTickStyle(thickness: 1, color: aeskBlue),
                  majorTickStyle: MajorTickStyle(
                      thickness: 2, color: aeskBlue, length: 7),
                  interval: 10,
                  radiusFactor: 0.9,
                  minimum: 0,
                  maximum: 60,
                  ranges: <GaugeRange>[
                    GaugeRange(startValue: 0, endValue: 50, gradient: SweepGradient(colors: <Color>[Colors.blue, Colors.green], stops: <double>[0.25, 0.75])),
                    GaugeRange(startValue: 50, endValue: 60, gradient: SweepGradient(colors: <Color>[Colors.green, Colors.red])),
                  ],
                  pointers: <GaugePointer>[
                    NeedlePointer(
                        value: AeskData.driver_actual_velocity_u8.toDouble(),
                        enableDragging: true,
                        needleLength: 0.7,
                        needleEndWidth: 5,
                        needleColor: aeskBlue,
                        knobStyle: KnobStyle(color: aeskBlue))
                  ],
                  annotations: <GaugeAnnotation>[
                    GaugeAnnotation(
                        widget: Container(
                          child: Text(
                            "     ACT\nVELOCITY",
                            style: TextStyle(
                                fontSize: 10,
                                fontWeight: FontWeight.bold,
                                fontFamily: "Raleway",
                                color: aeskBlue),
                          ),
                        ),
                        angle: 90,
                        positionFactor: 0.5)
                  ])
            ]),
          );
        }
    );
  }
}