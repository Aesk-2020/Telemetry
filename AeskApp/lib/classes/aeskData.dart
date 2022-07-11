import 'dart:typed_data';
import 'dart:math';
import 'package:aeskapp/classes/Mqtt.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/pages/Vcu.dart';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';

const HP_UI_PACK = 27;
const MP_UI_PACK = 28;
const LP_UI_PACK = 29;
const QUERY_ANSWER = 22;

class graph_data {
  var vcu_drive_command_u8_g;
  var vcu_speed_set_rpm_s16_g;
  var vcu_set_torque_s16_g;
  var vcu_speed_limit_u16_g;
  var vcu_torque_limit_u8_g;
  var driver_set_id_s16_g;
  var driver_act_id_s16_g;
  var driver_set_iq_s16_g;
  var driver_act_iq_s16_g;
  var driver_set_torque_s16_g;
  var driver_idc_s16_g;
  var driver_vdc_s16_g;
  var driver_actspeed_s16_g;
  var driver_motortemp_u8_g;
  var driver_acttorque_s8_g;
  var bms_bat_volt_g;
  var bms_bat_current_g;
  var bms_bat_cons_g;
  double time;
  graph_data(
      this.vcu_drive_command_u8_g,
      this.vcu_speed_set_rpm_s16_g,
      this.vcu_set_torque_s16_g,
      this.vcu_speed_limit_u16_g,
      this.driver_set_id_s16_g,
      this.driver_act_id_s16_g,
      this.driver_set_iq_s16_g,
      this.driver_act_iq_s16_g,
      this.driver_set_torque_s16_g,
      this.driver_idc_s16_g,
      this.driver_vdc_s16_g,
      this.driver_actspeed_s16_g,
      this.driver_motortemp_u8_g,
      this.driver_acttorque_s8_g,
      this.bms_bat_volt_g,
      this.bms_bat_current_g,
      this.bms_bat_cons_g,
      this.time);
}

int i;

class AeskData extends ChangeNotifier {
  static var isMQTTRunning = true;
  //new
  static var vcu_drive_command_u8 = 0;
  static var vcu_speed_set_rpm_s16 = 0.0;
  static var vcu_set_torque_s16 = 0;
  static var vcu_set_torque_2_s16 = 0;
  static var vcu_torque_limit_u8 = 0;
  static var vcu_steering_s8 = 0;
  static var vcu_can_error_u8 = 0;
  static var sd_result_u8 = 0;
  static var sd_result_write_u8 = 0;
  static var tcu_hour_u8 = 0;
  static var tcu_minute_u8 = 0;
  static var tcu_second_u8 = 0;

  //new
  static var driver_act_iq_u16 = 0.0;
  static var driver_act_id_u16 = 0.0;
  static var driver_act_vd_s16 = 0.0;
  static var driver_act_vq_s16 = 0.0;
  static var driver_set_id_s16 = 0.0;
  static var driver_set_iq_s16 = 0.0;
  static var driver_set_torque_s16 = 0.0;
  static var driver_idc_s16 = 0.0;
  static var driver_vdc_s16 = 0.0;
  static var driver_actspeed_s16 = 0.0;
  static var driver_motortemp_u8 = 0;
  static var driver_errorstatus_u16 = 0;
  static var driver_acttorque_s8 = 0;
  static var srcMsgId = 0;
  static var kp = 0.0;
  static var ki = 0.0;
  static var kd = 0.0;
  static var kr = 0.0;

  static var driver_act_iq_u16_2 = 0.0;
  static var driver_act_id_u16_2 = 0.0;
  static var driver_act_vd_s16_2 = 0.0;
  static var driver_act_vq_s16_2 = 0.0;
  static var driver_set_id_s16_2 = 0.0;
  static var driver_set_iq_s16_2 = 0.0;
  static var driver_set_torque_s16_2 = 0.0;
  static var driver_idc_s16_2 = 0.0;
  static var driver_vdc_s16_2 = 0.0;
  static var driver_actspeed_s16_2 = 0.0;
  static var driver_motortemp_u8_2 = 0;
  static var driver_errorstatus_u16_2 = 0;
  static var driver_acttorque_s8_2 = 0;

  static bool vcu_command_bms_wake_u1 = false;
  static bool vcu_command_mcu_wake_u1 = false;
  static bool vcu_command_ignition_u1 = false;
  static bool vcu_command_mode_u1 = false;
  static bool vcu_command_brake_u1 = false;
  static bool vcu_command_direction_u1 = false;
  static bool vcu_command_motorselect_u1 = false;

  static bool driver_overcur_ia_u1 = false;
  static bool driver_overcur_ib_u1 = false;
  static bool driver_overcur_ic_u1 = false;
  static bool driver_overcur_idc_u1 = false;
  static bool driver_undercur_idc_u1 = false;
  static bool driver_undervolt_vdc_u1 = false;
  static bool driver_overvolt_vdc_u1 = false;
  static bool driver_underspeed_u1 = false;
  static bool driver_overspeed_u1 = false;
  static bool driver_overtemp_u1 = false;
  static bool driver_zpcf_u1 = false;
  static bool driver_pwm_enabled_u1 = false;
  static bool driver_freewheeling_u1 = false;
  static bool driver_torque_mode_u1 = false;

  static bool driver_overcur_ia_u1_2 = false;
  static bool driver_overcur_ib_u1_2 = false;
  static bool driver_overcur_ic_u1_2 = false;
  static bool driver_overcur_idc_u1_2 = false;
  static bool driver_undercur_idc_u1_2 = false;
  static bool driver_undervolt_vdc_u1_2 = false;
  static bool driver_overvolt_vdc_u1_2 = false;
  static bool driver_underspeed_u1_2 = false;
  static bool driver_overspeed_u1_2 = false;
  static bool driver_overtemp_u1_2 = false;
  static bool driver_zpcf_u1_2 = false;
  static bool driver_pwm_enabled_u1_2 = false;
  static bool driver_freewheeling_u1_2 = false;
  static bool driver_torque_mode_u1_2 = false;

  static var bms_bat_volt_f32; //10
  static var bms_bat_current_f32; //100
  static var bms_bat_cons_f32; //10
  static var bms_soc_f32; //100
  static var bms_bms_error_u8;

  static bool bms_error_high_voltage_u1 = false;
  static bool bms_error_low_voltage_u1 = false;
  static bool bms_error_high_temp_u1 = false;
  static bool bms_error_communication_u1 = false;
  static bool bms_error_over_current_u1 = false;
  static bool bms_error_fatal_u1 = false;
  static bool bms_error_isolation_u1 = false;

  static var bms_dc_bus_state_u8;

  static bool bms_state_precharge_u1 = false;
  static bool bms_state_discharge_u1 = false;
  static bool bms_state_dcbus_ready_u1 = false;
  static bool bms_state_charge_u1 = false;
  static var bms_min_finder = 0;

  static double bms_worst_cell_voltage_f32 = 0; //10
  static var bms_worst_cell_address_u8 = 0;
  static var bms_temp_u8;
  static var bms_power_f32;

  static var gpsTracker_gps_latitude_f64; //1000000
  static var gpsTracker_gps_longtitude_f64;
  static var gpsTracker_gps_velocity_u8;
  static var gpsTracker_gps_sattelite_number_u8;
  static var gpsTracker_gps_efficiency_u8;

  static var eys_bat_current_int16 = 0.0; //10
  static var eys_fc_current_int16 = 0.0; //10
  static var eys_out_current_int16 = 0.0; //10
  static var eys_bat_volt_int16 = 0.0; //10
  static var eys_fc_volt_int16 = 0.0; //10
  static var eys_out_volt_int16 = 0.0; //10
  static var eys_bat_cons_uint16 = 0.0; //10
  static var eys_fc_cons_uint16 = 0.0; //10
  static var eys_fc_lt_cons_uint16 = 0.0; //10
  static var eys_out_cons_uint16 = 0.0; //10
  static var eys_penalty_int8 = 0; //10
  static var eys_sharing_ratio_uint16 = 0.0; //100
  static var eys_temp_uint8 = 0;
  static var eys_error_uint8 = 0;
  static bool eys_bat_cur_error_u1 = false;
  static bool eys_fc_cur_error_u1 = false;
  static bool eys_out_cur_error_u1 = false;
  static bool eys_bat_volt_error_u1 = false;
  static bool eys_fc_volt_error_u1 = false;
  static bool eys_out_volt_error_u1 = false;

  static double x_time = 0;
  static var ping = 0;

  static List<graph_data> graphData_array =
      List.generate(100, (index) => graph_data(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0), growable: false);
  static List<int> battery_cells = List.generate(28, (index) => 0);
  static int cellCount = 28;

  static var MQTT_counter_int32;
//threadlamamız gerekecekse burayı threadlayacaz
  AeskData(ByteData message, Endian myEndian) {
    int _startIndex = MqttAesk.myTopic == "LYRADATA" || MqttAesk.myTopic == "HYDRADATA"
        ? 0
        : 5; //BU TOPICLERDE DEĞİLSE COMPRO KULLANILIYOR
    if (MqttAesk.myPayload.message.length > 1) {
      switch (MqttAesk.myTopic) {
        case "vehicle_to_interface":
          {
            srcMsgId = message.getUint8(_startIndex);
            _startIndex += 2;
            switch (srcMsgId) {
              case HP_UI_PACK:
                {
                  vcu_drive_command_u8 = message.getUint8(_startIndex);
                  _startIndex++;
                  vcu_speed_set_rpm_s16 = message.getInt16(_startIndex, myEndian).toDouble();
                  _startIndex += 2;
                  vcu_set_torque_s16 = message.getInt16(_startIndex, myEndian);
                  _startIndex += 2;
                  vcu_set_torque_2_s16 = message.getInt16(_startIndex, myEndian);
                  _startIndex += 2;
                  vcu_torque_limit_u8 = message.getUint8(_startIndex);
                  _startIndex++;
                  vcu_steering_s8 = message.getUint8(_startIndex);
                  _startIndex++;
                  vcu_steering_s8 -= 54;

                  driver_act_id_u16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_iq_u16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_vd_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_vq_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_id_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_iq_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_torque_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_idc_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_vdc_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_actspeed_s16 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  driver_motortemp_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  driver_errorstatus_u16 = message.getUint16(_startIndex, myEndian);
                  _startIndex += 2;

                  driver_acttorque_s8 = message.getInt8(_startIndex);
                  _startIndex++;

                  driver_act_id_u16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_iq_u16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_vd_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_vq_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_id_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_iq_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_torque_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_idc_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_vdc_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_actspeed_s16_2 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  driver_motortemp_u8_2 = message.getUint8(_startIndex);
                  _startIndex++;

                  driver_errorstatus_u16_2 = message.getUint16(_startIndex, myEndian);
                  _startIndex += 2;

                  driver_acttorque_s8_2 = message.getInt8(_startIndex);
                  _startIndex++;

                  vcu_command_bms_wake_u1 = ((vcu_drive_command_u8 & 1) == 1) ? true : false;
                  vcu_command_mcu_wake_u1 = (((vcu_drive_command_u8 >> 1) & 1) == 1) ? true : false;
                  vcu_command_ignition_u1 = (((vcu_drive_command_u8 >> 2) & 1) == 1) ? true : false;
                  vcu_command_mode_u1 = (((vcu_drive_command_u8 >> 3) & 1) == 1) ? true : false;
                  vcu_command_brake_u1 = (((vcu_drive_command_u8 >> 4) & 1) == 1) ? true : false;
                  vcu_command_direction_u1 = (((vcu_drive_command_u8 >> 5) & 1) == 1) ? true : false;
                  vcu_command_motorselect_u1 = (((vcu_drive_command_u8 >> 6) & 1) == 1) ? true : false;

                  driver_zpcf_u1 = ((driver_errorstatus_u16 & 1) == 1) ? true : false;
                  driver_pwm_enabled_u1 = (((driver_errorstatus_u16 >> 1) & 1) == 1) ? true : false;
                  driver_undervolt_vdc_u1 = (((driver_errorstatus_u16 >> 2) & 1) == 1) ? true : false;
                  driver_overtemp_u1 = (((driver_errorstatus_u16 >> 3) & 1) == 1) ? true : false;
                  driver_overcur_idc_u1 = (((driver_errorstatus_u16 >> 4) & 1) == 1) ? true : false;
                  driver_overvolt_vdc_u1 = (((driver_errorstatus_u16 >> 6) & 1) == 1) ? true : false;

//                  driver_overcur_ia_u1 = ((driver_errorstatus_u16 & 1) == 1) ? true : false;
//                  driver_overcur_ib_u1 = (((driver_errorstatus_u16 >> 1) & 1) == 1) ? true : false;
//                  driver_overcur_ic_u1 = (((driver_errorstatus_u16 >> 2) & 1) == 1) ? true : false;
//                  driver_overcur_idc_u1 = (((driver_errorstatus_u16 >> 3) & 1) == 1) ? true : false;
//                  driver_undercur_idc_u1 = (((driver_errorstatus_u16 >> 4) & 1) == 1) ? true : false;
//                  driver_undervolt_vdc_u1 = (((driver_errorstatus_u16 >> 5) & 1) == 1) ? true : false;
//                  driver_overvolt_vdc_u1 = (((driver_errorstatus_u16 >> 6) & 1) == 1) ? true : false;
//                  driver_underspeed_u1 = (((driver_errorstatus_u16 >> 7) & 1) == 1) ? true : false;
//                  driver_overspeed_u1 = (((driver_errorstatus_u16 >> 8) & 1) == 1) ? true : false;
//                  driver_overtemp_u1 = (((driver_errorstatus_u16 >> 9) & 1) == 1) ? true : false;
//                  driver_zpcf_u1 = (((driver_errorstatus_u16 >> 10) & 1) == 1) ? true : false;
//                  driver_pwm_enabled_u1 = (((driver_errorstatus_u16 >> 11) & 1) == 1) ? true : false;
//                  driver_freewheeling_u1 = (((driver_errorstatus_u16 >> 12) & 1) == 1) ? true : false;
//                  driver_torque_mode_u1 = (((driver_errorstatus_u16 >> 13) & 1) == 1) ? true : false;

//                  driver_overcur_ia_u1_2 = ((driver_errorstatus_u16 & 1) == 1) ? true : false;
//                  driver_overcur_ib_u1_2 = (((driver_errorstatus_u16 >> 1) & 1) == 1) ? true : false;
//                  driver_overcur_ic_u1_2 = (((driver_errorstatus_u16 >> 2) & 1) == 1) ? true : false;
//                  driver_overcur_idc_u1_2 = (((driver_errorstatus_u16 >> 3) & 1) == 1) ? true : false;
//                  driver_undercur_idc_u1_2 = (((driver_errorstatus_u16 >> 4) & 1) == 1) ? true : false;
//                  driver_undervolt_vdc_u1_2 = (((driver_errorstatus_u16 >> 5) & 1) == 1) ? true : false;
//                  driver_overvolt_vdc_u1_2 = (((driver_errorstatus_u16 >> 6) & 1) == 1) ? true : false;
//                  driver_underspeed_u1_2 = (((driver_errorstatus_u16 >> 7) & 1) == 1) ? true : false;
//                  driver_overspeed_u1_2 = (((driver_errorstatus_u16 >> 8) & 1) == 1) ? true : false;
//                  driver_overtemp_u1_2 = (((driver_errorstatus_u16 >> 9) & 1) == 1) ? true : false;
//                  driver_zpcf_u1_2 = (((driver_errorstatus_u16 >> 10) & 1) == 1) ? true : false;
//                  driver_pwm_enabled_u1_2 = (((driver_errorstatus_u16 >> 11) & 1) == 1) ? true : false;
//                  driver_freewheeling_u1_2 = (((driver_errorstatus_u16 >> 12) & 1) == 1) ? true : false;
//                  driver_torque_mode_u1_2 = (((driver_errorstatus_u16 >> 13) & 1) == 1) ? true : false;
                }
                break;

              case MP_UI_PACK:
                {
                  bms_bat_volt_f32 = message.getUint16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  bms_bat_current_f32 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  bms_bat_cons_f32 = message.getUint16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  bms_soc_f32 = message.getUint16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  bms_worst_cell_voltage_f32 = message.getUint16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  bms_bms_error_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  bms_dc_bus_state_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  bms_worst_cell_address_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  bms_temp_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  bms_power_f32 = bms_bat_current_f32 * bms_bat_volt_f32;

                  vcu_can_error_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  sd_result_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  sd_result_write_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  bms_state_precharge_u1 = ((bms_dc_bus_state_u8 & 1) == 1) ? true : false;
                  bms_state_discharge_u1 = (((bms_dc_bus_state_u8 >> 1) & 1) == 1) ? true : false;
                  bms_state_dcbus_ready_u1 = (((bms_dc_bus_state_u8 >> 2) & 1) == 1) ? true : false;
                  bms_state_charge_u1 = (((bms_dc_bus_state_u8 >> 3) & 1) == 1) ? true : false;

                  bms_error_high_voltage_u1 = ((bms_bms_error_u8 & 1) == 1) ? true : false;
                  bms_error_low_voltage_u1 = (((bms_bms_error_u8 >> 1) & 1) == 1) ? true : false;
                  bms_error_high_temp_u1 = (((bms_bms_error_u8 >> 2) & 1) == 1) ? true : false;
                  bms_error_communication_u1 = (((bms_bms_error_u8 >> 3) & 1) == 1) ? true : false;
                  bms_error_over_current_u1 = (((bms_bms_error_u8 >> 4) & 1) == 1) ? true : false;
                  bms_error_fatal_u1 = (((bms_bms_error_u8 >> 5) & 1) == 1) ? true : false;
                  bms_error_isolation_u1 = (((bms_bms_error_u8 >> 6) & 1) == 1) ? true : false;
                }
                break;

              case LP_UI_PACK:
                {
                  tcu_hour_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  tcu_minute_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  tcu_second_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  gpsTracker_gps_latitude_f64 = message.getUint32(_startIndex, myEndian) / 1000000;
                  _startIndex += 4;

                  gpsTracker_gps_longtitude_f64 = message.getUint32(_startIndex, myEndian) / 1000000;
                  _startIndex += 4;

                  gpsTracker_gps_velocity_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  gpsTracker_gps_sattelite_number_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  gpsTracker_gps_efficiency_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  cellCount = 28;

                  for (int i = 0; i < cellCount; i++) {
                    battery_cells[i] = message.getUint8(_startIndex) + bms_worst_cell_voltage_f32.toInt();
                    bms_min_finder = battery_cells[i] < battery_cells[bms_min_finder] ? i : bms_min_finder;
                    _startIndex++;
                  }
                }
                break;

              case QUERY_ANSWER:
                {
                  kp = message.getFloat32(_startIndex, myEndian);
                  _startIndex += 4;

                  ki = message.getFloat32(_startIndex, myEndian);
                  _startIndex += 4;

                  kd = message.getFloat32(_startIndex, myEndian);
                  _startIndex += 4;

                  kr = message.getUint16(_startIndex, myEndian) / 100;

                  showDialog(builder: (BuildContext context) {
                    return AlertDialog(
                      title: myText("Değerler ayarlandı!", 20, Colors.green, FontWeight.bold),
                      content: myText(
                          "Kp: " +
                              kp.toString() +
                              "\n" +
                              "Ki: " +
                              ki.toString() +
                              "\n" +
                              "Kd: " +
                              kd.toString() +
                              "\n" +
                              "Kr: " +
                              kr.toString() +
                              "\n",
                          20,
                          Colors.green,
                          FontWeight.bold),
                    );
                  });
                }
                break;

              default:
                {
                  //statements;
                }
                break;
            }
          }
          break;

        case "vehicle_to_interface_2":
          {
            srcMsgId = message.getUint8(_startIndex);
            _startIndex += 2;
            switch (srcMsgId) {
              case HP_UI_PACK:
                {
                  vcu_drive_command_u8 = message.getUint8(_startIndex);
                  _startIndex++;
                  vcu_speed_set_rpm_s16 = message.getInt16(_startIndex, myEndian).toDouble();
                  _startIndex += 2;
                  vcu_set_torque_s16 = message.getInt16(_startIndex, myEndian);
                  _startIndex += 2;
                  vcu_set_torque_2_s16 = message.getInt16(_startIndex, myEndian);
                  _startIndex += 2;
                  vcu_torque_limit_u8 = message.getUint8(_startIndex);
                  _startIndex++;
                  vcu_steering_s8 = message.getUint8(_startIndex);
                  _startIndex++;
                  vcu_steering_s8 -= 54;

                  driver_act_id_u16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_iq_u16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_vd_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_vq_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_id_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_iq_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_torque_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_idc_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_vdc_s16 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_actspeed_s16 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  driver_motortemp_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  driver_errorstatus_u16 = message.getUint16(_startIndex, myEndian);
                  _startIndex += 2;

                  driver_acttorque_s8 = message.getInt8(_startIndex);
                  _startIndex++;

                  driver_act_id_u16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_iq_u16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_vd_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_act_vq_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_id_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_iq_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_set_torque_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_idc_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_vdc_s16_2 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  driver_actspeed_s16_2 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  driver_motortemp_u8_2 = message.getUint8(_startIndex);
                  _startIndex++;

                  driver_errorstatus_u16_2 = message.getUint16(_startIndex, myEndian);
                  _startIndex += 2;

                  driver_acttorque_s8_2 = message.getInt8(_startIndex);
                  _startIndex++;

                  bms_bat_volt_f32 = message.getUint16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  bms_bat_current_f32 = message.getInt16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  bms_bat_cons_f32 = message.getUint16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  vcu_command_bms_wake_u1 = ((vcu_drive_command_u8 & 1) == 1) ? true : false;
                  vcu_command_mcu_wake_u1 = (((vcu_drive_command_u8 >> 1) & 1) == 1) ? true : false;
                  vcu_command_ignition_u1 = (((vcu_drive_command_u8 >> 2) & 1) == 1) ? true : false;
                  vcu_command_mode_u1 = (((vcu_drive_command_u8 >> 3) & 1) == 1) ? true : false;
                  vcu_command_brake_u1 = (((vcu_drive_command_u8 >> 4) & 1) == 1) ? true : false;
                  vcu_command_direction_u1 = (((vcu_drive_command_u8 >> 5) & 1) == 1) ? true : false;
                  vcu_command_motorselect_u1 = (((vcu_drive_command_u8 >> 6) & 1) == 1) ? true : false;

                  driver_overcur_ia_u1 = ((driver_errorstatus_u16 & 1) == 1) ? true : false;
                  driver_overcur_ib_u1 = (((driver_errorstatus_u16 >> 1) & 1) == 1) ? true : false;
                  driver_overcur_ic_u1 = (((driver_errorstatus_u16 >> 2) & 1) == 1) ? true : false;
                  driver_overcur_idc_u1 = (((driver_errorstatus_u16 >> 3) & 1) == 1) ? true : false;
                  driver_undercur_idc_u1 = (((driver_errorstatus_u16 >> 4) & 1) == 1) ? true : false;
                  driver_undervolt_vdc_u1 = (((driver_errorstatus_u16 >> 5) & 1) == 1) ? true : false;
                  driver_overvolt_vdc_u1 = (((driver_errorstatus_u16 >> 6) & 1) == 1) ? true : false;
                  driver_underspeed_u1 = (((driver_errorstatus_u16 >> 7) & 1) == 1) ? true : false;
                  driver_overspeed_u1 = (((driver_errorstatus_u16 >> 8) & 1) == 1) ? true : false;
                  driver_overtemp_u1 = (((driver_errorstatus_u16 >> 9) & 1) == 1) ? true : false;
                  driver_zpcf_u1 = (((driver_errorstatus_u16 >> 10) & 1) == 1) ? false : true;
                  driver_pwm_enabled_u1 = (((driver_errorstatus_u16 >> 11) & 1) == 1) ? false : true;
                  driver_freewheeling_u1 = (((driver_errorstatus_u16 >> 12) & 1) == 1) ? true : false;
                  driver_torque_mode_u1 = (((driver_errorstatus_u16 >> 13) & 1) == 1) ? true : false;

                  driver_overcur_ia_u1_2 = ((driver_errorstatus_u16 & 1) == 1) ? true : false;
                  driver_overcur_ib_u1_2 = (((driver_errorstatus_u16 >> 1) & 1) == 1) ? true : false;
                  driver_overcur_ic_u1_2 = (((driver_errorstatus_u16 >> 2) & 1) == 1) ? true : false;
                  driver_overcur_idc_u1_2 = (((driver_errorstatus_u16 >> 3) & 1) == 1) ? true : false;
                  driver_undercur_idc_u1_2 = (((driver_errorstatus_u16 >> 4) & 1) == 1) ? true : false;
                  driver_undervolt_vdc_u1_2 = (((driver_errorstatus_u16 >> 5) & 1) == 1) ? true : false;
                  driver_overvolt_vdc_u1_2 = (((driver_errorstatus_u16 >> 6) & 1) == 1) ? false : true;
                  driver_underspeed_u1_2 = (((driver_errorstatus_u16 >> 7) & 1) == 1) ? true : false;
                  driver_overspeed_u1_2 = (((driver_errorstatus_u16 >> 8) & 1) == 1) ? true : false;
                  driver_overtemp_u1_2 = (((driver_errorstatus_u16 >> 9) & 1) == 1) ? true : false;
                  driver_zpcf_u1_2 = (((driver_errorstatus_u16 >> 10) & 1) == 1) ? false : true;
                  driver_pwm_enabled_u1_2 = (((driver_errorstatus_u16 >> 11) & 1) == 1) ? false : true;
                  driver_freewheeling_u1_2 = (((driver_errorstatus_u16 >> 12) & 1) == 1) ? true : false;
                  driver_torque_mode_u1_2 = (((driver_errorstatus_u16 >> 13) & 1) == 1) ? true : false;
                }
                break;

              case MP_UI_PACK:
                {
                  bms_soc_f32 = message.getUint16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  bms_worst_cell_voltage_f32 = message.getUint16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  bms_bms_error_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  bms_dc_bus_state_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  bms_worst_cell_address_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  bms_temp_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  bms_power_f32 = bms_bat_current_f32 * bms_bat_volt_f32;

                  eys_bat_cons_uint16 = message.getUint16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_fc_cons_uint16 = message.getUint16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_fc_lt_cons_uint16 = message.getUint16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_out_cons_uint16 = message.getUint16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_bat_current_int16 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_fc_current_int16 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_out_current_int16 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_bat_volt_int16 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_fc_volt_int16 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_out_volt_int16 = message.getInt16(_startIndex, myEndian) / 10;
                  _startIndex += 2;

                  eys_penalty_int8 = message.getInt8(_startIndex);
                  _startIndex++;

                  eys_sharing_ratio_uint16 = message.getUint16(_startIndex, myEndian) / 100;
                  _startIndex += 2;

                  eys_temp_uint8 = message.getUint8(_startIndex);
                  _startIndex++;

                  eys_error_uint8 = message.getUint8(_startIndex);
                  _startIndex++;

                  vcu_can_error_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  sd_result_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  sd_result_write_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  eys_bat_cur_error_u1 = ((eys_error_uint8 & 1) == 1) ? true : false;
                  eys_fc_cur_error_u1 = (((eys_error_uint8 >> 1) & 1) == 1) ? true : false;
                  eys_out_cur_error_u1 = (((eys_error_uint8 >> 2) & 1) == 1) ? true : false;
                  eys_bat_volt_error_u1 = (((eys_error_uint8 >> 3) & 1) == 1) ? true : false;
                  eys_fc_volt_error_u1 = (((eys_error_uint8 >> 4) & 1) == 1) ? true : false;
                  eys_out_volt_error_u1 = (((eys_error_uint8 >> 5) & 1) == 1) ? true : false;

                  bms_state_precharge_u1 = ((bms_dc_bus_state_u8 & 1) == 1) ? true : false;
                  bms_state_discharge_u1 = (((bms_dc_bus_state_u8 >> 1) & 1) == 1) ? true : false;
                  bms_state_dcbus_ready_u1 = (((bms_dc_bus_state_u8 >> 2) & 1) == 1) ? true : false;
                  bms_state_charge_u1 = (((bms_dc_bus_state_u8 >> 3) & 1) == 1) ? true : false;

                  bms_error_high_voltage_u1 = ((bms_bms_error_u8 & 1) == 1) ? true : false;
                  bms_error_low_voltage_u1 = (((bms_bms_error_u8 >> 1) & 1) == 1) ? true : false;
                  bms_error_high_temp_u1 = (((bms_bms_error_u8 >> 2) & 1) == 1) ? true : false;
                  bms_error_communication_u1 = (((bms_bms_error_u8 >> 3) & 1) == 1) ? true : false;
                  bms_error_over_current_u1 = (((bms_bms_error_u8 >> 4) & 1) == 1) ? true : false;
                  bms_error_fatal_u1 = (((bms_bms_error_u8 >> 5) & 1) == 1) ? true : false;
                  bms_error_isolation_u1 = (((bms_bms_error_u8 >> 6) & 1) == 1) ? true : false;
                }
                break;

              case LP_UI_PACK:
                {
                  tcu_hour_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  tcu_minute_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  tcu_second_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  gpsTracker_gps_latitude_f64 = message.getUint32(_startIndex, myEndian) / 1000000;
                  _startIndex += 4;

                  gpsTracker_gps_longtitude_f64 = message.getUint32(_startIndex, myEndian) / 1000000;
                  _startIndex += 4;

                  gpsTracker_gps_velocity_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  gpsTracker_gps_sattelite_number_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  gpsTracker_gps_efficiency_u8 = message.getUint8(_startIndex);
                  _startIndex++;

                  cellCount = 28;

                  for (int i = 0; i < cellCount; i++) {
                    battery_cells[i] = message.getUint8(_startIndex) + bms_worst_cell_voltage_f32.toInt();
                    bms_min_finder = battery_cells[i] < battery_cells[bms_min_finder] ? i : bms_min_finder;
                    _startIndex++;
                  }
                }
                break;

              case QUERY_ANSWER:
                {
                  kp = message.getFloat32(_startIndex, myEndian);
                  _startIndex += 4;

                  ki = message.getFloat32(_startIndex, myEndian);
                  _startIndex += 4;

                  kd = message.getFloat32(_startIndex, myEndian);
                  _startIndex += 4;

                  kr = message.getUint16(_startIndex, myEndian) / 100;

                  showDialog(builder: (BuildContext context) {
                    return AlertDialog(
                      title: myText("Değerler ayarlandı!", 20, Colors.green, FontWeight.bold),
                      content: myText(
                          "Kp: " +
                              kp.toString() +
                              "\n" +
                              "Ki: " +
                              ki.toString() +
                              "\n" +
                              "Kd: " +
                              kd.toString() +
                              "\n" +
                              "Kr: " +
                              kr.toString() +
                              "\n",
                          20,
                          Colors.green,
                          FontWeight.bold),
                    );
                  });
                }
                break;

              default:
                {
                  //statements;
                }
                break;
            }
          }
          break;

        case "LYRADATA":
          {
            //statements;
          }
          break;

        case "HYDRADATA":
          {
            //statements;
          }
          break;

        default:
          {
            //statements;
          }
          break;
      }
      for (i = 0; i < graphData_array.length - 1; i++) {
        graphData_array[i] = graphData_array[i + 1];
      }

      graphData_array[graphData_array.length - 1] = graph_data(
          vcu_drive_command_u8,
          vcu_speed_set_rpm_s16,
          vcu_set_torque_s16,
          vcu_set_torque_2_s16,
          driver_set_id_s16,
          driver_act_id_u16,
          driver_set_iq_s16,
          driver_act_iq_u16,
          driver_set_torque_s16,
          driver_idc_s16,
          driver_vdc_s16,
          driver_actspeed_s16,
          driver_motortemp_u8,
          driver_acttorque_s8,
          bms_bat_volt_f32, //10
          bms_bat_current_f32,
          bms_bat_cons_f32, //10
          x_time);
      /*
      if(MqttAesk.myTopic == "vehicle_to_interface" || MqttAesk.myTopic == "vehicle_to_interface_2") {
        srcMsgId =  message.getUint8(_startIndex);
        _startIndex+=2;
      }

      if(srcMsgId != 22) {
        if(MqttAesk.myTopic == "LYRADATA" || MqttAesk.myTopic == "HYDRADATA" || MqttAesk.myTopic == "vehicle_to_interface_2") {
          //BU TOPICLERDE CELLER AKTARILDIĞINDAN BÖYLE YAZILDI
          //cellCount = MqttAesk.isLyra ? 28 : 16;
        }

        for(i=0;i<graphData_array.length-1;i++){
          graphData_array[i] = graphData_array[i+1];
        }

        graphData_array[graphData_array.length-1] = graph_data(
            vcu_drive_command_u8,
            vcu_speed_set_rpm_s16,
            vcu_set_torque_s16,
            vcu_set_torque_2_s16,
            driver_set_id_s16,
            driver_act_id_u16,
            driver_set_iq_s16,
            driver_act_iq_u16,
            driver_set_torque_s16,
            driver_idc_s16,
            driver_vdc_s16,
            driver_actspeed_s16,
            driver_motortemp_u8,
            driver_acttorque_s8,
            bms_bat_volt_f32,//10
            bms_bat_current_f32,
            bms_bat_cons_f32,//10
            x_time
        );

      }
      else {

      }
*/

    }
  }
}
