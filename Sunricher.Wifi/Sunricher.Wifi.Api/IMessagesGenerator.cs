using System;
using System.Collections.Generic;

namespace Sunricher.Wifi.Api
{
	/// <summary>
	///     Provides methods to generate arbitrary messages which can be sent to WiFi-to-RF device (for example, SR-2818WiN).
	/// </summary>
	public interface IMessagesGenerator
	{
		/// <summary>
		///     Generates packet data which can be sent to WiFi-to-RF device (for example, SR-2818WiN).
		/// </summary>
		/// <remarks>
		///     Always 12-bytes in default implementation.
		/// </remarks>
		/// <param name="rooms">Collection of rooms numbers.</param>
		/// <param name="category">Category byte. Usually, the first byte of data constant from <see cref="ApiConstants" />.</param>
		/// <param name="channel">
		///     Channel (probably color channel) byte. Usually, the second byte of data constant from
		///     <see cref="ApiConstants" />.
		/// </param>
		/// <param name="value">Command byte. Usually, the third byte of data constant from <see cref="ApiConstants" />.</param>
		/// <returns>Prepared message data.</returns>
		Byte[] CreateMessage(IEnumerable<Byte> rooms, Byte category, Byte channel, Byte value);

		/// <summary>
		///     Encodes room numbers into byte value. Up to 8 rooms numbered from 1 to 8 are supported in default implementation.
		/// </summary>
		Byte GetRoomByte(IEnumerable<Byte> rooms);
	}
}