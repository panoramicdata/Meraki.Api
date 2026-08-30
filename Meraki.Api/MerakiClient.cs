using Meraki.Api.Extensions;
using Meraki.Api.Sections.General.LiveTools;
using Meraki.Api.Sections.Products.Licensing;
using Meraki.Api.Sections.SecureConnect;
using Meraki.Api.Workflows;

namespace Meraki.Api;

/// <summary>
/// A Meraki Dashboard API client. This is your starting point for all API operations.
/// Example usage:
///
/// ```csharp
/// using Meraki.Api;
/// using System;
/// using System.Threading.Tasks;
///
/// namespace My.Project;
/// public static class Program
/// {
///     public static async Task Main()
///     {
///         using var merakiClient = new MerakiClient(
///             new MerakiClientOptions
///             {
///                 ApiKey = "&lt;your 40-character Meraki API key&gt;",
///                 UserAgent = "YourProductName/YourProductVersion YourCompanyName"
///             }
///         );
///
///         var organizations = await merakiClient
///             .Organizations
///             .GetOrganizationsAsync()
///             .ConfigureAwait(false);
///
///         var firstOrganization = organizations[0];
///
///         var devices = await merakiClient
///             .Organizations
///             .Devices
///             .GetOrganizationDevicesAsync(firstOrganization.Id)
///             .ConfigureAwait(false);
///
///         Console.WriteLine("Devices:");
///         foreach (var device in devices)
///         {
///             Console.WriteLine($"    - {device.Serial}: {device.Name}");
///         }
///     }
/// }
/// ```
/// </summary>
public partial class MerakiClient : IDisposable
{
	private readonly MerakiClientOptions _options;
	private readonly ILogger _logger;
	private readonly HttpClient _coreHttpClient;
	private readonly HttpClient _workflowsHttpClient;
	private readonly HttpClient _secureConnectHttpClient;
	private readonly AuthenticatedBackingOffHttpClientHandler _httpClientHandler;

	/// <summary>
	/// Gets the URI of the last API request made by this client
	/// </summary>
	public string LastRequestUri => _httpClientHandler.LastRequestUri;

	/// <summary>
	/// Gets statistics about API requests made by this client
	/// </summary>
	public MerakiClientStatistics Statistics => _httpClientHandler.Statistics;

	/// <summary>
	/// Gets the api client version
	/// </summary>

	public string ApiClientVersion { get; private set; }

	/// <summary>
	/// A Meraki portal client
	/// </summary>
	public MerakiClient(MerakiClientOptions options, ILogger? logger = default)
	{
		var apiClientVersion = new System.Version(ThisAssembly.AssemblyFileVersion);
		ApiClientVersion = $"{apiClientVersion.Major}.{apiClientVersion.Minor}.{apiClientVersion.Build}";

		_options = options;
		_logger = logger ?? NullLogger.Instance;
		_httpClientHandler = new AuthenticatedBackingOffHttpClientHandler(options ?? throw new ArgumentNullException(nameof(options)), this, _logger);

		var merakiDomain = options.ApiRegion.GetMerakiApiDomain()
			?? throw new ArgumentOutOfRangeException($"Unsupported API Region {options.ApiRegion}");

		// Set up the core HttpClient, this is used to communicate with most of the API
		_coreHttpClient = new HttpClient(_httpClientHandler)
		{
			BaseAddress = new Uri($"https://api.{merakiDomain}/api/v1"),
			Timeout = TimeSpan.FromSeconds(options.HttpClientTimeoutSeconds)
		};

		// Set up the SecureConnect HttpClient
		_secureConnectHttpClient = new HttpClient(_httpClientHandler)
		{
			BaseAddress = new Uri($"https://api.{merakiDomain}/api/secureConnect/v1"),
			Timeout = TimeSpan.FromSeconds(options.HttpClientTimeoutSeconds)
		};

		// Cisco Workflows is a separate, organization-scoped API surface. The generated client
		// supplies the organization ID in every route; this base address supplies the dedicated
		// /api/automate prefix. The shared handler selects Bearer authentication for these paths.
		_workflowsHttpClient = new HttpClient(_httpClientHandler)
		{
			BaseAddress = new Uri($"https://api.{merakiDomain}/api/automate/organizations/"),
			Timeout = TimeSpan.FromSeconds(options.HttpClientTimeoutSeconds)
		};

		Workflows = new MerakiWorkflowsApiClient(_workflowsHttpClient);

		_refitSettings = new RefitSettings
		{
			ContentSerializer = new CustomNewtonsoftJsonContentSerializer(_options, _logger),
			CollectionFormat = CollectionFormat.Multi
		};

		// General level sections //
		Devices = BuildDevicesSection();

		Organizations = BuildOrganizationsSection();

		Networks = BuildNetworksSection();

		// Product level sections //
		Appliance = BuildApplianceSection();

		Camera = BuildCameraSection();

		CellularGateway = BuildCellularGatewaySection();

		SecureConnect = BuildSecureConnectSection();

		Switch = BuildSwitchSection();

		Wireless = BuildWirelessSection();

		Insight = BuildInsightSection();

		Licensing = BuildLicensingSection();

		LiveTools = BuildLiveToolsSection();

		Sensor = BuildSensorSection();

		Sm = BuildSmSection();
	}

	// S1172 sees the parameter as unused, but it is what lets every call site infer T from the
	// section property it passes in; its value is deliberately ignored.
#pragma warning disable S1172 // Unused method parameters should be removed
	private T RefitFor<T>(T _) =>
		typeof(T).IsInterface
			? RestService.For<T>(_coreHttpClient, _refitSettings)
			: throw new ArgumentException($"Type {typeof(T).Name} must be an interface", nameof(_));

	private T RefitSecureConnectFor<T>(T _)
	=> RestService.For<T>(_secureConnectHttpClient, _refitSettings);
#pragma warning restore S1172 // Unused method parameters should be removed

	private readonly RefitSettings _refitSettings;

	/// <summary>
	/// Gets the appliance
	/// </summary>

	public ApplianceSection Appliance { get; } = new();

	/// <summary>
	/// Generate a snapshot of what the camera sees at the specified time and return a link to that image.
	/// </summary>

	public CameraSection Camera { get; } = new();

	/// <summary>
	/// Gets the cellular gateway
	/// </summary>

	public CellularGatewaySection CellularGateway { get; } = new();

	/// <summary>
	/// Return a single device
	/// </summary>

	public DevicesSection Devices { get; } = new();

	/// <summary>
	/// Gets the insight
	/// </summary>

	public InsightSection Insight { get; } = new();

	/// <summary>
	/// Gets the licensing
	/// </summary>

	public LicensingSection Licensing { get; } = new();

	/// <summary>
	/// Gets the live tools
	/// </summary>

	public LiveToolsSection LiveTools { get; } = new();

	/// <summary>
	/// Return a network
	/// </summary>

	public NetworksSection Networks { get; } = new();

	/// <summary>
	/// List the organizations that the user has privileges on
	/// </summary>

	public OrganizationsSection Organizations { get; } = new();

	/// <summary>
	/// Gets the sensor
	/// </summary>

	public SensorSection Sensor { get; } = new();

	/// <summary>
	/// Gets the sm
	/// </summary>

	public SmSection Sm { get; } = new();

	/// <summary>
	/// Gets the secure connect
	/// </summary>

	public SecureConnectSection SecureConnect { get; } = new();

	/// <summary>
	/// Gets the typed Cisco Workflows Automation API client.
	/// </summary>
	/// <remarks>
	/// Workflows operations require full access to the organization and Bearer authentication.
	/// The client covers the complete Cisco Workflows OpenAPI specification, including workflows,
	/// instances, targets, variables, schedules, rules, triggers, tables, and Exchange operations.
	/// </remarks>
	public IMerakiWorkflowsApiClient Workflows { get; }

	/// <summary>
	/// Gets the switch
	/// </summary>

	public SwitchSection Switch { get; } = new();

	/// <summary>
	/// Gets the wireless
	/// </summary>

	public WirelessSection Wireless { get; } = new();

	/// <summary>
	/// Used to find out whether the client has the ReadOnly option set
	/// </summary>
	public bool IsReadOnly => _options.ReadOnly;

	/// <summary>
	/// Gets the last response headers
	/// </summary>

	public HttpResponseHeaders? LastResponseHeaders { get; set; }

	/// <summary>
	/// Used to change the Options Readonly state after client is created
	/// </summary>
	public void SetReadOnly(bool readOnly)
		=> _options.ReadOnly = readOnly;

	#region IDisposable Support
	private bool _disposedValue; // To detect redundant calls

	/// <summary>
	/// Releases the unmanaged resources used by the MerakiClient and optionally releases the managed resources
	/// </summary>
	/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!_disposedValue)
		{
			if (disposing)
			{
				_coreHttpClient.Dispose();
				_workflowsHttpClient.Dispose();
				_secureConnectHttpClient.Dispose();
				_httpClientHandler.Dispose();
			}

			_disposedValue = true;
		}
	}

	// This code added to correctly implement the disposable pattern.
	/// <summary>
	/// Dispose
	/// </summary>
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
		Dispose(true);

		GC.SuppressFinalize(this);
	}
	#endregion
}
