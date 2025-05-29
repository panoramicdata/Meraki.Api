using Meraki.Api.Interfaces;
using System.Collections.Concurrent;

namespace Meraki.Api;

/// <summary>
/// This rate limiter can be used by any number of clients to limit the number of requests
/// It uses a simple in-memory queue to track request timestamps and enforces a limit on the number of requests per specified time window.
/// </summary>
public class BasicRateLimiter : IRateLimiter
{
	private readonly int _maxCalls;
	private readonly TimeSpan _window;
	private readonly ConcurrentQueue<DateTimeOffset> _requestTimestamps = [];

	/// <summary>
	/// Initializes a new instance of the <see cref="BasicRateLimiter"/> class.
	/// </summary>
	/// <param name="maxCalls">The maximum number of calls allowed in the specified time window.</param>
	/// <param name="window">The time window for rate limiting.</param>
	public BasicRateLimiter(int maxCalls, TimeSpan window)
	{
		if (maxCalls <= 0)
		{
			throw new ArgumentOutOfRangeException(nameof(maxCalls), "Max calls must be greater than zero.");
		}

		if (window <= TimeSpan.Zero)
		{
			throw new ArgumentOutOfRangeException(nameof(window), "Window must be greater than zero.");
		}

		_maxCalls = maxCalls;
		_window = window;
	}

	/// <summary>
	///	The web request is ignored by this rate limiter, but the method is still required by the interface.
	/// </summary>
	/// <param name="httpRequestMessage"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	public async Task ApplyRateLimitingAsync(
		HttpRequestMessage httpRequestMessage,
		CancellationToken cancellationToken)
	{
		var now = DateTimeOffset.UtcNow;
		var windowStart = now - _window;

		// Remove timestamps outside the current window
		while (_requestTimestamps.TryPeek(out var timestamp) && timestamp < windowStart)
		{
			_ = _requestTimestamps.TryDequeue(out _);
		}

		if (_requestTimestamps.Count >= _maxCalls)
		{
			if (_requestTimestamps.TryPeek(out var firstTimestamp) && firstTimestamp + _window > now)
			{
				var waitTime = firstTimestamp + _window - now;
				if (waitTime > TimeSpan.Zero)
				{
					await Task.Delay(waitTime, cancellationToken);
				}
			}
			// After waiting, remove the oldest timestamp (now outside the window)
			_ = _requestTimestamps.TryDequeue(out _);
		}

		_requestTimestamps.Enqueue(DateTimeOffset.UtcNow);
	}
}