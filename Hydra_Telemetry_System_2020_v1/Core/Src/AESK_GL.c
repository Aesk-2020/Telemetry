/*
 * AESK_GL.c
 *
 *  Created on: Dec 12, 2020
 *      Author: basri
 */


#include "AESK_GL.h"

void AESK_GL_Init(AESK_GL* aesk_gl)
{
	for(uint32_t i = 0; i < sizeof(AESK_GL); i++)
	{
		((uint8_t*)aesk_gl)[i] = 0;
	}
}




