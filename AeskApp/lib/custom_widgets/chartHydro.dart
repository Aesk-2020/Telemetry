import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:aeskapp/pages/Custom.dart';
import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import 'package:provider/provider.dart';

import 'aesk_widgets.dart';



class AeskChartHydro extends StatefulWidget {
  @override
  _AeskChartHydroState createState() => _AeskChartHydroState();
}
class _AeskChartHydroState extends State<AeskChartHydro> {
  double currentTime = 0;
  dynamic data;
  static List<String> currentgraph = List.filled(1, null,growable: true);
  static List<String> graphList = ["driverPhaseA","driverPhaseB","dcBusCur","driverIdG","driverIdQ","driverVdG","driverVqG","bmsBatCons","bmsBatCur","bmsBatVolt","eysBatCons","eysBatCur","eysBatSoc","eysBatVolt","eysFcCons","eysFcCur","eysFcLtCons","eysFcVolt","eysOutCons","eysOutCur","eysOutVolt","eysPenalty","eysSharingRatio","eysTemp"];

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
                    print(currentgraph);
                    currentgraph.removeAt(index);
                    print(currentgraph);
                    graphList.add("driverPhaseA");
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
                    graphList.add("driverPhaseB");
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
                    graphList.add("dcBusCur");
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
                    graphList.add("driverIdG");
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
                    graphList.add("driverIdQ");
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
                    graphList.add("driverVdG");
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
                    graphList.add("driverVqG");
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
                    graphList.add("bmsBatCons");
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
                    graphList.add("bmsBatCur");
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
                    graphList.add("bmsBatVolt");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysBatCons":
        return Stack(
          children: <Widget>[
            eysBatCons(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysBatCons");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysBatCur":
        return Stack(
          children: <Widget>[
            eysBatCur(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysBatCur");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysBatSoc":
        return Stack(
          children: <Widget>[
            eysBatSoc(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysBatSoc");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysBatVolt":
        return Stack(
          children: <Widget>[
            eysBatVolt(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysBatVolt");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysFcCons":
        return Stack(
          children: <Widget>[
            eysFcCons(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysFcCons");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysFcCur":
        return Stack(
          children: <Widget>[
            eysFcCur(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysFcCur");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysFcLtCons":
        return Stack(
          children: <Widget>[
            eysFcLtCons(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysFcLtCons");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysFcVolt":
        return Stack(
          children: <Widget>[
            eysFcVolt(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysFcVolt");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysOutCons":
        return Stack(
          children: <Widget>[
            eysOutCons(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysOutCons");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysOutCur":
        return Stack(
          children: <Widget>[
            eysOutCur(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysOutCur");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysOutVolt":
        return Stack(
          children: <Widget>[
            eysOutVolt(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysOutVolt");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysPenalty":
        return Stack(
          children: <Widget>[
            eysPenalty(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysPenalty");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysSharingRatio":
        return Stack(
          children: <Widget>[
            eysSharingRatio(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysSharingRatio");
                  });
                },
              ),
            )
          ],
        );
        break;
      case "eysTemp":
        return Stack(
          children: <Widget>[
            eysTemp(),
            Positioned(
              bottom: 5,
              left: scale.size.width/2.22,
              child: IconButton(
                icon: Icon(Icons.delete),
                onPressed: () {
                  setState(() {
                    currentgraph.removeAt(index);
                    graphList.add("eysTemp");
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
      default :
        return SizedBox(height: 0,);
        break;
    }


  }
  Widget modifiedExpansionTile(int index) {
    return ExpansionTile(
      title: myText("Grafikler", 25, Theme.of(context).textTheme.headline1.color, FontWeight.bold),
      leading: Icon(Icons.graphic_eq),
      backgroundColor: Theme.of(context).backgroundColor,
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

Widget eysBatCons(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Bat Cons",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_bat_cons_g,
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
Widget eysBatCur(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Bat Cur",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_bat_current_g,
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
Widget eysBatSoc(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Bat Soc",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_bat_soc_g,
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
}Widget eysBatVolt(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Bat Volt",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_bat_volt_g,
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
}Widget eysFcCons(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS FC Cons",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_fc_cons_g,
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
}Widget eysFcCur(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS FC Cur",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_fc_current_g,
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
}Widget eysFcLtCons(){
  return  Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS FC LT Cons",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_fc_lt_cons_g,
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
}Widget eysFcVolt(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS FC Volt",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_fc_volt_g,
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
Widget eysOutCons(){
  return  Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Out Cons",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_out_cons_g,
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
Widget eysOutCur(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Out Cur",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_out_current_g,
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
Widget eysOutVolt(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Out Volt",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_out_volt_g,
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
Widget eysPenalty(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Penalty",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_penalty_g,
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
Widget eysSharingRatio(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Sharing Ratio",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_sharing_ratio,
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
Widget eysTemp(){
  return Consumer<MqttAesk>(
    builder: (context, _, child){
      return Container(
        padding: EdgeInsets.only(top: 10, bottom: 10),
        child: Card(
          child: Padding(
            padding: const EdgeInsets.only(bottom: 25),
            child: SfCartesianChart(
              title: ChartTitle(
                  text: "EYS Temp",
                  textStyle: ChartTextStyle(color: aeskBlue, fontSize: 15)),
              primaryXAxis: CategoryAxis(),
              tooltipBehavior: TooltipBehavior(enable: true),
              series: <ChartSeries>[
                SplineSeries<graph_data, double>(
                  enableTooltip: true,
                  dataSource: AeskData.graphData_array,
                  yValueMapper: (graph_data data, _) => data.eys_temp_g,
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