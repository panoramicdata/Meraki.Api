namespace Meraki.Api;

/// <summary>
/// MerakiClient options
/// </summary>
public class MerakiClientOptions
{
	/// <summary>
	/// The API Node (e.g. "n72").
	/// This is optional, but highly recommended as directly addressing the correct instance will reduce propagation delays.
	/// If this is NOT provided, you may experience 404 errors when accessing recently-added objects.
	/// </summary>
	public string? ApiNode { get; set; }

	/// <summary>
	/// An optional User-Agent string to attach to outgoing requests.
	/// </summary>
	public string? UserAgent { get; set; }

	/// <summary>
	/// The API key
	/// </summary>
	public string ApiKey { get; set; } = string.Empty;

	/// <summary>
	/// Allow overriding the HttpClient Timeout - defaults to 300 seconds
	/// </summary>
	public int HttpClientTimeoutSeconds { get; set; } = 300;

	/// <summary>
	/// When a 429 HttpStatus code is sent, the back-off duration doubles on each attempt.
	/// This option sets the maximum back-off duration.
	/// </summary>
	public TimeSpan MaxBackOffDelay { get; set; } = TimeSpan.FromSeconds(5);

	/// <summary>
	/// When retrying
	/// </summary>
	public int MaxAttemptCount { get; set; } = 5;

	/// <summary>
	/// When true, only GETs are permitted
	/// </summary>
	public bool ReadOnly { get; set; }

	/// <summary>
	/// How to handle missing members - defaults to ignore for release builds and error for debug builds of the library
	/// </summary>
	public MissingMemberHandling MissingMemberHandling { get; set; }
#if DEBUG
		= MissingMemberHandling.Error;
#else
		= MissingMemberHandling.Ignore;
#endif

	public void Validate()
	{
		// ApiNode
		if (ApiNode != null && string.IsNullOrWhiteSpace(ApiNode))
		{
			throw new ConfigurationException($"Missing {nameof(ApiNode)}.  If not required, set {nameof(ApiNode)} to null.");
		}

		// ApiKey
		if (string.IsNullOrWhiteSpace(ApiKey))
		{
			throw new ConfigurationException($"Missing {nameof(ApiKey)}.");
		}

		// MaxBackoffDelay
		if (MaxBackOffDelay < TimeSpan.Zero)
		{
			throw new ConfigurationException($"{nameof(MaxBackOffDelay)} should not be less than zero.");
		}
	}
}
