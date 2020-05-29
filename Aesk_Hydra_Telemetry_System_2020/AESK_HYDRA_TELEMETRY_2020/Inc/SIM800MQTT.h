/*
 * SIM800MQTT.h
 *
 *  Created on: 9 Nis 2020
 *      Author: yemrelaydin
 */

#ifndef SIM800MQTT_H_
#define SIM800MQTT_H_
#include "stdint.h"
#include "main.h"
#define MQTTPacket_connectData_initializer { {'M', 'Q', 'T', 'C'}, 0, 4, {NULL, {0, NULL}}, 60, 1, 0, \
		MQTTPacket_willOptions_initializer, {NULL, {0, NULL}}, {NULL, {0, NULL}} }
#define MQTTPacket_willOptions_initializer { {'M', 'Q', 'T', 'W'}, 0, {NULL, {0, NULL}}, {NULL, {0, NULL}}, 0, 0 }

#define MQTTString_initializer {NULL, {0, NULL}}

#define HAL_DELAY			5000
#define RESET_AT_COMMAND	"AT+CFUN=1,1\r\n"
#define MQTT_USERNAME	"digital"
#define MQTT_PASSWORd	"aesk"
#define MQTT_TOPIC		"HYDRADATA"
#define MQTT_CLIENT_ID	"HYDRA"

#define HAL_DELAY			5000
#define RESET_AT_COMMAND	"AT+CFUN=1,1\r\n"
enum errors
{
	MQTTPACKET_BUFFER_TOO_SHORT = -2,
	MQTTPACKET_READ_ERROR = -1,
	MQTTPACKET_READ_COMPLETE
};

enum msgTypes
{
	CONNECT = 1, CONNACK, PUBLISH, PUBACK, PUBREC, PUBREL,
	PUBCOMP, SUBSCRIBE, SUBACK, UNSUBSCRIBE, UNSUBACK,
	PINGREQ, PINGRESP, DISCONNECT
};

typedef enum
{
	SerialCommunicationControl = 0,
	SerialEchoOff = 1,
	ChangeSIM800SerialBaudRate = 2,
	ChangeSTBaudRate = 3,
	DeactiveGPRS = 4,
	ConnectGPRS = 5,
	SetGPRSProfile = 6,
	BringUPGPRS = 7,
	LearnSIM800IP = 8,
	StartTCPConnect = 9,
	CreateMQTTConnectPack = 10,
	SendMQTTConnectPack = 11,
	CreateMQTTPublishPack = 12,
	SendMQTTPublishPack = 13,
	EmptyState = 14,
	GsmOnOffSet = 15,
	Gsm1500msWait = 16,
	GsmOnOffReset = 17,
	Gsm800msWait = 18,
	Gsm800msWait1 = 19,
	GsmOnOffSet1 = 20,
	GsmOnOffReset1 = 21,
	GsmWakeUpEightSecond = 22
}MQTTCalibrationStates;


typedef struct
{
	int len;
	char* data;
} MQTTLenString;

typedef struct
{
	char* cstring;
	MQTTLenString lenstring;
} MQTTString;

typedef struct
{
	/** The eyecatcher for this structure.  must be MQTW. */
	char struct_id[4];
	/** The version number of this structure.  Must be 0 */
	int struct_version;
	/** The LWT topic to which the LWT message will be published. */
	MQTTString topicName;
	/** The LWT payload. */
	MQTTString message;
	/**
      * The retained flag for the LWT message (see MQTTAsync_message.retained).
      */
	unsigned char retained;
	/**
      * The quality of service setting for the LWT message (see
      * MQTTAsync_message.qos and @ref qos).
      */
	char qos;
} MQTTPacket_willOptions;



typedef struct
{
	/** The eyecatcher for this structure.  must be MQTC. */
	char struct_id[4];
	/** The version number of this structure.  Must be 0 */
	int struct_version;
	/** Version of MQTT to be used.  3 = 3.1 4 = 3.1.1
	  */
	unsigned char MQTTVersion;
	MQTTString clientID;
	unsigned short keepAliveInterval;
	unsigned char cleansession;
	unsigned char willFlag;
	MQTTPacket_willOptions will;
	MQTTString username;
	MQTTString password;
} MQTTPacket_connectData;


typedef struct
{
	uint8_t receivegsmdata;
	uint8_t gsmreceivebuffer[32];
	uint8_t gsm_state_next_index;
	uint8_t gsm_state_current_index;
	uint8_t gsmreceivebuffer_index;
	char* at_response;
	char * gsmsendbuffer;
	unsigned char gsmconnectpackage[64];
	unsigned char gsmpublishpackage[255];
	uint8_t MQTTPackage[100];
	int len;
	int mqtt_len;
	UART_HandleTypeDef *gsm_uart;
	uint32_t MQTT_Counter;
}Gsm_Datas;

typedef union
{
	unsigned char all;	/**< all connect flags */
	struct
	{
		unsigned int : 1;	     					/**< unused */
		unsigned int cleansession : 1;	  /**< cleansession flag */
		unsigned int will : 1;			    /**< will flag */
		unsigned int willQoS : 2;				/**< will QoS value */
		unsigned int willRetain : 1;		/**< will retain setting */
		unsigned int password : 1; 			/**< 3.1 password */
		unsigned int username : 1;			/**< 3.1 user name */
	} bits;
} MQTTConnectFlags;

typedef union
{
	unsigned char byte;	                /**< the whole byte */
	struct
	{
		unsigned int retain : 1;		/**< retained flag bit */
		unsigned int qos : 2;				/**< QoS value, 0, 1 or 2 */
		unsigned int dup : 1;				/**< DUP flag bit */
		unsigned int type : 4;			/**< message type nibble */
	} bits;
} MQTTHeader;

/////////////////////////////////////***FUNCTION PROTOTYPES***//////////////////////////////////////////////////////
void SendATCommand(Gsm_Datas* gsm_data, char * command, char* response);
void writeChar(unsigned char** pptr, char c);
void writeChar(unsigned char** pptr, char c);
void writeCString(unsigned char** pptr, const char* string);
int MQTTPacket_encode(unsigned char* buf, int length);
int MQTTstrlen(MQTTString mqttstring);
int MQTTSerialize_connectLength(MQTTPacket_connectData* options);
int MQTTPacket_len(int rem_len);
void writeMQTTString(unsigned char** pptr, MQTTString mqttstring);
int MQTTSerialize_connect(unsigned char* buf, int buflen, MQTTPacket_connectData* options);
int MQTTSerialize_publishLength(int qos, MQTTString topicName, int payloadlen);
int MQTTSerialize_publish(unsigned char* buf, int buflen, unsigned char dup, int qos, unsigned char retained, unsigned short packetid,
						  MQTTString topicName, unsigned char* payload, int payloadlen);


#endif /* SIM800MQTT_H_ */
