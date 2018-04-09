using System;
using System.Collections.Generic;

namespace Sunricher.Wifi.Api
{
	public class MessagesGenerator : IMessagesGenerator
	{
		public Byte[] CreateMessage(IEnumerable<Byte> rooms, Byte category, Byte channel, Byte value)
		{
			var result = new Byte[12];

			// Bytes 0..4 are used as remote identifier. It seems like only the 0x55 byte matters.
			// Android app generates that identifier using IMEI.
			result[0] = 0x55;
			result[1] = 0x00;
			result[2] = 0x00;
			result[3] = 0x00;
			result[4] = 0x00;
			result[5] = GetRoomsByte(rooms);
			result[6] = category;
			result[7] = channel;
			result[8] = value;
			result[9] = (Byte) (result[8] + result[7] + result[6] + result[5] + result[4]);
			result[10] = 0xAA;
			result[11] = 0xAA;

			return result;
		}

		public Byte GetRoomsByte(IEnumerable<Byte> rooms)
		{
			Byte result = 0;
			foreach (Byte room in rooms)
			{
				if (room <= 0 || room > 8)
					throw new ArgumentException("Room numbers must be in range 1..8.");

				result = (Byte) (result | (1 << (room - 1)));
			}

			return result;
		}

		public IEnumerable<Byte> GetRoomsFromByte(Byte roomsByte)
		{
			var rooms = new List<Byte>();
			for (Byte roomNumber = 0; roomNumber < 8; roomNumber++)
				if ((roomsByte & (1 << roomNumber)) > 0)
					rooms.Add((Byte) (roomNumber + 1));

			return rooms;
		}
	}
}