using System.Net;

namespace Meraki.Api.Exceptions;

/// <summary>
/// Thrown, when <see cref="MerakiClientOptions.ThrowOnRetryExhaustion"/> is true, once every
/// attempt permitted by <see cref="MerakiClientOptions.MaxAttemptCount"/> has ended in a retryable
/// status (429, 502, 503 or 504). Carries the detail a caller needs to tell "throttled once" from
/// "throttled for ten minutes", which the bare status code cannot convey.
/// </summary>
public class RetryExhaustedException : Exception
{
	/// <summary>
	/// Initializes a new instance of the RetryExhaustedException class
	/// </summary>
	public RetryExhaustedException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the RetryExhaustedException class with a specified error message
	/// </summary>
	/// <param name="message">The message that describes the error</param>
	public RetryExhaustedException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the RetryExhaustedException class with a specified error message and inner exception
	/// </summary>
	/// <param name="message">The message that describes the error</param>
	/// <param name="innerException">The exception that is the cause of the current exception</param>
	public RetryExhaustedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the RetryExhaustedException class with the retry diagnostics
	/// </summary>
	/// <param name="statusCode">The status of the final attempt</param>
	/// <param name="attemptCount">The number of attempts made</param>
	/// <param name="maxAttemptCount">The configured maximum</param>
	/// <param name="elapsed">The time spent across every attempt and wait</param>
	/// <param name="method">The HTTP method</param>
	/// <param name="requestUri">The request URI</param>
	public RetryExhaustedException(
		HttpStatusCode statusCode,
		int attemptCount,
		int maxAttemptCount,
		TimeSpan elapsed,
		HttpMethod method,
		Uri? requestUri)
		: base($"Giving up after {attemptCount}/{maxAttemptCount} attempts over {elapsed.TotalSeconds:N1}s; the last response was {(int)statusCode} {statusCode}. ({method} - {requestUri})")
	{
		StatusCode = statusCode;
		AttemptCount = attemptCount;
		MaxAttemptCount = maxAttemptCount;
		Elapsed = elapsed;
		Method = method;
		RequestUri = requestUri;
	}

	/// <summary>
	/// The status of the final attempt
	/// </summary>
	public HttpStatusCode StatusCode { get; }

	/// <summary>
	/// The number of attempts made
	/// </summary>
	public int AttemptCount { get; }

	/// <summary>
	/// The configured <see cref="MerakiClientOptions.MaxAttemptCount"/>
	/// </summary>
	public int MaxAttemptCount { get; }

	/// <summary>
	/// The time spent across every attempt and every wait between them
	/// </summary>
	public TimeSpan Elapsed { get; }

	/// <summary>
	/// The HTTP method
	/// </summary>
	public HttpMethod? Method { get; }

	/// <summary>
	/// The request URI
	/// </summary>
	public Uri? RequestUri { get; }
}
