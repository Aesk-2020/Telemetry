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

  final List<CurrentData> graphData = List.generate(100, (index) => CurrentData(0,0), growable: true);
  String _chartName;
  AeskChart(this._chartName);

  @override
  Widget build(BuildContext context) {

    double currentTime = 0 ;
    dynamic data;

    return Consumer<MqttAesk>(
      builder: (context, _, child){
        if(_chartName == "driverPhaseA") data = AeskData.driver_phase_a_current_f32;
        else if(_chartName == "driverPhaseB") data = AeskData.driver_phase_b_current_f32;
        else if(_chartName == "driverMotorTemp") data = AeskData.driver_motor_temperature_u8;
        else if(_chartName == "driverDcBusCurrent") data =AeskData.driver_dc_bus_current_f32;
        else if(_chartName == "driverDcBusVolt") data =  AeskData.driver_dc_bus_voltage_f32;
        else if(_chartName == "driverActualVelocity") data = AeskData.driver_actual_velocity_u8;
        else if(_chartName == "bmsBatVolt") data = AeskData.bms_bat_volt_f32;
        else if(_chartName == "bmsBatCurrent") data = AeskData.bms_bat_current_f32;
        else if(_chartName == "bmsTemp") data = AeskData.bms_temp_u8;

        graphData.add(CurrentData(currentTime, data));
        currentTime += 0.5;
        graphData.removeAt(0);

        return Container(
          padding: EdgeInsets.only(top: 40,bottom: 40),
          child: SfCartesianChart(
            title: ChartTitle(text: _chartName, textStyle: ChartTextStyle(color: aeskBlue,fontSize: 15)),
            primaryXAxis: CategoryAxis(),
            tooltipBehavior: TooltipBehavior(enable: true),
            series: <ChartSeries>[
              SplineSeries<CurrentData,double>(
                  enableTooltip: true,
                  dataSource: graphData,
                  yValueMapper: (CurrentData data, _) => data.current,
                  xValueMapper: (CurrentData data, _) => data.time,

                  name: _chartName,
                  splineType: SplineType.monotonic,
              )
            ],
          ),
        );
      }
    );
  }
}
