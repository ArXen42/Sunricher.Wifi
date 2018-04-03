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
		private readonly String _host;
		private readonly Int32 _port;
		private TcpClient _tcpClient;

		/// <summary>
		///     Constructs new SunricherTcpClient using given TcpClient. TcpClient must be already connected.
		/// </summary>
		/// <remarks>
		///     Use this constructor if you need to configure TcpClient manually (SendTimeout, SendBufferSize, connect).
		/// </remarks>
		public SunricherTcpClient(TcpClient tcpClient)
		{
			if (tcpClient == null)
				throw new ArgumentNullException("Provided TCP client is null.");
			if (!tcpClient.Connected)
				throw new ArgumentException("Provided TCP client is not connected.");

			_tcpClient = tcpClient;
		}

		/// <summary>
		///     Constructs new SunricherTcpClient with given host and port. Attempts to connect immediately.
		/// </summary>
		public SunricherTcpClient(String host, Int32 port)
		{
			if (String.IsNullOrEmpty(host))
				throw new ArgumentNullException("Host is null or empty.");

			_host = host;
			_port = port;
		}

		/// <summary>
		///     Delay after message is sent. Default is 100 milliseconds.
		/// </summary>
		public TimeSpan DelayAfterMessage { get; set; } = TimeSpan.FromMilliseconds(100);

		/// <summary>
		///     Sends given message to host using TcpClient.
		/// </summary>
		public void SendMessage(Byte[] message)
		{
			if (_tcpClient == null)
				_tcpClient = new TcpClient(_host, _port);

			if (!_tcpClient.Connected)
				_tcpClient.Connect(_host, _port);

			_tcpClient.GetStream().Write(message, 0, message.Length);
			Thread.Sleep(DelayAfterMessage);
		}

		/// <summary>
		///     Sends given message to host asynchronously using TcpClient with given cancellation token.
		/// </summary>
		public async Task SendMessageAsync(Byte[] message, CancellationToken cancellationToken)
		{
			if (_tcpClient == null)
			{
				_tcpClient = new TcpClient();
				await _tcpClient.ConnectAsync(_host, _port);
			}

			await _tcpClient.GetStream().WriteAsync(message, 0, message.Length, cancellationToken);
			await Task.Delay(DelayAfterMessage, cancellationToken);
		}

		/// <summary>
		///     Sends given message to host asynchronously using TcpClient.
		/// </summary>
		public async Task SendMessageAsync(Byte[] message)
		{
			await SendMessageAsync(message, CancellationToken.None);
		}

		public void Dispose()
		{
			_tcpClient?.Dispose();
		}
	}
}