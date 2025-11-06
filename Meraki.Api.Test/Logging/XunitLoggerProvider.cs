using Microsoft.Extensions.Logging;

namespace Meraki.Api.Test.Logging;

public class XunitLoggerProvider(ITestOutputHelper output) : ILoggerProvider
{
	public ILogger CreateLogger(string categoryName) => new XunitLogger(output, categoryName);

	public void Dispose()
		=> GC.SuppressFinalize(this);
}
