using System;
using System.Collections.Generic;

namespace Sunricher.Wifi.Api
{
	/// <summary>
	///     Provides API for generating messages data.
	/// </summary>
	public interface IControlPacketsDataProvider
	{
		/// <summary>
		///     Generates message data which can be sent to WiFi-to-RF device (for example, SR-2818WiN).
		/// </summary>
		/// <param name="rooms">Collection of rooms numbers.</param>
		/// <param name="category">Usually, first byte of data constant.</param>
		/// <param name="channel">Channel (second byte of data constant).</param>
		/// <param name="value">Third byte of data constant</param>
		/// <returns>Prepared message.</returns>
		Byte[] ComposeMessage(IEnumerable<Byte> rooms, Byte category, Byte channel, Byte value);
	}
}