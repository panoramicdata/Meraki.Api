namespace Meraki.Api.Test.Internal;

public class BackOffDelaysTests
{
	[Theory]
	[InlineData(1, 1, 1, 30, 1.0)]
	[InlineData(2, 1, 1, 30, 1.0)]
	[InlineData(3, 1, 1, 30, 1.0)]

	// Double the delay each time with an initial min of 1 from the API
	[InlineData(1, 1, 2, 30, 1.0)]
	[InlineData(2, 1, 2, 30, 2.0)]
	[InlineData(3, 1, 2, 30, 4.0)]

	// API told us to wait 5, so should be a minimum of 5 and then double
	[InlineData(1, 5, 2, 30, 5.0)]
	[InlineData(2, 5, 2, 30, 5.0)]
	[InlineData(3, 5, 2, 30, 5.0)]
	[InlineData(4, 5, 2, 30, 8.0)]

	// Same as above but a maximum back-off of 7
	[InlineData(1, 5, 2, 7, 5.0)]
	[InlineData(2, 5, 2, 7, 5.0)]
	[InlineData(3, 5, 2, 7, 5.0)]
	[InlineData(4, 5, 2, 7, 7.0)]
	public void CalculateBackOffDelay_ReturnsExpected(
		int attemptCount,
		int retryAfterSeconds,
		double backOffDelayFactor,
		int maxBackOffDelaySeconds,
		double expectedDelaySeconds)
	{
		// Use reflection to test internal method
		var type = typeof(MerakiClient).Assembly.GetType("Meraki.Api.AuthenticatedBackingOffHttpClientHandler");
		_ = type.Should().NotBeNull();
		var method = type!.GetMethod("CalculateBackoffDelay", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
		_ = method.Should().NotBeNull();
		var actual = (TimeSpan)method!.Invoke(null, [attemptCount, retryAfterSeconds, backOffDelayFactor, maxBackOffDelaySeconds])!;
		var actualSeconds = actual.TotalSeconds;
		_ = actualSeconds.Should().Be(expectedDelaySeconds);
	}
}
