using System;
using System.Collections.Generic;
using System.Linq;

namespace Sunricher.Wifi.Api
{
	/// <summary>
	///     Default implementation of <see cref="IMessagesProvider" />.
	///     Also provides untested Sunricher API messages.
	/// </summary>
	public class MessagesProvider : IMessagesProvider
	{
		private readonly IMessagesGenerator _messagesGenerator;

		public MessagesProvider(IMessagesGenerator messagesGenerator)
		{
			_messagesGenerator = messagesGenerator;
			Rooms = EmptyRooms.ToArray();
		}

		public static IEnumerable<Byte> EmptyRooms => new Byte[] { };

		public IEnumerable<Byte> Rooms { get; set; }


		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom1Off()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom1Off);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom1On()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom1On);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom2Off()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom2Off);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom2On()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom2On);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom3Off()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom3Off);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom3On()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom3On);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom4Off()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom4Off);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom4On()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom4On);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom5Off()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom5Off);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom5On()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom5On);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom6Off()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom6Off);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom6On()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom6On);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom7Off()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom7Off);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom7On()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom7On);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom8Off()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom8Off);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRoom8On()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRoom8On);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiCdwBrightnessSeekbar(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataCdwBrightnessSeekbar, value);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiCircleCdw(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataCircleCdw, value);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiCircleDim(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataCircleDim, value);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiCircleRgb(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataCircleRgb, value);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiCurtainOff()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataCurtainOff);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiCurtainOn()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataCurtainOn);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiFanOff()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataFanOff);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiFanOn()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataFanOn);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiFanSeekbar(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataFanSeekbar, value);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiLearn()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataLearn);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiLearnRoom()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataLearnRoom);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbLongclickA1()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbLongclickA1);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbLongclickA2()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbLongclickA2);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbLongclickA3()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbLongclickA3);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbLongclickB1()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbLongclickB1);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbLongclickB2()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbLongclickB2);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbLongclickB3()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbLongclickB3);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbMusic()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbMusic);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbMusicRecordOff()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbMusicRecordOff);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbMusicRecordOn()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbMusicRecordOn);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbRunOff(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataRgbRunOff, value);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbRunOn()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbRunOn);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbRunSeekbar(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataRgbRunSeekbar, value);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbWhiteLongclickOff()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbWhiteLongclickOff);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbWhiteLongclickOn()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataRgbWhiteLongclickOn);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiRgbWhiteSeekbar(Byte value)
		{
			return CreateMessageFromTwoByteConstant(ApiConstants.DataRgbWhiteSeekbar, value);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSave1()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSave1);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSave2()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSave2);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSave3()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSave3);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSave4()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSave4);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSave5()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSave5);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSave6()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSave6);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSave7()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSave7);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSave8()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSave8);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSaveClick()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSaveClick);
		}

		/// <summary>
		///     Not tested yet.
		/// </summary>
		public Byte[] ApiSaveLongclick()
		{
			return CreateMessageFromThreeByteConstant(ApiConstants.DataSaveLongclick);
		}

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

			return _messagesGenerator.CreateMessage(Rooms, data[0], data[1], data[2]);
		}

		private Byte[] CreateMessageFromTwoByteConstant(Byte[] constant, Byte value)
		{
			if (constant.Length != 2)
				throw new ArgumentException("There must be exactly two bytes in the data array.");

			return _messagesGenerator.CreateMessage(Rooms, constant[0], constant[1], value);
		}
	}
}