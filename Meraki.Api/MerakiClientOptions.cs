using Meraki.Api.Interfaces;

namespace Meraki.Api;

/// <summary>
/// MerakiClient options
/// </summary>
public class MerakiClientOptions
{
	/// <summary>
	/// The API Region.
	/// Defaults to "World", which is the default region for the Meraki Dashboard API.
	/// Only change this if you are using the China API endpoint.
	/// </summary>
	public ApiRegion ApiRegion { get; set; } = ApiRegion.Default;

	/// <summary>
	/// The API Node (e.g. "n72").
	/// Shard-direct API access will cease to work in September 2025, so this property CANNOT be used.
	/// This is a breaking change.
	/// </summary>
	[Obsolete("Shard-direct API access will cease to work in September 2025.  This is a breaking change.  Do not use this property.", true)]
	public string? ApiNode { get; set; }

	/// <summary>
	/// An optional User-Agent string to attach to outgoing requests.
	/// As per Meraki's documentation, this should be in the format of "MerakiClient/{version} {company}".
	/// See <see href="https://developer.cisco.com/meraki/api-v1/user-agents-overview/#formatting">Meraki API User-Agent Formatting</see>.
	/// </summary>
	public string? UserAgent { get; set; }

	/// <summary>
	/// The API key.
	/// Either ApiKey or AccessToken must be set, but not both.
	/// </summary>
	public string ApiKey { get; set; } = string.Empty;

	/// <summary>
	/// The OAuth access token for Bearer authentication.
	/// Either ApiKey or AccessToken must be set, but not both.
	/// When set, this will be used for authentication instead of the API key.
	/// The token is passed as "Authorization: Bearer {AccessToken}".
	/// </summary>
	public string? AccessToken { get; set; }

	/// <summary>
	/// The overall <see cref="HttpClient.Timeout"/> in seconds. Defaults to 600.
	/// </summary>
	/// <remarks>
	/// This bounds a single logical call <b>including every retry and back-off wait</b>, so at the
	/// default retry settings it is this timeout, not <see cref="MaxAttemptCount"/>, that ends a request
	/// the API keeps throttling. It surfaces as a <see cref="TaskCanceledException"/> from
	/// <see cref="HttpClient"/>. For the timeout applied to each individual attempt see
	/// <see cref="HttpClientInnerTimeoutSeconds"/>. See <see cref="MaxAttemptCount"/> for how the
	/// retry options fit together.
	/// </remarks>
	public int HttpClientTimeoutSeconds { get; set; } = 600;

	/// <summary>
	/// The longest the client will wait between attempts, in seconds. Defaults to 30.
	/// </summary>
	/// <remarks>
	/// Caps the delay computed from <see cref="BackOffDelayFactor"/> and the server's
	/// <c>Retry-After</c> header, and also caps the jitter added to that delay. It is the ceiling on
	/// growth, not the cause of it: with the default <see cref="BackOffDelayFactor"/> of 1.0 the delay
	/// does not grow at all, so this cap only comes into play where <c>Retry-After</c> exceeds it. See
	/// <see cref="MaxAttemptCount"/> for how the retry options fit together.
	/// </remarks>
	public int MaxBackOffDelaySeconds { get; set; } = 30;

	/// <summary>
	/// The base of the exponential back-off between attempts. Defaults to 1.0, which is a flat delay.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Before attempt <i>n</i> the client waits
	/// <c>min(max(BackOffDelayFactor^(n-1), Retry-After), MaxBackOffDelaySeconds)</c> seconds, plus a
	/// small upward jitter. The exponential term never falls below one second and is measured in
	/// seconds, so it is independent of <c>Retry-After</c> rather than a multiplier on it.
	/// </para>
	/// <para>
	/// At the default of 1.0 the exponential term is always exactly one second, so the wait is simply
	/// <c>Retry-After</c> (or one second where the server sends none), capped at
	/// <see cref="MaxBackOffDelaySeconds"/>. This is deliberate: see <see cref="MaxAttemptCount"/>.
	/// A value of 2.0 doubles the delay on every attempt until it reaches the cap; 1.5 grows it by half.
	/// </para>
	/// </remarks>
	public double BackOffDelayFactor { get; set; } = 1.0;

	/// <summary>
	/// The maximum number of attempts made for a single call before the client gives up. Defaults to 500.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Applies to HTTP 429 and 502/503/504 responses, to per-attempt timeouts
	/// (<see cref="HttpClientInnerTimeoutSeconds"/>) and to transient connection failures. Other status
	/// codes are returned to the caller on the first attempt. When attempts run out the client returns
	/// the last response, so Refit raises an ordinary <see cref="ApiException"/> carrying that status.
	/// </para>
	/// <para>
	/// <b>Why the defaults are 500 attempts with a flat, roughly one-second delay.</b> Meraki's rate
	/// limit is per organization and is shared with every other consumer of that organization's API,
	/// including monitoring tools such as Splunk that poll it aggressively. Against a saturated
	/// organization, growing back-off is counter-productive: the longer this client waits, the more of
	/// the budget the other consumers take. The most reliable way to get a call through is to keep
	/// re-asking, honouring <c>Retry-After</c> each time, until a slot opens. The defaults are therefore
	/// tuned so that a call <i>most likely completes</i>, at the cost of possibly taking a long time.
	/// </para>
	/// <para>
	/// The practical bound on that time is <see cref="HttpClientTimeoutSeconds"/> (default 600
	/// seconds), which spans all attempts. At the defaults a throttled call ends with a
	/// <see cref="TaskCanceledException"/> from that timeout before attempt 500 is ever reached.
	/// </para>
	/// <para>
	/// <b>To fail fast instead</b>, lower <see cref="MaxAttemptCount"/> (for example to 5 or 10) and,
	/// if you want the delay to grow between those attempts, set <see cref="BackOffDelayFactor"/> above
	/// 1.0. Consider also lowering <see cref="HttpClientTimeoutSeconds"/> so the overall bound matches.
	/// </para>
	/// </remarks>
	public int MaxAttemptCount { get; set; } = 500;

	/// <summary>
	/// When true, only GETs are permitted
	/// </summary>
	public bool ReadOnly { get; set; }

	/// <summary>
	/// When true, running out of attempts on a retryable status (429, 502, 503 or 504) throws
	/// <see cref="RetryExhaustedException"/>, which carries the attempt count, the time spent and the
	/// final status. Defaults to false, in which case the final response is returned to the caller
	/// exactly as before, so Refit surfaces an ordinary <see cref="ApiException"/> that is
	/// indistinguishable from a first-attempt failure with the same status.
	/// </summary>
	/// <remarks>
	/// Opt in where you surface failures to a user or an operator and want to say "throttled for ten
	/// minutes" rather than "HTTP 429". Leave it off where existing code catches
	/// <see cref="ApiException"/> and inspects the status code, because <see cref="RetryExhaustedException"/>
	/// is not an <see cref="ApiException"/> and will not be caught by those handlers.
	/// </remarks>
	public bool ThrowOnRetryExhaustion { get; set; }

	/// <summary>
	/// How to handle missing members
	/// </summary>
	public JsonMissingMemberHandling JsonMissingMemberHandling { get; set; } = JsonMissingMemberHandling.Ignore;

	/// <summary>
	/// The LogLevel at which response JSON will be logged when missing members are encountered. Defaults to None.
	/// </summary>
	public LogLevel JsonMissingMemberResponseLogLevel { get; set; } = LogLevel.None;

	/// <summary>
	/// A rate limiter to apply to all requests made by this client.
	/// This can be shared th other clients to ensure that the rate limit is respected across multiple clients.
	/// </summary>
	public IRateLimiter? RateLimiter { get; set; }

	/// <summary>
	/// This gets called when JsonMissingMemberHandling is not Ignore and a missing member occurs
	/// </summary>
	public Action<Type, JsonSerializationException, string>? JsonMissingMemberAction { get; set; }

	/// <summary>
	/// The timeout applied to each individual attempt, in seconds. Defaults to 25.
	/// </summary>
	/// <remarks>
	/// An attempt that exceeds this is abandoned, waited out using the back-off settings, and retried
	/// up to <see cref="MaxAttemptCount"/> times, after which a <see cref="TimeoutException"/> is thrown.
	/// Increase this if you call endpoints that legitimately take a long time to respond. Contrast with
	/// <see cref="HttpClientTimeoutSeconds"/>, which bounds the whole call across all attempts.
	/// </remarks>
	public double HttpClientInnerTimeoutSeconds { get; set; } = 25;

	/// <summary>
	/// Validates the configuration
	/// </summary>
	/// <exception cref="ConfigurationException"></exception>
	public void Validate()
	{
		// Authentication - either ApiKey or AccessToken must be set, but not both
		var hasApiKey = !string.IsNullOrWhiteSpace(ApiKey);
		var hasAccessToken = !string.IsNullOrWhiteSpace(AccessToken);

		if (!hasApiKey && !hasAccessToken)
		{
			throw new ConfigurationException($"Either {nameof(ApiKey)} or {nameof(AccessToken)} must be set.");
		}

		if (hasApiKey && hasAccessToken)
		{
			throw new ConfigurationException($"Only one of {nameof(ApiKey)} or {nameof(AccessToken)} can be set, not both.");
		}

		// MaxBackoffDelay
		if (MaxBackOffDelaySeconds < 0)
		{
			throw new ConfigurationException($"{nameof(MaxBackOffDelaySeconds)} should not be less than zero.");
		}

		if (HttpClientInnerTimeoutSeconds < 0)
		{
			throw new ConfigurationException($"{nameof(HttpClientInnerTimeoutSeconds)} should not be less than zero.");
		}

		if (HttpClientTimeoutSeconds <= 0)
		{
			throw new ConfigurationException($"{nameof(HttpClientTimeoutSeconds)} should be greater than zero.");
		}

		// Zero or negative would make the retry guard true on the first pass, so no attempt would ever be retried.
		if (MaxAttemptCount < 1)
		{
			throw new ConfigurationException($"{nameof(MaxAttemptCount)} should be at least one.");
		}
	}
}
