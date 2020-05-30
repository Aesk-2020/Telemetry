import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';

class AeskChart extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      padding: EdgeInsets.only(top: 40,bottom: 40),
      child: SfCartesianChart(
        title: ChartTitle(text: "Akım Grafiği",textStyle: ChartTextStyle(color: aeskBlue,fontSize: 15)),
        primaryXAxis: CategoryAxis(),
        tooltipBehavior: TooltipBehavior(enable: true),
        series: <ChartSeries>[
          SplineSeries<CurrentData,double>(
              enableTooltip: true,
              dataSource: [
                CurrentData(0,2.5),
                CurrentData(1,6),
                CurrentData(2,9),
                CurrentData(3,7),
                CurrentData(4,6),
                CurrentData(5,12),
                CurrentData(6,3),
              ],
              yValueMapper: (CurrentData data, _) => data.current,
              xValueMapper: (CurrentData data, _) => data.time,
              name: "Akım",
              splineType: SplineType.clamped
          )
        ],
      ),
    );
  }
}

class CurrentData{
  final double time;
  final double current;
  CurrentData(this.time,this.current);
}