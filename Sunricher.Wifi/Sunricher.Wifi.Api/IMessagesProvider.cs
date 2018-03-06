using System;

namespace Sunricher.Wifi.Api
{
	/// <summary>
	///     Provides method for generating command messages.
	/// </summary>
	public interface IMessagesProvider
	{
		/// <summary>
		///     Returns message to power on LED.
		/// </summary>
		Byte[] PowerOn();
		
		/// <summary>
		///     Returns message to power off LED.
		/// </summary>
		Byte[] PowerOff();

		/// <summary>
		///     Returns message to set LED red channel.
		/// </summary>
		Byte[] SetR(Byte value);

		/// <summary>
		///     Returns message to set LED green channel;
		/// </summary>
		Byte[] SetG(Byte value);

		/// <summary>
		///     Returns message to set LED blue channel
		/// </summary>
		Byte[] SetB(Byte value);
		
		/// <summary>
		///     Returns message to set LED brightness without changing color.
		/// </summary>
		Byte[] SetBrightness(Byte value);
	}
}