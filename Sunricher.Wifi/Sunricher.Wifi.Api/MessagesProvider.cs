using System;
using System.Collections.Generic;
using System.Linq;

namespace Sunricher.Wifi.Api
{
	public class MessagesProvider : IMessagesProvider
	{
		public static IEnumerable<Byte> EmptyRooms => new Byte[] { };

		public MessagesProvider(IMessagesComposer messagesComposer)
		{
			_messagesComposer = messagesComposer;
			Rooms = EmptyRooms.ToArray();
		}

		public IEnumerable<Byte> Rooms { get; set; }

		public Byte[] PowerOn()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataOn);
		}

		public Byte[] PowerOff()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataOff);
		}

		public Byte[] SetR(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataRgbRSeekbar, value);
		}

		public Byte[] SetG(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataRgbGSeekbar, value);
		}

		public Byte[] SetB(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataRgbBSeekbar, value);
		}

		public Byte[] SetBrightness(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataRgbBrightnessSeekbar, value);
		}

		private Byte[] CreateMessageFromThreeByteConstant(Byte[] data)
		{
			if (data.Length != 3)
				throw new ArgumentException("There must be exactly three bytes in the data array.");

			return _messagesComposer.CreateMessage(Rooms, data[0], data[1], data[2]);
		}

		private Byte[] CreateMessageFromTwoByteConstant(Byte[] constant, Byte value)
		{
			if (constant.Length != 2)
				throw new ArgumentException("There must be exactly two bytes in the data array.");

			return _messagesComposer.CreateMessage(Rooms, constant[0], constant[1], value);
		}

		private readonly IMessagesComposer _messagesComposer;
	}
}