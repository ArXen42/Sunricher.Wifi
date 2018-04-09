using System;
using System.Collections.Generic;

namespace Sunricher.Wifi.Api
{
	/// <summary>
	///     Provides method for generating command messages.
	/// </summary>
	public interface IMessagesProvider
	{
		/// <summary>
		///     Collection of rooms numbers. Initially empty in default implementation.
		/// </summary>
		IEnumerable<Byte> Rooms { get; set; }

		/// <summary>
		///     Byte representation of <see cref="Rooms"/> property.
		/// </summary>
		Byte RoomsByte { get; set; }

		/// <summary>
		///     Returns message to power on all LED.
		/// </summary>
		Byte[] PowerOn();

		/// <summary>
		///     Returns message to power off all LED.
		/// </summary>
		Byte[] PowerOff();

		/// <summary>
		///     Returns message to set LED red channel.
		/// </summary>
		Byte[] SetRed(Byte value);

		/// <summary>
		///     Returns message to set LED green channel;
		/// </summary>
		Byte[] SetGreen(Byte value);

		/// <summary>
		///     Returns message to set LED blue channel
		/// </summary>
		Byte[] SetBlue(Byte value);

		/// <summary>
		///     Returns message to set LED white channel
		/// </summary>
		Byte[] SetWhite(Byte value);

		/// <summary>
		///     Returns message to set LED brightness without changing color.
		/// </summary>
		Byte[] SetBrightness(Byte value);
	}
}