using System;

namespace Sunricher.Wifi.Api
{
	/// <summary>
	///     Constants from Sunricher android application.
	/// </summary>
	/// <remarks>
	///     These constants were discovered from TCP packets and android application code.
	///     They are tightly coupled with Sunricher android application UI.
	///     Tested constants are documented, purpose of others are yet to figure out.
	///     Some constans are three-byte length and require no additional information to form message.
	///     Others are two-byte length and the third byte must be provided from user.
	/// </remarks>
	public static class ApiConstants
	{
		public const String AtOk = "+ok";
		public const String AtAssist = "HF-A11ASSISTHREAD";

		/// <summary>
		///     TCP port listened by Sunricher device.
		/// </summary>
		public const Int32 DefaultTcpPort = 8899;

		/// <summary>
		///     UDP port listened by Sunricher device.
		/// </summary>
		public const Int32 DefaultUdpPort = 48899;

		/// <summary>
		///     Disable all lights message.
		/// </summary>
		public static Byte[] DataOff = {0x2, 0x12, 0xA9};

		/// <summary>
		///     Enable all lights and restore to their previous state message.
		/// </summary>
		public static Byte[] DataOn = {0x2, 0x12, 0xAB};

		public static Byte[] DataRoom1Off = {0x2, 0xA, 0x92};
		public static Byte[] DataRoom1On = {0x2, 0xA, 0x93};
		public static Byte[] DataRoom2Off = {0x2, 0xA, 0x95};
		public static Byte[] DataRoom2On = {0x2, 0xA, 0x96};
		public static Byte[] DataRoom3Off = {0x2, 0xA, 0x98};
		public static Byte[] DataRoom3On = {0x2, 0xA, 0x99};
		public static Byte[] DataRoom4Off = {0x2, 0xA, 0x9B};
		public static Byte[] DataRoom4On = {0x2, 0xA, 0x9C};
		public static Byte[] DataRoom5Off = {0x2, 0xA, 0x9E};
		public static Byte[] DataRoom5On = {0x2, 0xA, 0x9F};
		public static Byte[] DataRoom6Off = {0x2, 0xA, 0xA1};
		public static Byte[] DataRoom6On = {0x2, 0xA, 0xA2};
		public static Byte[] DataRoom7Off = {0x2, 0xA, 0xA4};
		public static Byte[] DataRoom7On = {0x2, 0xA, 0xA5};
		public static Byte[] DataRoom8Off = {0x2, 0xA, 0xA7};
		public static Byte[] DataRoom8On = {0x2, 0xA, 0xA8};

		public static Byte[] DataCdwBrightnessSeekbar = {0x8, 0x33};

		/// <summary>
		///     Change brightness without changing color message.
		/// </summary>
		public static Byte[] DataRgbBrightnessSeekbar = {0x8, 0x23};

		public static Byte[] DataCircleCdw = {0x8, 0x36};
		public static Byte[] DataCircleDim = {0x8, 0x38};
		public static Byte[] DataCircleRgb = {0x1, 0x1};

		public static Byte[] DataCurtainOff = {0x2, 0x80, 0x1};
		public static Byte[] DataCurtainOn = {0x2, 0x80, 0x2};

		public static Byte[] DataFanOff = {0x2, 0x83, 0x1};
		public static Byte[] DataFanOn = {0x2, 0x83, 0x2};
		public static Byte[] DataFanSeekbar = {0x8, 0x82};

		public static Byte[] DataLearn = {0x9, 0x37, 0x1};
		public static Byte[] DataLearnRoom = {0x1, 0x1, 0x1};

		/// <summary>
		///     Set Red channel message.
		/// </summary>
		public static Byte[] DataRgbRSeekbar = {0x8, 0x48};

		/// <summary>
		///     Set Green channel message.
		/// </summary>
		public static Byte[] DataRgbGSeekbar = {0x8, 0x49};

		/// <summary>
		///     Set Blue channel message.
		/// </summary>
		public static Byte[] DataRgbBSeekbar = {0x8, 0x4A};

		public static Byte[] DataRgbLongclickA1 = {0x2, 0x2, 0x81};
		public static Byte[] DataRgbLongclickA2 = {0x2, 0x3, 0x84};
		public static Byte[] DataRgbLongclickA3 = {0x2, 0x4, 0x87};

		public static Byte[] DataRgbLongclickB1 = {0x2, 0x2, 0x82};
		public static Byte[] DataRgbLongclickB2 = {0x2, 0x3, 0x85};
		public static Byte[] DataRgbLongclickB3 = {0x2, 0x4, 0x88};

		public static Byte[] DataRgbMusic = {0x3, 0x50, 0x1};
		public static Byte[] DataRgbMusicRecordOff = {0x3, 0x50, 0x2};
		public static Byte[] DataRgbMusicRecordOn = {0x3, 0x50, 0x3};

		public static Byte[] DataRgbRunOff = {0x2, 0x4E};
		public static Byte[] DataRgbRunOn = {0x2, 0x4F, 0x15};
		public static Byte[] DataRgbRunSeekbar = {0x8, 0x22};

		public static Byte[] DataRgbWhiteLongclickOff = {0x2, 0x5, 0x8A};
		public static Byte[] DataRgbWhiteLongclickOn = {0x2, 0x5, 0x8B};

		/// <summary>
		///     Set White channel message.
		/// </summary>
		public static Byte[] DataRgbWhiteSeekbar = {0x8, 0x4B};

		public static Byte[] DataSave1 = {0x2, 0xA, 0x91};
		public static Byte[] DataSave2 = {0x2, 0xB, 0x94};
		public static Byte[] DataSave3 = {0x2, 0xC, 0x97};
		public static Byte[] DataSave4 = {0x2, 0xD, 0x9A};
		public static Byte[] DataSave5 = {0x2, 0xE, 0x9D};
		public static Byte[] DataSave6 = {0x2, 0xF, 0xA0};
		public static Byte[] DataSave7 = {0x2, 0x10, 0xA3};
		public static Byte[] DataSave8 = {0x2, 0x11, 0xA6};
		public static Byte[] DataSaveClick = {0x2, 0x14, 0xB0};
		public static Byte[] DataSaveLongclick = {0x2, 0x14, 0xB1};
	}
}