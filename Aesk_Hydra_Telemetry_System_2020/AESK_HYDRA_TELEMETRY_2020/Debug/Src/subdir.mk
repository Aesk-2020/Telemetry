################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../Src/AESK_CAN_Library.c \
../Src/AESK_Data_Pack_lib.c \
../Src/AESK_Gps_lib.c \
../Src/SIM800MQTT.c \
../Src/bsp_driver_sd.c \
../Src/fatfs.c \
../Src/main.c \
../Src/sd_diskio.c \
../Src/stm32f4xx_hal_msp.c \
../Src/stm32f4xx_it.c \
../Src/syscalls.c \
../Src/system_stm32f4xx.c 

OBJS += \
./Src/AESK_CAN_Library.o \
./Src/AESK_Data_Pack_lib.o \
./Src/AESK_Gps_lib.o \
./Src/SIM800MQTT.o \
./Src/bsp_driver_sd.o \
./Src/fatfs.o \
./Src/main.o \
./Src/sd_diskio.o \
./Src/stm32f4xx_hal_msp.o \
./Src/stm32f4xx_it.o \
./Src/syscalls.o \
./Src/system_stm32f4xx.o 

C_DEPS += \
./Src/AESK_CAN_Library.d \
./Src/AESK_Data_Pack_lib.d \
./Src/AESK_Gps_lib.d \
./Src/SIM800MQTT.d \
./Src/bsp_driver_sd.d \
./Src/fatfs.d \
./Src/main.d \
./Src/sd_diskio.d \
./Src/stm32f4xx_hal_msp.d \
./Src/stm32f4xx_it.d \
./Src/syscalls.d \
./Src/system_stm32f4xx.d 


# Each subdirectory must supply rules for building sources it contributes
Src/%.o: ../Src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: MCU GCC Compiler'
	@echo $(PWD)
	arm-none-eabi-gcc -mcpu=cortex-m4 -mthumb -mfloat-abi=hard -mfpu=fpv4-sp-d16 -DUSE_HAL_DRIVER -DSTM32F412Rx -I"D:/GitHub/Telemetry/Aesk_Hydra_Telemetry_System_2020/AESK_HYDRA_TELEMETRY_2020/Inc" -I"D:/GitHub/Telemetry/Aesk_Hydra_Telemetry_System_2020/AESK_HYDRA_TELEMETRY_2020/Drivers/STM32F4xx_HAL_Driver/Inc" -I"D:/GitHub/Telemetry/Aesk_Hydra_Telemetry_System_2020/AESK_HYDRA_TELEMETRY_2020/Drivers/STM32F4xx_HAL_Driver/Inc/Legacy" -I"D:/GitHub/Telemetry/Aesk_Hydra_Telemetry_System_2020/AESK_HYDRA_TELEMETRY_2020/Middlewares/Third_Party/FatFs/src" -I"D:/GitHub/Telemetry/Aesk_Hydra_Telemetry_System_2020/AESK_HYDRA_TELEMETRY_2020/Drivers/CMSIS/Device/ST/STM32F4xx/Include" -I"D:/GitHub/Telemetry/Aesk_Hydra_Telemetry_System_2020/AESK_HYDRA_TELEMETRY_2020/Drivers/CMSIS/Include"  -Og -g3 -Wall -fmessage-length=0 -ffunction-sections -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


