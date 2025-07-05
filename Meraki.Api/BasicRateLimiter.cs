using Meraki.Api.Interfaces;
using System.Collections.Concurrent;

namespace Meraki.Api;

/// <summary>
/// This rate limiter can be used by any number of clients to limit the number of requests
/// It uses a simple in-memory queue to track request timestamps and enforces a limit on the number of requests per specified time window.
/// </summary>
public class BasicRateLimiter : IRateLimiter, IDisposable
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

	readonly SemaphoreSlim _semaphore = new(1, 1);

	/// <summary>
	///	Apply rate limiting
	/// </summary>
	/// <param name="httpRequestMessage">The request - ignored for this basic rate limiter</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	public async Task ApplyRateLimitingAsync(
		HttpRequestMessage httpRequestMessage,
		CancellationToken cancellationToken)
	{
		// Lock to ensure thread safety when peeking and then removing timestamps to determine the duration
		await _semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);

		// Lock this whole section so that any other threads trying to access this method will wait until this one is done
		try
		{
			var now = DateTimeOffset.UtcNow;
			var windowStart = now - _window;

			// Remove any timestamps outside the current window
			while (_requestTimestamps.TryPeek(out var timestamp) && timestamp < windowStart)
			{
				_ = _requestTimestamps.TryDequeue(out _);
			}
			// Any timestamps that are older than the current window start have been removed from the queue

			// Have we reached the maximum number of calls?
			if (_requestTimestamps.Count >= _maxCalls)
			{
				// YES - We need to wait until the first timestamp is outside the window

				// Look at the first timestamp in the queue and calculate the wait time
				// (It's possible that the queue is empty here due to another thread having removed entries)
				_ = _requestTimestamps.TryPeek(out var firstTimestamp);

				// Delay until the first timestamp is outside the window
				// Note: This delay will cause this thread, and any others waiting for the semaphore to be released, to wait until the first timestamp is outside the window
				await Task.Delay(firstTimestamp + _window - now, cancellationToken);

				// We don't remove anything from the queue here as waiting should result in the first timestamp being outside the window and being cleaned out above.
			}

			// We either waited successfully or the queue was not full, so we can add the current timestamp
			_requestTimestamps.Enqueue(DateTimeOffset.UtcNow);
		}
		finally
		{
			_ = _semaphore.Release();
		}
	}

	/// <inheritdoc/>
	public void Dispose()
	{
		((IDisposable)_semaphore).Dispose();
		GC.SuppressFinalize(this);
	}
}