namespace Meraki.Api.Interfaces;

/// <summary>
/// A rate limiter interface for Meraki.Api
/// </summary>
public interface IRateLimiter
{
	/// <summary>
	/// This method is called to apply rate limiting to the request.
	/// </summary>
	/// <param name="httpRequestMessage">The HTTP request</param>
	/// <param name="cancellationToken">A cancellation token</param>
	/// <returns></returns>
	public Task ApplyRateLimitingAsync(
		HttpRequestMessage httpRequestMessage,
		CancellationToken cancellationToken);
}
