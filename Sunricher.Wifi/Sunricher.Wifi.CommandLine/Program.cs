using System;
using System.Net.Sockets;
using Sunricher.Wifi.Api;

namespace Sunricher.Wifi.CommandLine
{
	internal static class Program
	{
		private static void Main(String[] args)
		{
			var messagesProvider = new MessagesProvider(new MessagesGenerator());
			var packetData = messagesProvider.SetBrightness(42);

			Console.WriteLine(DebugHelper.GetByteArrayHexString(packetData));

			using (var client = new TcpClient("192.168.12.133", ApiConstants.TcpPort))
			{
				client.GetStream().Write(packetData, 0, 12);
			}
		}
	}
}