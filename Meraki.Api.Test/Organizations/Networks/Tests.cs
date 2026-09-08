namespace Meraki.Api.Test.Organizations.Networks;

// Codacy analyses each file on its own, so it cannot see the other part of this class and
// reports 'partial' as gratuitous (S2333). The other part is Tests.CreateClaimRemoveDelete.cs.
#pragma warning disable S2333
public partial class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetNetworksAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAllAsync(Configuration.TestOrganizationId, cancellationToken: CancellationToken);

		_ = result.Should().BeOfType<List<Network>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
		var firstResult = result[0];
		ValidateNetwork(firstResult);
	}

	internal static void ValidateNetwork(Network network)
	{
		_ = network.Should().NotBeNull();
		_ = network.Id.Should().NotBeNullOrWhiteSpace();
		_ = network.Name.Should().NotBeNullOrWhiteSpace();
		_ = network.OrganizationId.Should().NotBeNullOrWhiteSpace();
		_ = network.TimeZone.Should().NotBeNullOrWhiteSpace();
	}

	[Fact]
	public async Task GetAllSsidsAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync();

		var result = await TestMerakiClient
			.Wireless
			.Ssids
			.GetNetworkWirelessSsidsAsync(network.Id, cancellationToken: CancellationToken);
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetAllDevicesAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync();

		var result = await TestMerakiClient
			.Networks
			.Devices
			.GetNetworkDevicesAsync(network.Id, cancellationToken: CancellationToken);
		_ = result.Should().BeOfType<List<Device>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task SimpleCreateDelete_Succeeds()
	{
		var networkName = new string('X', Network.MaxNameLength);

		await EnsureNetworkRemovedAsync(networkName);

		// Create network
		var newNetwork = await TestMerakiClient
			.Organizations
			.Networks
			.CreateOrganizationNetworkAsync(
				Configuration.TestOrganizationId,
				new NetworkCreationRequest
				{
					Name = networkName,
					ProductTypes = [ProductType.Wireless],
					Tags = [],
					TimeZone = "Europe/London"
				}, cancellationToken: CancellationToken);

		// And delete it again
		await TestMerakiClient
			.Networks
			.DeleteNetworkAsync(newNetwork.Id, cancellationToken: CancellationToken);
	}

	[Fact]
	public Task NameTooLong_Fails()
	{
		var networkName = new string('X', Network.MaxNameLength + 1);

		Func<Task> action = async () => _ = await TestMerakiClient
			.Organizations
			.Networks
			.CreateOrganizationNetworkAsync(
				Configuration.TestOrganizationId,
				new NetworkCreationRequest
				{
					Name = networkName,
					Tags = [],
					TimeZone = "Europe/London"
				});

		return action
			.Should()
			.ThrowAsync<ApiException>();
	}

	private async Task EnsureNetworkRemovedAsync(string networkName)
	{
		// Perform any clean-up
		var networks = await TestMerakiClient
						.Organizations
						.Networks
						.GetOrganizationNetworksAsync(Configuration.TestOrganizationId)
						.ConfigureAwait(false);
		var oldNetwork = networks.SingleOrDefault(n => n.Name == networkName);
		if (oldNetwork != default)
		{
			// Get all network devices and remove them
			var oldNetworkDevices = await TestMerakiClient
				.Networks
				.Devices
				.GetNetworkDevicesAsync(oldNetwork.Id)
				.ConfigureAwait(false);
			foreach (var oldNetworkDevice in oldNetworkDevices)
			{
				await TestMerakiClient
					.Networks
					.Devices
					.RemoveNetworkDevicesAsync(
						oldNetwork.Id,
						new DeviceRemovalRequest
						{
							Serial = oldNetworkDevice.Serial
								?? throw new InvalidDataException("Expected serial number")
						})
					.ConfigureAwait(false);
			}

			await TestMerakiClient
				.Networks
				.DeleteNetworkAsync(oldNetwork.Id)
				.ConfigureAwait(false);
		}
	}

	[Fact]
	public async Task GetClientsAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync();

		var result = await TestMerakiClient
			.Networks
			.Clients
			.GetNetworkClientsAsync(network.Id, cancellationToken: CancellationToken);
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetBluetoothClientsAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync();

		var result = await TestMerakiClient
			.Networks
			.BluetoothClients
			.GetNetworkBluetoothClientsAsync(network.Id, cancellationToken: CancellationToken);
		_ = result.Should().BeOfType<List<BluetoothClient>>();
		_ = result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetWirelessSettingsAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync();

		// Get the wireless settings
		var originalResult = await TestMerakiClient
			.Wireless
			.Settings
			.GetNetworkWirelessSettingsAsync(network.Id, cancellationToken: CancellationToken);
		_ = originalResult.Should().BeOfType<WirelessSettings>();
		_ = originalResult.Should().NotBeNull();
		_ = originalResult.Should().BeOfType<List<BluetoothClient>>();

		// Re-set the wireless settings (to the same values)
		var newResult = await TestMerakiClient
			.Wireless
			.Settings
			.UpdateNetworkWirelessSettingsAsync(network.Id, new WirelessSettingsUpdateDto
			{
				Ipv6BridgeEnabled = originalResult.Ipv6BridgeEnabled,
				LedLightsOn = originalResult.LedLightsOn,
				LocationAnalyticsEnabled = originalResult.LocationAnalyticsEnabled,
				MeshingEnabled = originalResult.MeshingEnabled,
			}, cancellationToken: CancellationToken);
		_ = newResult.Should().BeOfType<WirelessSettings>();
		_ = newResult.Should().NotBeNull();

		// The two should match
		_ = newResult.MeshingEnabled.Should().Be(originalResult.MeshingEnabled);
		_ = newResult.Ipv6BridgeEnabled.Should().Be(originalResult.Ipv6BridgeEnabled);
		_ = newResult.LocationAnalyticsEnabled.Should().Be(originalResult.LocationAnalyticsEnabled);
	}

	[Fact]
	public async Task GetCameraSnapshotAsync_Succeeds()
	{
		if (OperatingSystem.IsWindows())
		{
			// Get a snapshot from the camera
			var newResult = await TestMerakiClient
				.Camera
				.GenerateDeviceCameraSnapshotAsync(
					Configuration.TestCameraSerial,
					new CameraSnapshotRequest { Fullframe = true },
					cancellationToken: CancellationToken);
			_ = newResult.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task GetCameraVideoLinkAsync_Succeeds()
	{
		_ = Configuration.TestCameraNetworkId.Should().NotBeNull();

		// Get a snapshot from the camera
		var newResult = await TestMerakiClient
		.Camera
		.VideoLink
		.GetDeviceCameraVideoLinkAsync(
			Configuration.TestCameraNetworkId,
			Configuration.TestCameraSerial,
			cancellationToken: CancellationToken);
		_ = newResult.Should().NotBeNull();
	}

	[Fact]
	public async Task GetRepeatedlyInQuickSuccession_Succeeds()
	{
		foreach (var __ in Enumerable.Range(0, 10))
		{
			_ = await GetFirstNetworkAsync();
		}
	}

	[Fact]
	public async Task GetDeviceSwitchPortsAsync_Succeeds()
	{
		_ = Configuration.TestSwitchSerial.Should().NotBeNull();

		var switchPorts = await TestMerakiClient
			.Switch.Ports
			.GetDeviceSwitchPortsAsync(Configuration.TestSwitchSerial, cancellationToken: CancellationToken);

		_ = switchPorts.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkSwitchStacksAsync_Succeeds()
	{
		_ = Configuration.TestCameraNetworkId.Should().NotBeNull();

		var switchStacks = await TestMerakiClient
			.Switch.Stacks
			.GetNetworkSwitchStacksAsync(Configuration.TestCameraNetworkId, cancellationToken: CancellationToken);

		_ = switchStacks.Should().NotBeNull();
	}

	[Fact]
	public async Task ReadOnlyStopsCreate_Succeeds()
	{
		var originalIsReadOnly = TestMerakiClient.IsReadOnly;
		TestMerakiClient.SetReadOnly(true);
		try
		{
			// Create network
			var act = () => TestMerakiClient
				.Organizations
				.Networks
				.CreateOrganizationNetworkAsync(
					Configuration.TestOrganizationId,
					new NetworkCreationRequest
					{
						Name = Guid.NewGuid().ToString(),
						ProductTypes = [ProductType.Wireless],
						Tags = [],
						TimeZone = "Europe/London",
						Notes = $"Created at {DateTime.UtcNow:u} during unit testing, OK to delete"
					},
					cancellationToken: CancellationToken);

			_ = await act
				.Should()
				.ThrowExactlyAsync<InvalidOperationException>()
				.WithMessage("The client options have been configured to only allow read actions");
		}
		finally
		{
			// Restore the original ReadOnly state
			TestMerakiClient.SetReadOnly(originalIsReadOnly);
		}
	}

	[Fact]
	public async Task GetAllPagesForNetworksAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.GetAllAsync(
				(perPage, startingAfter, endingBefore, cancellationToken)
				=> TestMerakiClient
					.Organizations
					.Networks
					.GetOrganizationNetworksAsync(
						Configuration.TestOrganizationId,
						perPage: perPage,
						startingAfter: startingAfter,
						endingBefore: endingBefore,
						cancellationToken: cancellationToken
					),
				3,
				CancellationToken.None
			);

		_ = result.Should().BeOfType<List<Network>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
		var firstResult = result[0];
		ValidateNetwork(firstResult);
	}

	[Fact]
	public async Task GetAllPagesWithDefaultPerPage_ForNetworksAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> TestMerakiClient
					.Organizations
					.Networks
					.GetOrganizationNetworksAsync(
						Configuration.TestOrganizationId,
						startingAfter: startingAfter,
						endingBefore: endingBefore,
						cancellationToken: cancellationToken
					),
				CancellationToken.None
			);

		_ = result.Should().BeOfType<List<Network>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
		var firstResult = result[0];
		ValidateNetwork(firstResult);
	}

	[Fact]
	public async Task GetAllNetworksAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAllAsync(Configuration.TestOrganizationId, cancellationToken: CancellationToken);

		_ = result.Should().BeOfType<List<Network>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
		var firstResult = result[0];
		ValidateNetwork(firstResult);
	}
}
#pragma warning restore S2333
