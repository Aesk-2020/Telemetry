import 'dart:async';
import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/classes/aeskData.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:flutter/material.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';
import 'package:provider/provider.dart';

class Konum extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => KonumState();
}

int counter = 1;

class KonumState extends State<Konum> {
  Completer<GoogleMapController> _haritaHazirlayici = Completer();
  static Map<MarkerId, Marker> _markers = Map<MarkerId, Marker>();

  @override
  Widget build(BuildContext context) {
    return aeskScaffold(
      context: context,
      myBody: Consumer<MqttAesk>(builder: (context, _, child) {
        add();
        return GoogleMap(
          mapType: MapType.satellite,
          markers: Set<Marker>.of(_markers.values),
          scrollGesturesEnabled: false,
          zoomControlsEnabled: false,
          zoomGesturesEnabled: false,
          mapToolbarEnabled: false,
          buildingsEnabled: true,
          initialCameraPosition: CameraPosition(
            target: LatLng(40.7435979, 29.7832885),
            zoom: 16.3,
          ),
          onMapCreated: (GoogleMapController controller) {
            _haritaHazirlayici.complete(controller);
            //AeskData.gpsTracker_gps_latitude_f64 ??= 40.7435979;
            //AeskData.gpsTracker_gps_longtitude_f64 ??= 29.7832885;
            MarkerId isaretler = MarkerId('Merkez');
            Marker isaret = Marker(
              markerId: MarkerId('baslangic'),
              position: LatLng(40.7435979, 29.7832885),
              visible: false,
              infoWindow: InfoWindow(
                title: 'AESK',
                snippet: 'Alternatif Enerjili Sistemler Kulübü',
              ),
            );
            _markers[isaretler] = isaret;
            //final String markerIdVal = 'marker_id_$markerIdCounter';
            //konummarker.markerset;
          },
        );
      }),
    );
  }

  void add() {
    MarkerId yeniId = MarkerId("$counter");
    counter++;
    Marker yeni = Marker(
      markerId: MarkerId('araba'),
      position: LatLng(AeskData.gpsTracker_gps_latitude_f64,
          AeskData.gpsTracker_gps_longtitude_f64),
    );
    _markers[yeniId] = yeni;
  }

  void _add() {
    final String markerIdVal = 'marker_id_$counter';
    final MarkerId markerId = MarkerId(markerIdVal);
    counter++;

    AeskData.gpsTracker_gps_longtitude_f64 ??= 29.7832885;
    AeskData.gpsTracker_gps_latitude_f64 ??= 40.7435979;

    final Marker marker = Marker(
      markerId: markerId,
      position: LatLng(
        AeskData.gpsTracker_gps_latitude_f64,
        AeskData.gpsTracker_gps_longtitude_f64,
      ),
      infoWindow: InfoWindow(title: markerIdVal, snippet: '*'),
    );
    _markers[markerId] = marker;
  }
}
