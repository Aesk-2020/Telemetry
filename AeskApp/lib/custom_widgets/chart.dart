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
  static List<String> graphList = ["driverPhaseA","driverPhaseB","dcBusCur","driverIdG","driverIdQ","driverVdG","driverVqG","bmsBatCons","bmsBatCur","bmsBatVolt"];

  Widget graphAdder(String content, int index){
    final scale = MediaQuery.of(context);
    switch(content){
      case "driverPhaseA":
        return Stack(
          children: <Widget>[
            driverPhaseA(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.insert(0,"driverPhaseA");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "driverPhaseB":
        return Stack(
          children: <Widget>[
            driverPhaseB(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.insert(1,"driverPhaseB");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "dcBusCur":
        return Stack(
          children: <Widget>[
            dcBusCur(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.insert(2,"dcBusCur");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "driverIdG":
        return Stack(
          children: <Widget>[
            driverIdG(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.insert(3,"driverIdG");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "driverIdQ":
        return Stack(
          children: <Widget>[
            driverIdQ(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.insert(4,"driverIdQ");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "driverVdG":
        return Stack(
          children: <Widget>[
            driverVdG(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.insert(5,"driverVdG");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "driverVqG":
        return Stack(
          children: <Widget>[
            driverVqG(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.insert(6,"driverVqG");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "bmsBatCons":
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
                    graphList.insert(7,"bmsBatCons");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "bmsBatCur":
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
                    graphList.insert(8,"bmsBatCur");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "bmsBatVolt":
        return Stack(
          children: <Widget>[
            bmsBatVolt(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.insert(9,"bmsBatVolt");
                  });
                },
              ),
            )
          ],
        );
        break;
      default:
        return modifiedExpansionTile(index);
        break;
    }


  }
  Widget modifiedExpansionTile(int index) {
    return ExpansionTile(
      title: Center(child: myText("     Grafikler", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold)),
      backgroundColor: Theme.of(context).backgroundColor,
      children: graphList.map((tileName) {
        if(tileName == "") return SizedBox(height: 0,);
        return FlatButton(
          child: myText(tileName, 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
          onPressed: (){
            setState(() {
              currentgraph.insert(index, tileName);
              graphList.remove(tileName);
            });
          },
        );
      }).toList(),
    );
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
Widget driverPhaseA(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
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
      );
    },
  );
}
Widget driverPhaseB(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "driverPhaseB",
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
      );
    },
  );
}
Widget dcBusCur(){
  return  Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
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
      );
    },
  );
}
Widget driverIdG(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
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
      );
    },
  );
}
Widget driverIdQ(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
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
      );
    },
  );
}
Widget driverVdG(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
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
      );
    },
  );
}
Widget driverVqG(){
  return  Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
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
Widget bmsBatVolt() {
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
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
      );
    },
  );
}
