import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import 'package:provider/provider.dart';

class CurrentData{
  final double time;
  final double current;
  CurrentData(this.time,this.current);
}

class AeskChart extends StatelessWidget {

  final List<CurrentData> graphData = List.generate(50, (index) => CurrentData(0,0), growable: true);

  @override
  Widget build(BuildContext context) {

    double currentTime = 0 ;

    return Consumer<MqttAesk>(
      builder: (context, _, child){

        graphData.add(CurrentData(currentTime, AeskData.driver_phase_a_current_f32));
        currentTime += 0.5;

        if(graphData.length > 50)
          graphData.removeRange(0, 4);

        return Container(
          padding: EdgeInsets.only(top: 40,bottom: 40),
          child: SfCartesianChart(
            title: ChartTitle(text: "Akım Grafiği",textStyle: ChartTextStyle(color: aeskBlue,fontSize: 15)),
            primaryXAxis: CategoryAxis(),
            tooltipBehavior: TooltipBehavior(enable: true),
            series: <ChartSeries>[
              SplineSeries<CurrentData,double>(
                  enableTooltip: true,
                  dataSource: graphData,
                  yValueMapper: (CurrentData data, _) => data.current,
                  xValueMapper: (CurrentData data, _) => data.time,
                  initialSelectedDataIndexes: [0,10,20,30,40],

                  name: "Akım",
                  splineType: SplineType.clamped
              )
            ],
          ),
        );
      }
    );
  }
}
