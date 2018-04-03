using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Sunricher.Wifi.Api
{
	/// <inheritdoc />
	/// <summary>
	///     Provides methods to send messages to Sunricher Wi-Fi device.
	/// </summary>
	/// <remarks>
	///     This client is just an example of API usage. You can use any other way to send TCP packets.
	/// </remarks>
	public class SunricherTcpClient : IDisposable
	{
		private readonly TcpClient _tcpClient;

		public SunricherTcpClient(String host, Int32 port)
		{
			_tcpClient = new TcpClient(host, port);
			DelayAfterMessage = TimeSpan.FromMilliseconds(100);
		}

		/// <summary>
		///     Delay after message is sent. Default is 100 milliseconds.
		/// </summary>
		public TimeSpan DelayAfterMessage { get; set; }

		/// <summary>
		///     Returns whether the underlying TCP client is connected.
		/// </summary>
		public Boolean Connected => _tcpClient.Connected;

		/// <summary>
		///     Sends given message to host using TcpClient.
		/// </summary>
		public void SendMessage(Byte[] message)
		{
			_tcpClient.GetStream().Write(message, 0, message.Length);
			Thread.Sleep(DelayAfterMessage);
		}

		/// <summary>
		///     Sends given message to host asynchronously using TcpClient with given cancellation token.
		/// </summary>
		public async Task SendMessageAsync(Byte[] message, CancellationToken cancellationToken)
		{
			await _tcpClient.GetStream().WriteAsync(message, 0, message.Length, cancellationToken);
			await Task.Delay(DelayAfterMessage, cancellationToken);
		}

		/// <summary>
		///     Sends given message to host asynchronously using TcpClient.
		/// </summary>
		public async Task SendMessageAsync(Byte[] message)
		{
			await _tcpClient.GetStream().WriteAsync(message, 0, message.Length);
			await Task.Delay(DelayAfterMessage);
		}

		public void Dispose()
		{
			_tcpClient?.Dispose();
		}
	}
}