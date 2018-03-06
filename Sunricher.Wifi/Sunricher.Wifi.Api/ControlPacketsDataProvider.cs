using System;
using System.Collections.Generic;
using System.Globalization;

namespace Sunricher.Wifi.Api
{
	public class ControlPacketsDataProvider : IControlPacketsDataProvider
	{
		public Byte[] ComposeMessage(IEnumerable<Byte> rooms, Byte category, Byte channel, Byte value)
		{
			var result = new Byte[12];

			// Bytes 0..4 used as remote identifier. It seems like only 0x55 byte matters.
			// Android app generates that identifier using IMEI.
			result[0] = 0x55;
			result[1] = 0x00;
			result[2] = 0x00;
			result[3] = 0x00;
			result[4] = 0x00;
			result[5] = GetRoomByte(rooms);
			result[6] = category;
			result[7] = channel;
			result[8] = value;
			result[9] = (Byte) (result[8] + result[7] + result[6] + result[5] + result[4]);
			result[10] = 0xAA;
			result[11] = 0xAA;

			return result;
		}

		public Byte[] ComposeMessage(IEnumerable<Byte> rooms, Byte[] constant)
		{
			if (constant.Length != 3)
				throw new ArgumentException("Constant must be three bytes from ApiConstants.");

			return ComposeMessage(rooms, constant[0], constant[1], constant[2]);
		}
		
		private Byte GetRoomByte(IEnumerable<Byte> rooms)
		{
			Byte result = 0;
			foreach (Byte room in rooms)
			{
				if (room <= 0 || room > 8)
					throw new ArgumentException("Room numbers must be in range 1..8.");

				result = Byte.Parse((result | (1 << room - 1)).ToString("X"), NumberStyles.HexNumber);
			}

			return result;
		}
	}
}