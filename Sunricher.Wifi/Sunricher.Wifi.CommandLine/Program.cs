using System;
using System.Net.Sockets;
using System.Threading;
using Sunricher.Wifi.Api;

namespace Sunricher.Wifi.CommandLine
{
	internal static class Program
	{
		private static void Main(String[] args)
		{
			var offPacketData = new ControlPacketsDataProvider().ComposeMessage(new Byte[] { }, ApiConstants.DataOff);
			var onPacketData = new ControlPacketsDataProvider().ComposeMessage(new Byte[] { }, ApiConstants.DataOn);

			using (var client = new TcpClient("192.168.12.133", ApiConstants.TcpPort))
			{
				for (Int32 i = 0; i < 2; i++)
				{
					client.GetStream().Write(offPacketData, 0, 12);
					Thread.Sleep(500);
					client.GetStream().Write(onPacketData, 0, 12);
					Thread.Sleep(500);
				}
			}
		}
	}
}