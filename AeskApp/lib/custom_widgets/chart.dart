import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:aeskapp/pages/Custom.dart';
import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import 'package:provider/provider.dart';

import 'aesk_widgets.dart';



class AeskChart extends StatefulWidget {
  //final List<CurrentData> graphData = List.generate(100, (index) => CurrentData(0,0), growable: true);

  //final List<CurrentData> x = List.generate(100, (index) => index, growable: true);

  //String _chartName;
  //AeskChart(this._chartName);

  @override
  _AeskChartState createState() => _AeskChartState();
}

class _AeskChartState extends State<AeskChart> {
  double currentTime = 0;
  dynamic data;
  static List<String> currentgraph = List.filled(1, null,growable: true);
  static List<String> graphList = ["DC Bus Current", "Set-Act ID", "Set-Act IQ", "Set-Act Torque", "Set-Act Velocity", "BMS Bat Cons", "BMS Bat Cur"];

  Widget graphAdder(String content, int index){
    final scale = MediaQuery.of(context);
    switch(content){
      case "DC Bus Current":
        return Stack(
          children: <Widget>[
            dcBusCurrent(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("DC Bus Current");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "Set-Act ID":
        return Stack(
          children: <Widget>[
            setActId(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("Set-Act ID");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "Set-Act IQ":
        return Stack(
          children: <Widget>[
            setActIq(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("Set-Act IQ");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "Set-Act Torque":
        return Stack(
          children: <Widget>[
            setActTorque(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("Set-Act Torque");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "Set-Act Velocity":
        return Stack(
          children: <Widget>[
            setActVelocity(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("Set-Act Velocity");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "BMS Bat Cons":
        return Stack(
          children: <Widget>[
            bmsBatCons(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("BMS Bat Cons");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "BMS Bat Cur":
        return Stack(
          children: <Widget>[
            bmsBatCur(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("BMS Bat Cur");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "list":
        return (graphList.length == 0 ? SizedBox(height: 0,) : modifiedExpansionTile(currentgraph.length));
        break;
      default:
        return SizedBox(height: 0);
        break;
    }


  }
  Widget modifiedExpansionTile(int index) {
    return ExpansionTile(
      title: myText("Grafikler", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
      backgroundColor: Theme.of(context).backgroundColor,
      leading: Icon(Icons.graphic_eq),
      children: graphList.map((tileName) {
        return GestureDetector(
          child: Container(
            alignment: Alignment.centerLeft,
            padding: EdgeInsets.fromLTRB(15, 5, 5, 5),
            child: Row(
              children: <Widget>[
                Icon(Icons.add),
                SizedBox(width: 15,),
                myText(tileName, 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
              ],
            ),
          ),
          onTap: (){
            setState(() {
              currentgraph.insert(index, tileName);
              graphList.remove(tileName);
            });
          },
        );
      }).toList(),
    );
  }
/*
FlatButton(
          child: myText(tileName, 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
          onPressed: (){
            setState(() {
              currentgraph.insert(index, tileName);
              graphList.remove(tileName);
            });
          },
        )
*/
  @override
  void initState() {
    currentgraph[0] = "list";
    super.initState();
  }
  @override
  Widget build(BuildContext context) {
    return CustomScrollView(
      slivers: <Widget>[
        SliverSafeArea(
          sliver: SliverList(
            delegate: SliverChildBuilderDelegate(
                (context, int index){
                  return graphAdder(currentgraph[index],index);
                },
              childCount: currentgraph.length,
            ),
          ),
        ),
      ],
    );
  }
}
Widget dcBusCurrent(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "DC Bus Current (A)",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) =>
                  data.driver_idc_s16_g,
                  xValueMapper: (graph_data data, _) => data.time / 1000,
                  //name: widget._chartName,
                  splineType: SplineType.monotonic,
                )
              ],
            ),
          ),
        ),
      );
    },
  );
}
Widget setActId(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "Set-Act ID",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) =>
                  data.driver_set_id_s16_g,
                  xValueMapper: (graph_data data, _) => data.time / 1000,
                  //name: widget._chartName,
                  splineType: SplineType.monotonic,
                ),
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) =>
                  data.driver_act_id_s16_g,
                  xValueMapper: (graph_data data, _) => data.time / 1000,
                  //name: widget._chartName,
                  splineType: SplineType.monotonic,
                )
              ],
            ),
          ),
        ),
      );
    },
  );
}
Widget setActIq(){
  return  Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "Set-Act IQ",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) =>
                  data.driver_set_iq_s16_g,
                  xValueMapper: (graph_data data, _) => data.time / 1000,
                  //name: widget._chartName,
                  splineType: SplineType.monotonic,
                ),
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) =>
                  data.driver_act_iq_s16_g,
                  xValueMapper: (graph_data data, _) => data.time / 1000,
                  //name: widget._chartName,
                  splineType: SplineType.monotonic,
                )
              ],
            ),
          ),
        ),
      );
    },
  );
}
Widget setActTorque(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "Set-Act Torque",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.driver_set_torque_s16_g,
                  xValueMapper: (graph_data data, _) => data.time / 1000,
                  //name: widget._chartName,
                  splineType: SplineType.monotonic,
                ),
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.driver_acttorque_s8_g,
                  xValueMapper: (graph_data data, _) => data.time / 1000,
                  //name: widget._chartName,
                  splineType: SplineType.monotonic,
                )
              ],
            ),
          ),
        ),
      );
    },
  );
}
Widget setActVelocity(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "Set-Act Velocity",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.vcu_speed_set_rpm_s16_g,
                  xValueMapper: (graph_data data, _) => data.time / 1000,
                  //name: widget._chartName,
                  splineType: SplineType.monotonic,
                ),
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.driver_actspeed_s16_g,
                  xValueMapper: (graph_data data, _) => data.time / 1000,
                  //name: widget._chartName,
                  splineType: SplineType.monotonic,
                )
              ],
            ),
          ),
        ),
      );
    },
  );
}
Widget bmsBatCons(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
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
      );
    },
  );
}
Widget bmsBatCur(){
  return  Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
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
      );
    },
  );
}
