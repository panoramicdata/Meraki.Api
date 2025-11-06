namespace Meraki.Api.NewTest;

public class BackOffDelaysTests
{
	[Theory]
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant
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

	public void CalculateBackoffDelay_ReturnsExpected(
		int attemptCount,
		int retryAfterSeconds,
		double backOffDelayFactor,
		int maxBackOffDelaySeconds,
		double expectedDelaySeconds)
	{
		var actual = AuthenticatedBackingOffHttpClientHandler.CalculateBackoffDelay(attemptCount, retryAfterSeconds, backOffDelayFactor, maxBackOffDelaySeconds);
		var actualSeconds = actual.TotalSeconds;
		_ = actualSeconds.Should().Be(expectedDelaySeconds);
	}
#pragma warning restore CS3016 // Arrays as attribute arguments is not CLS-compliant
}
