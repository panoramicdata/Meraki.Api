using Meraki.Api.Exceptions;
using Meraki.Api.Test.Config;
using Meraki.Api.Test.Logging;
using Microsoft.Extensions.Logging;

namespace Meraki.Api.Test;

public abstract class MerakiClientTest(ITestOutputHelper testOutputHelper) : IAsyncLifetime
{
	protected ITestOutputHelper TestOutputHelper { get; } = testOutputHelper;

	protected DateTimeOffset UtcNow { get; } = DateTimeOffset.UtcNow;

	protected DateTimeOffset Utc10DaysAgo => UtcNow - TimeSpan.FromDays(10);

	private MerakiClient? _merakiClient;

	private ILogger? _logger;

	internal TestConfig Configuration { get; private set; } = null!;

	protected static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	public virtual ValueTask InitializeAsync()
	{
		Configuration = TestConfigLoader.Load();
		_logger = CreateLogger();

		return ValueTask.CompletedTask;
	}

	public virtual async ValueTask DisposeAsync()
	{
		if (_merakiClient != null)
		{
			await Task.Run(_merakiClient.Dispose);
		}

		GC.SuppressFinalize(this);
	}

	private ILogger CreateLogger()
		=> LoggerFactory.Create(builder => _ = builder
			.AddProvider(new XunitLoggerProvider(TestOutputHelper))
			.SetMinimumLevel(LogLevel.Debug)).CreateLogger<MerakiClientTest>();

	protected MerakiClient TestMerakiClient
	{
		get
		{
			if (_merakiClient != null)
			{
				return _merakiClient;
			}

			// Unit tests should always error if members are missing to aid picking up issues with models early
			Configuration.MerakiClientOptions.JsonMissingMemberHandling = JsonMissingMemberHandling.ThrowOnError;
			// Log the response JSON so we can see what's going on
			Configuration.MerakiClientOptions.JsonMissingMemberResponseLogLevel = Microsoft.Extensions.Logging.LogLevel.Critical;

			return _merakiClient = new MerakiClient(Configuration.MerakiClientOptions, _logger);
		}
	}

	protected async Task<Network> GetFirstNetworkAsync()
	{
		var networks = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		_ = networks.Should().NotBeNull();
		_ = networks.Should().NotBeEmpty();
		return networks[0];
	}

	protected async Task<Network> CreateTestNetworkAsync()
	{
		var network = await TestMerakiClient
			.Organizations
			.Networks
			.CreateOrganizationNetworkAsync(
				Configuration.TestOrganizationId,
				new NetworkCreationRequest
				{
					Name = $"XUnit {Guid.NewGuid()}",
					ProductTypes =
					[
						ProductType.Appliance,
						ProductType.Switch,
						ProductType.Camera
					],
					Notes = $"Created as part of unit testing on {DateTime.UtcNow}, should be removed automatically"
				}
			)
			.ConfigureAwait(false);
		_ = network.Should().NotBeNull();
		return network;
	}

	protected Task RemoveNetworkAsync(string networkId)
		=> TestMerakiClient
			.Networks
			.DeleteNetworkAsync(networkId);

	protected static string DnsServer => string.Join('.', _sourceArray.Select(_ => 8));
	protected static string PrivateNetworkFirst3Octets => "10.1.2";
	protected static string SubnetMaskFirst3Octets => "255.255.255";

	private static readonly int[] _sourceArray = [0, 1, 2, 3];
}
