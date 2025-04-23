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
	/// This is optional, but highly recommended as directly addressing the correct instance will reduce propagation delays.
	/// If this is NOT provided, you may experience 404 errors when accessing recently-added objects.
	/// </summary>
	public string? ApiNode { get; set; }

	/// <summary>
	/// An optional User-Agent string to attach to outgoing requests.
	/// As per Meraki's documentation, this should be in the format of "MerakiClient/{version} {company}".
	/// See <see href="https://developer.cisco.com/meraki/api-v1/user-agents-overview/#formatting">Meraki API User-Agent Formatting</see>.
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
	/// This option sets the maximum back-off duration. Defaults to 30
	/// </summary>
	public int MaxBackOffDelaySeconds { get; set; } = 30;

	/// <summary>
	/// This is the exponential factor by which the API Retry-After duration is increased on each attempt.
	/// e.g. 1.0 = no change, 1.5 = 50% increase, 2.0 = double
	/// Defaults to 1.0
	/// </summary>
	public double BackOffDelayFactor { get; set; } = 1.0;

	/// <summary>
	/// When retrying
	/// </summary>
	public int MaxAttemptCount { get; set; } = 5;

	/// <summary>
	/// When true, only GETs are permitted
	/// </summary>
	public bool ReadOnly { get; set; }

	/// <summary>
	/// How to handle missing members
	/// </summary>
	public JsonMissingMemberHandling JsonMissingMemberHandling { get; set; } = JsonMissingMemberHandling.Ignore;

	/// <summary>
	/// The LogLevel at which response JSON will be logged when missing members are encountered. Defaults to None.
	/// </summary>
	public LogLevel JsonMissingMemberResponseLogLevel { get; set; } = LogLevel.None;

	/// <summary>
	/// This gets called when JsonMissingMemberHandling is not Ignore and a missing member occurs
	/// </summary>
	public Action<Type, JsonSerializationException, string>? JsonMissingMemberAction { get; set; }

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
		if (MaxBackOffDelaySeconds < 0)
		{
			throw new ConfigurationException($"{nameof(MaxBackOffDelaySeconds)} should not be less than zero.");
		}
	}
}
