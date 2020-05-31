import 'dart:typed_data';

import 'package:flutter/foundation.dart';

class AeskData extends ChangeNotifier{

 static var vcu_wake_up_u8;
 static var vcu_drive_command_u8;
 static var vcu_set_velocity_u8;
 static var driver_phase_a_current_f32;//100
 static var driver_phase_b_current_f32;//100
 static var driver_dc_bus_current_f32;//100
 static var driver_dc_bus_voltage_f32;//10
 static var driver_id_f32;//100
 static var driver_iq_f32;//100
 static var driver_vd_f32;//100
 static var driver_vq_f32;//100
 static var driver_drive_status_u8;
 static var driver_driver_error_u8;
 static var driver_odometer_u32;
 static var driver_motor_temperature_u8;
 static var driver_actual_velocity_u8;
 static var bms_bat_volt_f32;//10
 static var bms_bat_current_f32;//100
 static var bms_bat_cons_f32;//10
 static var bms_soc_f32;//100
 static var bms_bms_error_u8;
 static var bms_dc_bus_state_u8;
 static var bms_worst_cell_voltage_f32;//10
 static var bms_worst_cell_address_u8;
 static var bms_temp_u8;
 static var gpsTracker_gps_latitude_f64;  //1000000
 static var gpsTracker_gps_longtitude_f64;
 static var gpsTracker_gps_velocity_u8;
 static var gpsTracker_gps_sattelite_number_u8;
 static var gpsTracker_gps_efficiency_u8;


//EMS
/*
var eys_bat_current_int16;//10
var eys_fc_current_int16;//10
var eys_out_current_int16;//10
var eys_bat_volt_uint16;//10
var eys_out_volt_uint16;//10
var eys_bat_cons_uint16;//10
var eys_fc_cons_uint16;//10
var eys_fc_lt_cons_uint16;//10
var eys_out_cons_uint16;//10
var eys_penalty_int8;//10
var eys_bat_soc_uint16;//100
var eys_temp_uint8;
var eys_error_uint8;
*/
  static var MQTT_counter_int32;

  AeskData(ByteData message,Endian myEndian){

    int _startIndex =0;
    vcu_wake_up_u8 = message.getUint8(_startIndex);
    _startIndex++;

    vcu_drive_command_u8 = message.getUint8(_startIndex);
    _startIndex++;

    vcu_set_velocity_u8 = message.getUint8(_startIndex);
    _startIndex++;

    driver_phase_a_current_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex +=2;

    driver_phase_b_current_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_dc_bus_current_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_dc_bus_voltage_f32 = message.getUint16(_startIndex,myEndian)/10;
    _startIndex+=2;

    driver_id_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_iq_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_vd_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_vq_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    driver_drive_status_u8 = message.getUint8(_startIndex);
    _startIndex++;

    driver_driver_error_u8 = message.getUint8(_startIndex);
    _startIndex++;

    driver_odometer_u32 = message.getUint32(_startIndex,myEndian);
    _startIndex+=4;

    driver_motor_temperature_u8 = message.getUint8(_startIndex);
    _startIndex++;

    driver_actual_velocity_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_bat_volt_f32 = message.getUint16(_startIndex,myEndian)/10;
    _startIndex+=2;

    bms_bat_current_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    bms_bat_cons_f32 = message.getUint16(_startIndex,myEndian)/10;
    _startIndex+=2;

    bms_bat_cons_f32 = message.getUint16(_startIndex,myEndian)/100;
    _startIndex+=2;

    bms_soc_f32 = message.getUint16(_startIndex,myEndian);
    _startIndex+=2;

    bms_bms_error_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_dc_bus_state_u8 = message.getUint8(_startIndex)/10;
    _startIndex++;

    bms_worst_cell_voltage_f32 = message.getUint16(_startIndex,myEndian);
    _startIndex+=2;

    bms_worst_cell_address_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_temp_u8 = message.getUint8(_startIndex);
    _startIndex++;

    gpsTracker_gps_latitude_f64 = message.getUint32(_startIndex,myEndian)/1000000;
    _startIndex+=4;

    gpsTracker_gps_longtitude_f64 = message.getUint32(_startIndex,myEndian)/1000000;
    _startIndex+=4;

    gpsTracker_gps_velocity_u8 = message.getUint8(_startIndex);
    _startIndex++;

    gpsTracker_gps_sattelite_number_u8 = message.getUint8(_startIndex);
    _startIndex++;

    gpsTracker_gps_efficiency_u8 = message.getUint8(_startIndex);
    _startIndex++;

    MQTT_counter_int32 = message.getInt32(_startIndex,myEndian);
    _startIndex+=4;

    notifyListeners();
  }
}