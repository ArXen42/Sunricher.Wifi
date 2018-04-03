using System;
using System.Threading;
using System.Threading.Tasks;
using Sunricher.Wifi.Api;

// ReSharper disable AccessToDisposedClosure

namespace Sunricher.Wifi.CommandLine
{
	internal static class Program
	{
		private static void Main(String[] args)
		{
			var messagesProvider = new MessagesProvider(new MessagesGenerator());
			var random = new Random();

			//Just an example of how to use API, pretty bad example
			using (var client = new SunricherTcpClient("192.168.12.133", ApiConstants.DefaultTcpPort))
			{
				var cts = new CancellationTokenSource();
				var ct = cts.Token;
				var task = Task.Run(() =>
				{
					try
					{
						client.SendMessageAsync(messagesProvider.PowerOn(), ct).Wait(ct);
						while (true)
						{
							if (ct.IsCancellationRequested)
								break;

							client.SendMessageAsync(messagesProvider.SetR((Byte) random.Next(0, 100)), ct).Wait(ct);
							client.SendMessageAsync(messagesProvider.SetG((Byte) random.Next(0, 100)), ct).Wait(ct);
							client.SendMessageAsync(messagesProvider.SetB((Byte) random.Next(0, 100)), ct).Wait(ct);
							client.SendMessageAsync(messagesProvider.SetBrightness((Byte) random.Next(0, 255)), ct).Wait(ct);
							Thread.Sleep(1000);
						}
					}
					catch (Exception)
					{
						cts.Cancel();
						throw;
					}
				}, ct);

				Console.ReadKey();
				cts.Cancel();
				task.Wait(TimeSpan.FromSeconds(10));
			}
		}
	}
}