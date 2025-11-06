namespace Meraki.Api.NewTest;

public class BasicRateLimiterTests
{
	[Fact]
	public async Task AllowsRequestsWithinLimit()
	{
		var limiter = new BasicRateLimiter(3, TimeSpan.FromSeconds(2));
		using var dummyRequest = new HttpRequestMessage(HttpMethod.Get, "http://localhost");
		var cts = new CancellationTokenSource();

		// Should not throw or delay
		var start = DateTimeOffset.UtcNow;
		for (var i = 0; i < 3; i++)
		{
			await limiter.ApplyRateLimitingAsync(dummyRequest, cts.Token);
		}

		var elapsed = DateTimeOffset.UtcNow - start;
		(elapsed < TimeSpan.FromMilliseconds(100)).Should().BeTrue($"Elapsed: {elapsed.TotalMilliseconds}ms");
	}

	[Fact]
	public async Task DelaysWhenExceedingLimit()
	{
		var limiter = new BasicRateLimiter(2, TimeSpan.FromMilliseconds(500));
		using var dummyRequest = new HttpRequestMessage(HttpMethod.Get, "http://localhost");
		var cts = new CancellationTokenSource();

		// First two should not delay
		await limiter.ApplyRateLimitingAsync(dummyRequest, cts.Token);
		await limiter.ApplyRateLimitingAsync(dummyRequest, cts.Token);

		var start = DateTimeOffset.UtcNow;
		await limiter.ApplyRateLimitingAsync(dummyRequest, cts.Token); // Should delay ~500ms
		var elapsed = DateTimeOffset.UtcNow - start;

		(elapsed >= TimeSpan.FromMilliseconds(450)).Should().BeTrue($"Elapsed: {elapsed.TotalMilliseconds}ms");
		(elapsed <= TimeSpan.FromMilliseconds(550)).Should().BeTrue($"Elapsed: {elapsed.TotalMilliseconds}ms");
	}

	[Fact]
	public async Task HandlesConcurrentRequests()
	{
		var limiter = new BasicRateLimiter(2, TimeSpan.FromMilliseconds(300));
		using var dummyRequest = new HttpRequestMessage(HttpMethod.Get, "http://localhost");
		var cts = new CancellationTokenSource();

		// Fire 4 requests in parallel, only 2 should proceed immediately, others should be delayed
		var start = DateTimeOffset.UtcNow;
		var tasks = new[]
		{
			limiter.ApplyRateLimitingAsync(dummyRequest, cts.Token),
			limiter.ApplyRateLimitingAsync(dummyRequest, cts.Token),
			limiter.ApplyRateLimitingAsync(dummyRequest, cts.Token),
			limiter.ApplyRateLimitingAsync(dummyRequest, cts.Token)
		};
		await Task.WhenAll(tasks);
		var elapsed = DateTimeOffset.UtcNow - start;

		(elapsed >= TimeSpan.FromMilliseconds(300)).Should().BeTrue($"Elapsed: {elapsed.TotalMilliseconds}ms");
		// The logic check here is that we waited at least 300ms for call 3 to happen and then 4 should happen shortly after as
		// the rate limiter removes the expired timestamps prior to the window
		(elapsed < TimeSpan.FromMilliseconds(325)).Should().BeTrue($"Elapsed: {elapsed.TotalMilliseconds}ms");
	}

	[Fact]
	public void ThrowsOnInvalidConstructorArguments()
	{
		_ = Assert.Throws<ArgumentOutOfRangeException>(() => new BasicRateLimiter(0, TimeSpan.FromSeconds(1)));
		_ = Assert.Throws<ArgumentOutOfRangeException>(() => new BasicRateLimiter(1, TimeSpan.Zero));
	}
}