import 'dart:async';
import 'dart:collection';
import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';
//import 'package:location/location.dart';
import 'package:provider/provider.dart';

class Konum extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => KonumState();
}

int counter = 1;
bool _showMapStyle = false;

class KonumState extends State<Konum> {
  Completer<GoogleMapController> _haritaHazirlayici = Completer();
  Map<MarkerId, Marker> _markers = Map<MarkerId, Marker>();
  Set<Circle> _circles = HashSet<Circle>();
  BitmapDescriptor _markerIcon;
  GoogleMapController _controller;

  @override
  void initState() {
    super.initState();
    _setMarkerIcon();
    _setCircles();
  }

  void _setCircles() {
    AeskData.gpsTracker_gps_latitude_f64 ??= 40.7435979;
    AeskData.gpsTracker_gps_longtitude_f64 ??= 29.7832885;
    _circles.add(
      Circle(
          circleId: CircleId("0"),
          center: LatLng(AeskData.gpsTracker_gps_latitude_f64,
              AeskData.gpsTracker_gps_longtitude_f64),
          radius: 100,
          strokeWidth: 2,
          fillColor: Color.fromRGBO(102, 51, 153, .5)),
    );
  }

  void _setMarkerIcon() async {
    _markerIcon = await BitmapDescriptor.fromAssetImage(
        ImageConfiguration(), 'assets/images/driving_pin50.png');
  }

  /*void _toggleMapStyle() async {
    //String style = await DefaultAssetBundle.of(context).loadString('assets/map_style.json');
    if (_showMapStyle) {
      _controller.setMapStyle(null);
    } else {
      _controller.setMapStyle(Utils.mapStyles);
    }
  }*/

  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Scaffold(
        body: Consumer<MqttAesk>(
          builder: (context, _, child) {
            add();
            return GoogleMap(
              mapType: MapType.satellite,
              markers: Set<Marker>.of(_markers.values),
              //scrollGesturesEnabled: false,
              //zoomControlsEnabled: false,
              //zoomGesturesEnabled: false,
              //circles: _circles,
              initialCameraPosition: CameraPosition(
                target: LatLng(40.7435979, 29.7832885),
                zoom: 16.3,
              ),
              onMapCreated: (GoogleMapController controller) {
                _controller = controller;
                _haritaHazirlayici.complete(controller);
                //AeskData.gpsTracker_gps_latitude_f64 ??= 40.7435979;
                //AeskData.gpsTracker_gps_longtitude_f64 ??= 29.7832885;
              },
            );
          },
        ),
        /*floatingActionButton: FloatingActionButton(
          tooltip: 'Increment',
          child: Icon(Icons.map),
          onPressed: () {
            setState(() {
              _showMapStyle = !_showMapStyle;
            },
            );
            //_toggleMapStyle();
          },
        ),*/
      ),
    );
  }

  add() {
    AeskData.gpsTracker_gps_latitude_f64 ??= 40.7435979;
    AeskData.gpsTracker_gps_longtitude_f64 ??= 29.7832885;
    MarkerId yeniId = MarkerId("$counter");
    counter++;
    Marker yeni = Marker(
      markerId: MarkerId('araba'),
      position: LatLng(AeskData.gpsTracker_gps_latitude_f64,
          AeskData.gpsTracker_gps_longtitude_f64),
      icon: _markerIcon,
    );
    _markers[yeniId] = yeni;
  }

  _add() {
    final String markerIdVal = 'marker_id_$counter';
    final MarkerId markerId = MarkerId(markerIdVal);
    counter++;

    final Marker marker = Marker(
      markerId: markerId,
      position: LatLng(
        AeskData.gpsTracker_gps_latitude_f64,
        AeskData.gpsTracker_gps_longtitude_f64,
      ),
      infoWindow: InfoWindow(title: markerIdVal, snippet: '*'),
      onTap: () {},
    );

    setState(
      () {
        _markers[markerId] = marker;
      },
    );
  }
}

/*class Utils {
  static String mapStyles = '''[
  {
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#242f3e"
      }
    ]
  },
  {
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#746855"
      }
    ]
  },
  {
    "elementType": "labels.text.stroke",
    "stylers": [
      {
        "color": "#242f3e"
      }
    ]
  },
  {
    "featureType": "administrative.locality",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#d59563"
      }
    ]
  },
  {
    "featureType": "poi",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#d59563"
      }
    ]
  },
  {
    "featureType": "poi.park",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#263c3f"
      }
    ]
  },
  {
    "featureType": "poi.park",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#6b9a76"
      }
    ]
  },
  {
    "featureType": "road",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#38414e"
      }
    ]
  },
  {
    "featureType": "road",
    "elementType": "geometry.stroke",
    "stylers": [
      {
        "color": "#212a37"
      }
    ]
  },
  {
    "featureType": "road",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#9ca5b3"
      }
    ]
  },
  {
    "featureType": "road.highway",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#746855"
      }
    ]
  },
  {
    "featureType": "road.highway",
    "elementType": "geometry.stroke",
    "stylers": [
      {
        "color": "#1f2835"
      }
    ]
  },
  {
    "featureType": "road.highway",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#f3d19c"
      }
    ]
  },
  {
    "featureType": "transit",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#2f3948"
      }
    ]
  },
  {
    "featureType": "transit.station",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#d59563"
      }
    ]
  },
  {
    "featureType": "water",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#17263c"
      }
    ]
  },
  {
    "featureType": "water",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#515c6d"
      }
    ]
  },
  {
    "featureType": "water",
    "elementType": "labels.text.stroke",
    "stylers": [
      {
        "color": "#17263c"
      }
    ]
  }
]''';
}*/

class Utils {
  static String mapStyles = '''[
  {
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#242f3e"
      }
    ]
  },
  {
    "elementType": "labels",
    "stylers": [
      {
        "visibility": "off"
      }
    ]
  },
  {
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#746855"
      }
    ]
  },
  {
    "elementType": "labels.text.stroke",
    "stylers": [
      {
        "color": "#242f3e"
      }
    ]
  },
  {
    "featureType": "administrative",
    "elementType": "geometry",
    "stylers": [
      {
        "visibility": "off"
      }
    ]
  },
  {
    "featureType": "administrative.land_parcel",
    "stylers": [
      {
        "visibility": "off"
      }
    ]
  },
  {
    "featureType": "administrative.locality",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#d59563"
      }
    ]
  },
  {
    "featureType": "administrative.neighborhood",
    "stylers": [
      {
        "visibility": "off"
      }
    ]
  },
  {
    "featureType": "poi",
    "stylers": [
      {
        "visibility": "off"
      }
    ]
  },
  {
    "featureType": "poi",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#d59563"
      }
    ]
  },
  {
    "featureType": "poi.park",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#263c3f"
      }
    ]
  },
  {
    "featureType": "poi.park",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#6b9a76"
      }
    ]
  },
  {
    "featureType": "road",
    "stylers": [
      {
        "visibility": "off"
      }
    ]
  },
  {
    "featureType": "road",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#38414e"
      }
    ]
  },
  {
    "featureType": "road",
    "elementType": "geometry.stroke",
    "stylers": [
      {
        "color": "#212a37"
      }
    ]
  },
  {
    "featureType": "road",
    "elementType": "labels.icon",
    "stylers": [
      {
        "visibility": "off"
      }
    ]
  },
  {
    "featureType": "road",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#9ca5b3"
      }
    ]
  },
  {
    "featureType": "road.highway",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#746855"
      }
    ]
  },
  {
    "featureType": "road.highway",
    "elementType": "geometry.stroke",
    "stylers": [
      {
        "color": "#1f2835"
      }
    ]
  },
  {
    "featureType": "road.highway",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#f3d19c"
      }
    ]
  },
  {
    "featureType": "transit",
    "stylers": [
      {
        "visibility": "off"
      }
    ]
  },
  {
    "featureType": "transit",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#2f3948"
      }
    ]
  },
  {
    "featureType": "transit.station",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#d59563"
      }
    ]
  },
  {
    "featureType": "water",
    "elementType": "geometry",
    "stylers": [
      {
        "color": "#17263c"
      }
    ]
  },
  {
    "featureType": "water",
    "elementType": "labels.text.fill",
    "stylers": [
      {
        "color": "#515c6d"
      }
    ]
  },
  {
    "featureType": "water",
    "elementType": "labels.text.stroke",
    "stylers": [
      {
        "color": "#17263c"
      }
    ]
  }
]''';
}