import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_gauges/gauges.dart';

class AeskGauge extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      child: SfRadialGauge(axes: <RadialAxis>[
        RadialAxis(
            axisLabelStyle: GaugeTextStyle(
                fontFamily: "Raleway",
                fontWeight: FontWeight.bold,
                color: Colors.deepOrange),
            minorTicksPerInterval: 1,
            minorTickStyle:
            MinorTickStyle(thickness: 1, color: Colors.deepOrange),
            majorTickStyle: MajorTickStyle(
                thickness: 2, color: Colors.deepOrange, length: 7),
            interval: 10,
            radiusFactor: 0.9,
            minimum: 0,
            maximum: 60,
            ranges: <GaugeRange>[
              GaugeRange(
                  startValue: 0,
                  endValue: 40,
                  gradient: SweepGradient(
                      colors: <Color>[Colors.blue, Colors.green],
                      stops: <double>[0.25, 0.75])),
              GaugeRange(
                  startValue: 40,
                  endValue: 50,
                  gradient:
                  SweepGradient(colors: <Color>[Colors.green, Colors.red])),
              GaugeRange(startValue: 50, endValue: 60, color: Colors.red[600])
            ],
            pointers: <GaugePointer>[
              NeedlePointer(
                  value: 45,
                  enableDragging: true,
                  needleLength: 0.7,
                  needleEndWidth: 5,
                  needleColor: Colors.deepOrange,
                  knobStyle: KnobStyle(color: Colors.deepOrange))
            ],
            annotations: <GaugeAnnotation>[
              GaugeAnnotation(
                  widget: Container(
                    child: Text(
                      "x 100\nRPM",
                      style: TextStyle(
                          fontSize: 10,
                          fontWeight: FontWeight.bold,
                          fontFamily: "Raleway",
                          color: Colors.orange),
                    ),
                  ),
                  angle: 90,
                  positionFactor: 0.5)
            ])
      ]),
    );
  }
}