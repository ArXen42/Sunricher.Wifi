using System;

namespace Sunricher.Wifi.Api
{
	public static class ApiConstants
	{
		public static Byte[] DataOff = {0x2, 0x12, 0xA9};
		public static Byte[] DataOn = {0x2, 0x12, 0xAB};
		public static Byte[] DataDimWhite = {0x8, 0x3A, 0x0};
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

		public static String AtOk = "+ok";
		public static String AtAssist = "HF-A11ASSISTHREAD";

		public static Int32 TcpPort = 8899;
		public static Int32 UdpPort = 48899;
	}
}