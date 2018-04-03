using System;
using System.Threading;
using System.Threading.Tasks;
using Sunricher.Wifi.Api;

namespace Sunricher.Wifi.CommandLine
{
	internal static class Program
	{
		private static void Main(String[] args)
		{
			var messagesProvider = new MessagesProvider(new MessagesGenerator());
			var random = new Random();

			using (var client = new SunricherTcpClient("192.168.12.133", ApiConstants.DefaultTcpPort))
			{
				var cts = new CancellationTokenSource();
				var ct = cts.Token;
				var task = Task.Run(() =>
				{
					client.SendMessage(messagesProvider.PowerOn());

					while (true)
					{
						if (ct.IsCancellationRequested)
							break;

						client.SendMessage(messagesProvider.SetR((Byte) random.Next(0, 100)));
						client.SendMessage(messagesProvider.SetG((Byte) random.Next(0, 100)));
						client.SendMessage(messagesProvider.SetB((Byte) random.Next(0, 100)));
						client.SendMessage(messagesProvider.SetBrightness((Byte) random.Next(0, 255)));
						Thread.Sleep(1000);
					}
				}, ct);

				Console.ReadKey();
				cts.Cancel();
				task.Wait(TimeSpan.FromSeconds(10));
			}
		}
	}
}