using System;
using System.Threading.Tasks;

namespace Sunricher.Wifi.Api
{
	/// <summary>
	///     FIFO tasks serial queue. Enqueued task will be processed one at time.
	///     From <a href="https://github.com/Gentlee/SerialQueue">https://github.com/Gentlee/SerialQueue</a>.
	/// </summary>
	internal class SerialQueue
	{
		private readonly Object _syncRoot = new Object();
		private WeakReference<Task> _lastTask;

		public Task Enqueue(Action action)
		{
			lock (_syncRoot)
			{
				return Enqueue<Object>(() =>
				{
					action();
					return null;
				});
			}
		}

		public Task<T> Enqueue<T>(Func<T> function)
		{
			lock (_syncRoot)
			{
				Task<T> resultTask = null;

				if (_lastTask != null && _lastTask.TryGetTarget(out Task lastTask))
				{
					resultTask = lastTask.ContinueWith(_ => function());
				}
				else
				{
					resultTask = Task.Run(function);
				}

				_lastTask = new WeakReference<Task>(resultTask);
				return resultTask;
			}
		}
	}
}