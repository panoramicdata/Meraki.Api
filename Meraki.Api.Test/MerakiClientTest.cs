﻿using Meraki.Api.Exceptions;
using Meraki.Api.Test.Config;
using Meraki.Api.Test.Logging;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Meraki.Api.Test;

public abstract class MerakiClientTest(ITestOutputHelper _iTestOutputHelper) : IDisposable
{
	protected DateTimeOffset UtcNow { get; } = DateTimeOffset.UtcNow;

	protected DateTimeOffset Utc10DaysAgo => UtcNow - TimeSpan.FromDays(10);

	private MerakiClient? _merakiClient;

	private bool _disposedValue;

	private readonly ILogger _logger = new LoggerFactory()
			.AddXUnit(_iTestOutputHelper)
			.CreateLogger<MerakiClientTest>();

	internal TestConfig Configuration { get; } = LoadConfig();

	protected CancellationToken CancellationToken { get; } = TestContext.Current.CancellationToken;

	private static TestConfig LoadConfig()
	{
		// Load config from file
		var fileInfo = new FileInfo("../../../appsettings.json");

		// Does the config file exist?
		if (!fileInfo.Exists)
		{
			// No - hint to the user what to do
			throw new ConfigurationException("Missing appsettings.json.  Please copy the appsettings.example.json in the project root folder and set the various values appropriately.");
		}
		// Yes

		// Load in the config
		var configuration = JsonConvert.DeserializeObject<TestConfig>(File.ReadAllText(fileInfo.FullName))
			?? throw new ConfigurationException("Configuration did not deserialize");

		configuration.Validate();

		return configuration;
	}

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
			.DeleteNetworkAsync(networkId)
;

	protected static string DnsServer => string.Join('.', _sourceArray.Select(_ => 8));
	protected static string PrivateNetworkFirst3Octets => "10.1.2";
	protected static string SubnetMaskFirst3Octets => "255.255.255";

	private static readonly int[] _sourceArray = [0, 1, 2, 3];

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposedValue)
		{
			if (disposing)
			{
				_merakiClient?.Dispose();
			}

			_disposedValue = true;
		}
	}

	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
