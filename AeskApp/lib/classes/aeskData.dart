import 'dart:typed_data';

import 'package:flutter/foundation.dart';

class graph_data{
  var driver_phase_a_current_g;
  var driver_phase_b_current_g;
  var driver_dc_bus_current_g;
  var driver_id_g;
  var driver_iq_g;
  var driver_vd_g;
  var driver_vq_g;
  var bms_bat_volt_g;
  var bms_bat_current_g;
  var bms_bat_cons_g;
  double time;
  graph_data(this.driver_phase_a_current_g,
      this.driver_phase_b_current_g,
      this.driver_dc_bus_current_g,
      this.driver_id_g,
      this.driver_iq_g,
      this.driver_vd_g,
      this.driver_vq_g,
      this.bms_bat_volt_g,
      this.bms_bat_current_g,
      this.bms_bat_cons_g,
      this.time
      );
}


int i;

class AeskData extends ChangeNotifier{

  static var vcu_can_error_u8;
  static var vcu_wake_up_u8;
  static var vcu_drive_command_u8;
  static var vcu_set_velocity_u8              = 0;
  static var driver_phase_a_current_f32;//100
  static var driver_phase_b_current_f32;//100
  static var driver_dc_bus_current_f32;//100
  static var driver_dc_bus_voltage_f32;//10
  static var driver_id_f32;//100
  static var driver_iq_f32;//100
  static var driver_vd_f32;//100 iarms
  static var driver_vq_f32;//100 torque?
  static var driver_drive_status_u8;

  static bool drive_status_direction_u1 = false; //1 forward 0 reverse
  static bool drive_status_brake_u1     = false; //1 on 0 off
  static bool drive_status_ignition_u1  = false; //1 on 0 off

  static var driver_driver_error_u8;

  static bool driver_error_ZPC_u1             = false;
  static bool driver_error_PWM_u1             = false;
  static bool driver_error_DC_bara_u1         = false;
  static bool driver_error_temprature_u1      = false;
  static bool driver_error_DC_bara_current_u1 = false;
  static bool driver_error_WakeUp_u1          = false;

  static var driver_odometer_u32;
  static var driver_motor_temperature_u8;
  static var driver_actual_velocity_u8        = 0;
  static var bms_bat_volt_f32;//10
  static var bms_bat_current_f32;//100
  static var bms_bat_cons_f32;//10
  static var bms_soc_f32;//100
  static var bms_bms_error_u8;

  static bool bms_error_high_voltage_u1  = false;
  static bool bms_error_low_voltage_u1   = false;
  static bool bms_error_high_temp_u1     = false;
  static bool bms_error_communication_u1 = false;
  static bool bms_error_over_current_u1  = false;
  static bool bms_error_fatal_u1         = false;
  static bool bms_error_isolation_u1     = false;

  static var bms_dc_bus_state_u8;

  static bool bms_state_precharge_u1     = false;
  static bool bms_state_discharge_u1     = false;
  static bool bms_state_dcbus_ready_u1   = false;
  static bool bms_state_charge_u1        = false;

  static var bms_worst_cell_voltage_f32;//10
  static var bms_worst_cell_address_u8;
  static var bms_temp_u8;
  static var bms_power_f32;
  static var gpsTracker_gps_latitude_f64;  //1000000
  static var gpsTracker_gps_longtitude_f64;
  static var gpsTracker_gps_velocity_u8;
  static var gpsTracker_gps_sattelite_number_u8;
  static var gpsTracker_gps_efficiency_u8;
//bms cells eklenecek liste halinde

  static double x_time=0;
  static var ping = 0;

  static List<graph_data> graphData_array = List.generate(100, (index) => graph_data(0,0,0,0,0,0,0,0,0,0,0), growable: false);
  static Uint8List battery_cells = List.generate(28, (index) => 0);



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
//threadlamamız gerekecekse burayı threadlayacaz
  AeskData(ByteData message,Endian myEndian){

    int _startIndex = 0;

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

    bms_bat_volt_f32 = message.getUint16(_startIndex,myEndian)/100;
    _startIndex+=2;

    bms_bat_current_f32 = message.getInt16(_startIndex,myEndian)/100;
    _startIndex+=2;

    bms_bat_cons_f32 = message.getUint16(_startIndex,myEndian)/10;
    _startIndex+=2;

    bms_soc_f32 = message.getUint16(_startIndex,myEndian)/100;
    _startIndex+=2;

    bms_bms_error_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_dc_bus_state_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_worst_cell_voltage_f32 = message.getUint16(_startIndex,myEndian)/10;
    _startIndex+=2;

    bms_worst_cell_address_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_temp_u8 = message.getUint8(_startIndex);
    _startIndex++;

    bms_power_f32 = bms_bat_current_f32 * bms_bat_volt_f32;

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

    /*for(int i = 0; i<28; i++){
      battery_cells[i] = message.getUint8(_startIndex);
      _startIndex++;
    }*/

    vcu_can_error_u8 = message.getUint8(_startIndex);
    _startIndex++;
    print(vcu_can_error_u8);

    MQTT_counter_int32 = message.getInt32(_startIndex,myEndian);
    _startIndex+=4;



    drive_status_direction_u1 = ((driver_drive_status_u8 & 1) == 1) ? true : false;
    drive_status_brake_u1 = (((driver_drive_status_u8 >> 1) & 1) == 1) ? true : false;
    drive_status_ignition_u1 = (((driver_drive_status_u8 >> 2) & 1) == 1) ? true : false;

    driver_error_ZPC_u1             = ((driver_driver_error_u8 & 1) == 1) ? true : false;
    driver_error_PWM_u1             = (((driver_driver_error_u8 >> 1) & 1) == 1) ? true : false;
    driver_error_DC_bara_u1         = (((driver_driver_error_u8 >> 2) & 1) == 1) ? true : false;
    driver_error_temprature_u1      = (((driver_driver_error_u8 >> 3) & 1) == 1) ? true : false;
    driver_error_DC_bara_current_u1 = (((driver_driver_error_u8 >> 4) & 1) == 1) ? true : false;
    driver_error_WakeUp_u1          = (((driver_driver_error_u8 >> 5) & 1) == 1) ? true : false;

    bms_state_precharge_u1    = ((bms_dc_bus_state_u8 & 1) == 1) ? true : false;
    bms_state_discharge_u1    = (((bms_dc_bus_state_u8 >> 1) & 1) == 1) ? true : false;
    bms_state_dcbus_ready_u1  = (((bms_dc_bus_state_u8 >> 2) & 1) == 1) ? true : false;
    bms_state_charge_u1       = (((bms_dc_bus_state_u8 >> 3) & 1) == 1) ? true : false;

    bms_error_high_voltage_u1   = ((bms_bms_error_u8 & 1) == 1) ? true : false;
    bms_error_low_voltage_u1    = (((bms_bms_error_u8 >> 1) & 1) == 1) ? true : false;
    bms_error_high_temp_u1      = (((bms_bms_error_u8 >> 2) & 1) == 1) ? true : false;
    bms_error_communication_u1  = (((bms_bms_error_u8 >> 3) & 1) == 1) ? true : false;
    bms_error_over_current_u1   = (((bms_bms_error_u8 >> 4) & 1) == 1) ? true : false;
    bms_error_fatal_u1          = (((bms_bms_error_u8 >> 5) & 1) == 1) ? true : false;
    bms_error_isolation_u1      = (((bms_bms_error_u8 >> 6) & 1) == 1) ? true : false;

    for(i=0;i<graphData_array.length-1;i++){
      graphData_array[i] = graphData_array[i+1];
    }
    graphData_array[graphData_array.length-1] = graph_data(driver_phase_a_current_f32,
        driver_phase_b_current_f32,
        driver_dc_bus_current_f32,
        driver_id_f32,
        driver_iq_f32,
        driver_vd_f32,
        driver_vq_f32,
        bms_bat_volt_f32,
        bms_bat_current_f32,
        bms_bat_cons_f32,
        x_time);
    notifyListeners();

    for(i=0;i<graphData_array.length;i++){
      debugPrint(i.toString()+' '+graphData_array[i].driver_phase_a_current_g.toString());
    }
  }

}