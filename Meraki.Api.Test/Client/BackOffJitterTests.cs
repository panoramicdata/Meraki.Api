namespace Meraki.Api.Test.Client;

/// <summary>
/// Tests for AuthenticatedBackingOffHttpClientHandler.ApplyJitter (issue #374).
///
/// These are pure unit tests - they construct nothing that talks to Meraki and make no network calls.
/// The randomness source is injected so that every case here is deterministic.
/// </summary>
public class BackOffJitterTests
{
	private const int Seed = 12345;

	/// <summary>
	/// Jitter must never shorten a delay. The delay handed in already honours any Retry-After the
	/// server supplied, so retrying earlier than the returned value would break the server's contract.
	/// </summary>
	[Theory]
	[InlineData(1.0, 30)]
	[InlineData(5.0, 30)]
	[InlineData(0.5, 30)]
	[InlineData(19.9, 30)]
	public void ApplyJitter_NeverReturnsLessThanTheInputDelay(double delaySeconds, int maxBackOffDelaySeconds)
	{
		var input = TimeSpan.FromSeconds(delaySeconds);
		var random = new Random(Seed);

		for (var i = 0; i < 1000; i++)
		{
			var actual = AuthenticatedBackingOffHttpClientHandler.ApplyJitter(input, maxBackOffDelaySeconds, random);
			_ = actual.Should().BeGreaterThanOrEqualTo(input);
		}
	}

	/// <summary>
	/// Jitter must never exceed the configured maximum, which is a documented ceiling.
	/// </summary>
	[Theory]
	[InlineData(1.0, 30)]
	[InlineData(25.0, 30)]
	[InlineData(29.9, 30)]
	public void ApplyJitter_NeverExceedsTheConfiguredMaximum(double delaySeconds, int maxBackOffDelaySeconds)
	{
		var input = TimeSpan.FromSeconds(delaySeconds);
		var random = new Random(Seed);

		for (var i = 0; i < 1000; i++)
		{
			var actual = AuthenticatedBackingOffHttpClientHandler.ApplyJitter(input, maxBackOffDelaySeconds, random);
			_ = actual.TotalSeconds.Should().BeLessThanOrEqualTo(maxBackOffDelaySeconds);
		}
	}

	/// <summary>
	/// Jitter must never extend a delay by more than the jitter fraction, currently 50%.
	/// </summary>
	[Fact]
	public void ApplyJitter_ExtendsByNoMoreThanHalf()
	{
		var input = TimeSpan.FromSeconds(2);
		var random = new Random(Seed);

		for (var i = 0; i < 1000; i++)
		{
			var actual = AuthenticatedBackingOffHttpClientHandler.ApplyJitter(input, 30, random);
			_ = actual.TotalSeconds.Should().BeLessThanOrEqualTo(3.0);
		}
	}

	/// <summary>
	/// The whole point of the change: the same input must not always produce the same output, otherwise
	/// clients throttled together stay in lockstep. This is what issue #374 is about.
	/// </summary>
	[Fact]
	public void ApplyJitter_ProducesDifferentDelaysForTheSameInput()
	{
		var input = TimeSpan.FromSeconds(1);
		var random = new Random(Seed);

		var results = Enumerable
			.Range(0, 100)
			.Select(_ => AuthenticatedBackingOffHttpClientHandler.ApplyJitter(input, 30, random).TotalSeconds)
			.ToList();

		_ = results.Distinct().Count().Should().BeGreaterThan(90,
			"jitter should spread retries across the window rather than clustering them");
	}

	/// <summary>
	/// Documents the deliberate limitation described in ApplyJitter's remarks: at the ceiling there is no
	/// headroom, so the delay is returned unchanged and clients re-align at the maximum.
	/// </summary>
	[Theory]
	[InlineData(30.0, 30)]
	[InlineData(45.0, 30)]
	public void ApplyJitter_ReturnsDelayUnchanged_WhenThereIsNoHeadroomBelowTheMaximum(
		double delaySeconds,
		int maxBackOffDelaySeconds)
	{
		var input = TimeSpan.FromSeconds(delaySeconds);

		var actual = AuthenticatedBackingOffHttpClientHandler.ApplyJitter(
			input,
			maxBackOffDelaySeconds,
			new Random(Seed));

		_ = actual.Should().Be(input);
	}

	/// <summary>
	/// A zero or negative maximum must not produce a negative delay, which Task.Delay would reject.
	/// MerakiClientOptions.Validate would catch a negative value, but MerakiClient never calls it
	/// (issue #377), so the guard has to hold here regardless.
	/// </summary>
	[Theory]
	[InlineData(0)]
	[InlineData(-1)]
	public void ApplyJitter_DoesNotProduceANegativeDelay_WhenTheMaximumIsNotPositive(int maxBackOffDelaySeconds)
	{
		var input = TimeSpan.FromSeconds(1);

		var actual = AuthenticatedBackingOffHttpClientHandler.ApplyJitter(
			input,
			maxBackOffDelaySeconds,
			new Random(Seed));

		_ = actual.Should().Be(input);
		_ = actual.TotalSeconds.Should().BeGreaterThanOrEqualTo(0);
	}

	/// <summary>
	/// The timeout retry path (issue #376) calls CalculateBackoffDelay with a Retry-After of zero, so
	/// that the configured back-off factor governs rather than another magic number. This pins the
	/// resulting delays, which are what a timing-out request will now wait between attempts.
	/// </summary>
	[Theory]
	// Default factor of 1.0: one to any power is one, so a flat one second.
	[InlineData(1, 1.0, 30, 1.0)]
	[InlineData(5, 1.0, 30, 1.0)]
	// A configured factor actually grows, and is capped by the maximum.
	[InlineData(1, 2.0, 30, 1.0)]
	[InlineData(3, 2.0, 30, 4.0)]
	[InlineData(6, 2.0, 30, 30.0)]
	public void TimeoutRetryDelay_UsesTheConfiguredBackOffFactor(
		int attemptCount,
		double backOffDelayFactor,
		int maxBackOffDelaySeconds,
		double expectedSeconds)
	{
		var actual = AuthenticatedBackingOffHttpClientHandler.CalculateBackoffDelay(
			attemptCount,
			retryAfterSeconds: 0,
			backOffDelayFactor,
			maxBackOffDelaySeconds);

		_ = actual.TotalSeconds.Should().Be(expectedSeconds);
	}
}
