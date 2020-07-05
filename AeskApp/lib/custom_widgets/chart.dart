import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import 'package:provider/provider.dart';

class AeskChart extends StatefulWidget {
  //final List<CurrentData> graphData = List.generate(100, (index) => CurrentData(0,0), growable: true);

  //final List<CurrentData> x = List.generate(100, (index) => index, growable: true);

  //String _chartName;
  //AeskChart(this._chartName);

  @override
  _AeskChartState createState() => _AeskChartState();
}

class _AeskChartState extends State<AeskChart> {
  @override
  Widget build(BuildContext context) {
    double currentTime = 0;
    dynamic data;

    return Consumer<MqttAesk>(
      builder: (context, _, child) {
        //if (widget._chartName == "driverMotorTemp")
        //  data = AeskData.driver_motor_temperature_u8;
        //else if (widget._chartName == "driverDcBusVolt")
        //  data = AeskData.driver_dc_bus_voltage_f32;
        //else if (widget._chartName == "driverActualVelocity")
        //  data = AeskData.driver_actual_velocity_u8;
        //else if (widget._chartName == "bmsTemp") data = AeskData.bms_temp_u8;

        //graphData.add(CurrentData(currentTime, data));
        //currentTime += 0.5;
        //graphData.removeAt(0);

        return ListView(
          children: <Widget>[
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "driverPhaseA",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) =>
                          data.driver_phase_a_current_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "Torque",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) =>
                          data.driver_phase_b_current_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "DC BUS CUR",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) =>
                          data.driver_dc_bus_current_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "Driver ID G",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) => data.driver_id_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "Driver ID Q",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) => data.driver_iq_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "Driver VD G",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) => data.driver_vd_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "Driver VQ G",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) => data.driver_vq_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "BMS Bat Cons",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) => data.bms_bat_cons_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "BMS Bat Current",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) =>
                          data.bms_bat_current_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
            Container(
              padding: EdgeInsets.only(top: 10, bottom: 10),
              child: Card(
                child: SfCartesianChart(
                  title: ChartTitle(
                      text: "BMS Bat Volt",
                      textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
                  primaryXAxis: CategoryAxis(),
                  tooltipBehavior: TooltipBehavior(enable: true),
                  series: <ChartSeries>[
                    SplineSeries<graph_data, double>(
                      enableTooltip: true,
                      dataSource: AeskData.graphData_array,
                      yValueMapper: (graph_data data, _) => data.bms_bat_volt_g,
                      xValueMapper: (graph_data data, _) => data.time / 1000,
                      //name: widget._chartName,
                      splineType: SplineType.monotonic,
                    )
                  ],
                ),
              ),
            ),
          ],
        );
      },
    );
  }
}
