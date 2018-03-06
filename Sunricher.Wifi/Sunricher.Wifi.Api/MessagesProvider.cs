using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Sunricher.Wifi.Api
{
	public class MessagesProvider : IMessagesProvider
	{
		public MessagesProvider(IMessagesComposer messagesComposer)
		{
			_messagesComposer = messagesComposer;
		}


		public Byte[] PowerOn()
		{
			return CreateMessageFromThreeByteConstant(EmptyRooms, ApiConstants.DataOn);
		}

		public Byte[] PowerOff()
		{
			return CreateMessageFromThreeByteConstant(EmptyRooms, ApiConstants.DataOff);
		}

		public Byte[] SetR(Byte value)
		{
			return CreateMessageFromTwoByteConstant(EmptyRooms, ApiConstants.DataRgbRSeekbar, value);
		}

		public Byte[] SetG(Byte value)
		{
			return CreateMessageFromTwoByteConstant(EmptyRooms, ApiConstants.DataRgbGSeekbar, value);
		}

		public Byte[] SetB(Byte value)
		{
			return CreateMessageFromTwoByteConstant(EmptyRooms, ApiConstants.DataRgbBSeekbar, value);
		}

		public Byte[] SetBrightness(Byte value)
		{
			return CreateMessageFromTwoByteConstant(EmptyRooms, ApiConstants.DataRgbBrightnessSeekbar, value);
		}

		private Byte[] EmptyRooms => new Byte[] { };

		private Byte[] CreateMessageFromThreeByteConstant(IEnumerable<Byte> rooms, Byte[] constant)
		{
			if (constant.Length != 3)
				throw new ArgumentException("There must be exactly three bytes in the array.");

			return _messagesComposer.CreateMessage(rooms, constant[0], constant[1], constant[2]);
		}

		private Byte[] CreateMessageFromTwoByteConstant(IEnumerable<Byte> rooms, Byte[] constant, Byte value)
		{
			if (constant.Length != 2)
				throw new ArgumentException("There must be exactly two bytes in the array.");

			return _messagesComposer.CreateMessage(rooms, constant[0], constant[1], value);
		}

		private readonly IMessagesComposer _messagesComposer;
	}
}