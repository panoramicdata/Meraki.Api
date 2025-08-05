using Microsoft.Extensions.Logging;

namespace Meraki.Api.Test.Logging;

public static class LoggerFactoryExtensions
{
	public static ILoggerFactory AddXUnit(this ILoggerFactory factory, ITestOutputHelper output)
	{
		factory.AddProvider(new XunitLoggerProvider(output));
		return factory;
	}
}
