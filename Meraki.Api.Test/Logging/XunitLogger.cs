using Microsoft.Extensions.Logging;

namespace Meraki.Api.Test.Logging;

public class XunitLogger : ILogger
{
	private readonly ITestOutputHelper _output;
	private readonly string _categoryName;

	public XunitLogger(ITestOutputHelper output, string categoryName)
	{
		_output = output;
		_categoryName = categoryName;
	}

	public IDisposable BeginScope<TState>(TState state) => null!;
	public bool IsEnabled(LogLevel logLevel) => true;
	public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
	{
		_output.WriteLine($"[{logLevel}] {_categoryName}: {formatter(state, exception)}");
		if (exception != null)
		{
			_output.WriteLine(exception.ToString());
		}
	}
}
