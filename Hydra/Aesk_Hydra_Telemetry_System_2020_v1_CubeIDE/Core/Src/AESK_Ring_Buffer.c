/*
 * AESK_Ring_Buffer.c
 *
 *  Created on: Nov 28, 2020
 *      Author: basri
 */
#include <AESK_Ring_Buffer.h>

void Ring_Buffer_Init(AESK_Ring_Buffer* rng_buf)
{
	for(uint16_t i = 0; i < sizeof(AESK_Ring_Buffer); i++)
	{
		((uint8_t*)rng_buf)[i] = 0;
	}
}

void Write_Data_Ring_Buffer(AESK_Ring_Buffer* rng_buf, const uint8_t* tmp_buf, size_t size)
{
	for(uint8_t i = 0; i < size; i++)
	{
		if(rng_buf->remainder_byte < RING_BUFFER_SIZE)
		{
			rng_buf->remainder_byte++;
			rng_buf->ring_buffer[rng_buf->head] = tmp_buf[i];
			rng_buf->head = ((rng_buf->head + 1) % RING_BUFFER_SIZE);
		}

		else
		{
			rng_buf->tail = ((rng_buf->tail + 1) % RING_BUFFER_SIZE);
		}
	}
}

int16_t Read_Byte_Ring_Buffer(AESK_Ring_Buffer* rng_buf, uint8_t* tmp_buf)
{
	uint16_t read_byte = 0;

	if(rng_buf->remainder_byte > 0)
	{
		*tmp_buf = rng_buf->ring_buffer[rng_buf->tail];
		read_byte++;
		rng_buf->tail = ((rng_buf->tail + 1) % RING_BUFFER_SIZE);
		rng_buf->remainder_byte--;
	}
	else
	{
		return read_byte;
	}

	return read_byte;
}


int16_t Read_All_Buffer(AESK_Ring_Buffer* rng_buf, uint8_t* tmp_buf)
{
	int16_t idx = 0;

	while(rng_buf->remainder_byte)
	{
		Read_Byte_Ring_Buffer(rng_buf, &(tmp_buf[idx]));
		idx++;
	}
	return idx;
}


