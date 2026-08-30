namespace Meraki.Api.Mcp;

/// <summary>
/// Options for <see cref="MerakiMcpClient"/>.
/// </summary>
/// <remarks>
/// These deliberately mirror <see cref="MerakiClientOptions"/> so that the REST client and the
/// MCP client are configured in the same way.
/// </remarks>
public class MerakiMcpClientOptions
{
	/// <summary>
	/// The default Cisco-hosted MCP server endpoint.
	/// </summary>
	public static readonly string DefaultHostedUri = "https://mcp.meraki.com/mcp";

	/// <summary>
	/// The transport to use. Defaults to <see cref="MerakiMcpTransport.HostedHttp"/>.
	/// </summary>
	public MerakiMcpTransport Transport { get; set; } = MerakiMcpTransport.HostedHttp;

	/// <summary>
	/// The MCP server endpoint. Defaults to <see cref="DefaultHostedUri"/>.
	/// Required when <see cref="Transport"/> is <see cref="MerakiMcpTransport.LocalHttp"/>.
	/// Ignored when <see cref="Transport"/> is <see cref="MerakiMcpTransport.Stdio"/>.
	/// </summary>
	public string Uri { get; set; } = DefaultHostedUri;

	/// <summary>
	/// The Meraki Dashboard API key, sent as "Authorization: Bearer {ApiKey}".
	/// The Meraki MCP server supports API key authentication only; OAuth is not yet supported.
	/// </summary>
	public string ApiKey { get; set; } = string.Empty;

	/// <summary>
	/// The API Region. Only <see cref="ApiRegion.Default"/> is valid for
	/// <see cref="MerakiMcpTransport.HostedHttp"/>, because the Cisco-hosted server supports
	/// Meraki.com environments only.
	/// </summary>
	public ApiRegion ApiRegion { get; set; } = ApiRegion.Default;

	/// <summary>
	/// An optional User-Agent string to attach to outgoing requests.
	/// As per Meraki's documentation, this should be in the format of "MerakiClient/{version} {company}".
	/// </summary>
	public string? UserAgent { get; set; }

	/// <summary>
	/// The command to launch when <see cref="Transport"/> is <see cref="MerakiMcpTransport.Stdio"/>.
	/// </summary>
	public string? Command { get; set; }

	/// <summary>
	/// Arguments passed to <see cref="Command"/>.
	/// </summary>
	public IList<string> Arguments { get; } = [];

	/// <summary>
	/// The working directory for <see cref="Command"/>.
	/// </summary>
	public string? WorkingDirectory { get; set; }

	/// <summary>
	/// Environment variables for <see cref="Command"/>.
	/// </summary>
	public IDictionary<string, string?> EnvironmentVariables { get; } = new Dictionary<string, string?>(StringComparer.Ordinal);

	/// <summary>
	/// Allow overriding the HttpClient timeout, in seconds. Defaults to 600.
	/// </summary>
	public int HttpClientTimeoutSeconds { get; set; } = 600;

	/// <summary>
	/// When a 429 HTTP status code is returned, the back-off duration doubles on each attempt.
	/// This option sets the maximum back-off duration, in seconds. Defaults to 30.
	/// </summary>
	public int MaxBackOffDelaySeconds { get; set; } = 30;

	/// <summary>
	/// The exponential factor by which the API Retry-After duration is increased on each attempt.
	/// For example 1.0 = no change, 1.5 = 50% increase, 2.0 = double. Defaults to 1.0.
	/// </summary>
	public double BackOffDelayFactor { get; set; } = 1.0;

	/// <summary>
	/// The maximum number of attempts made before giving up. Defaults to 10.
	/// </summary>
	public int MaxAttemptCount { get; set; } = 10;

	/// <summary>
	/// When true (the default), <see cref="MerakiMcpClient.ExecuteApiAsync"/> refuses any capability
	/// whose name does not indicate a read operation.
	/// </summary>
	/// <remarks>
	/// The Meraki MCP server's execute_api tool is read-only by design, and every Meraki Dashboard
	/// GET operation identifier begins with "get". This guard fails fast on the caller's side rather
	/// than waiting for a server-side rejection. It can be disabled should Cisco change that naming
	/// convention during the beta.
	/// </remarks>
	public bool EnforceReadOnlyCapabilityNames { get; set; } = true;

	/// <summary>
	/// How to handle missing members when deserialising responses from the MCP server, which Cisco
	/// documents as beta and subject to breaking change. Defaults to
	/// <see cref="JsonMissingMemberHandling.Ignore"/>.
	/// </summary>
	public JsonMissingMemberHandling JsonMissingMemberHandling { get; set; } = JsonMissingMemberHandling.Ignore;

	/// <summary>
	/// Validates the options, throwing <see cref="ConfigurationException"/> when they are not usable.
	/// </summary>
	/// <exception cref="ConfigurationException">Thrown when the options are not usable.</exception>
	public void Validate()
	{
		ValidateNumericSettings();
		ValidateTransportSettings();
	}

	private void ValidateNumericSettings()
	{
		if (string.IsNullOrWhiteSpace(ApiKey))
		{
			throw new ConfigurationException($"{nameof(ApiKey)} must be set. The Meraki MCP server authenticates with a Meraki Dashboard API key.");
		}

		if (HttpClientTimeoutSeconds <= 0)
		{
			throw new ConfigurationException($"{nameof(HttpClientTimeoutSeconds)} must be greater than zero.");
		}

		if (MaxAttemptCount < 1)
		{
			throw new ConfigurationException($"{nameof(MaxAttemptCount)} must be at least 1.");
		}

		if (MaxBackOffDelaySeconds < 0)
		{
			throw new ConfigurationException($"{nameof(MaxBackOffDelaySeconds)} must not be negative.");
		}

		if (BackOffDelayFactor < 1.0)
		{
			throw new ConfigurationException($"{nameof(BackOffDelayFactor)} must be at least 1.0.");
		}
	}

	private void ValidateTransportSettings()
	{
		switch (Transport)
		{
			case MerakiMcpTransport.HostedHttp:
				ValidateUri();
				ValidateHostedRegion();
				break;

			case MerakiMcpTransport.LocalHttp:
				ValidateUri();
				break;

			case MerakiMcpTransport.Stdio:
				if (string.IsNullOrWhiteSpace(Command))
				{
					throw new ConfigurationException($"{nameof(Command)} must be set when {nameof(Transport)} is {nameof(MerakiMcpTransport.Stdio)}.");
				}

				break;

			default:
				throw new ConfigurationException($"{nameof(Transport)} value '{Transport}' is not supported.");
		}
	}

	private void ValidateHostedRegion()
	{
		if (ApiRegion == ApiRegion.Default)
		{
			return;
		}

		throw new ConfigurationException(
			$"The Cisco-hosted Meraki MCP server supports Meraki.com environments only, so {nameof(ApiRegion)} must be {nameof(ApiRegion.Default)} when {nameof(Transport)} is {nameof(MerakiMcpTransport.HostedHttp)}. " +
			$"The {ApiRegion} region requires a self-hosted server: set {nameof(Transport)} to {nameof(MerakiMcpTransport.LocalHttp)} or {nameof(MerakiMcpTransport.Stdio)}.");
	}

	private void ValidateUri()
	{
		if (string.IsNullOrWhiteSpace(Uri))
		{
			throw new ConfigurationException($"{nameof(Uri)} must be set when {nameof(Transport)} is {Transport}.");
		}

		if (!System.Uri.TryCreate(Uri, UriKind.Absolute, out var parsed))
		{
			throw new ConfigurationException($"{nameof(Uri)} value '{Uri}' is not a valid absolute URI.");
		}

		if (parsed.Scheme != System.Uri.UriSchemeHttp && parsed.Scheme != System.Uri.UriSchemeHttps)
		{
			throw new ConfigurationException($"{nameof(Uri)} value '{Uri}' must use the http or https scheme.");
		}
	}
}
