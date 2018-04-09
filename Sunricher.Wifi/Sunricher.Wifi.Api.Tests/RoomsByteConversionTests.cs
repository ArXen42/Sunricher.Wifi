using System;
using Xunit;

namespace Sunricher.Wifi.Api.Tests
{
	public class RoomsByteConversionTests
	{
		[Theory]
		[InlineData(new Byte[] { },                      0b00000000)]
		[InlineData(new Byte[] {1},                      0b00000001)]
		[InlineData(new Byte[] {1, 2},                   0b00000011)]
		[InlineData(new Byte[] {1, 2, 8},                0b10000011)]
		[InlineData(new Byte[] {1, 2, 3, 7},             0b01000111)]
		[InlineData(new Byte[] {1, 2, 3, 4, 5, 6, 7, 8}, 0b11111111)]
		public void GetRoomsByteReturnsCorrectValue(Byte[] rooms, Byte expectedRomByte)
		{
			var messagesGenerator = new MessagesGenerator();
			Byte roomsByte = messagesGenerator.GetRoomsByte(rooms);

			Assert.Equal(roomsByte, expectedRomByte);
		}

		[Fact]
		public void ConversionsAreReversible()
		{
			var messagesGenerator = new MessagesGenerator();

			for (Int32 roomsByte = 0; roomsByte <= 255; roomsByte++)
			{
				var rooms = messagesGenerator.GetRoomsFromByte((Byte) roomsByte);
				Byte newRoomsByte = messagesGenerator.GetRoomsByte(rooms);
				Assert.Equal(roomsByte, newRoomsByte);
			}
		}
	}
}