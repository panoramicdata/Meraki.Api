using Microsoft.Extensions.Logging;

namespace Meraki.Api.Test.Logging;

public class XunitLogger(ITestOutputHelper output, string categoryName) : ILogger
{
	public IDisposable BeginScope<TState>(TState state) where TState : notnull => NoOpDisposable.Instance;

	public bool IsEnabled(LogLevel logLevel) => true;

	public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
	{
		output.WriteLine($"[{logLevel}] {categoryName}: {formatter(state, exception)}");
		if (exception != null)
		{
			output.WriteLine(exception.ToString());
		}
	}

	private sealed class NoOpDisposable : IDisposable
	{
		public static readonly NoOpDisposable Instance = new();
		private NoOpDisposable() { }
		public void Dispose() { }
	}
}
