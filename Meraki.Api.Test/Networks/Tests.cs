namespace Meraki.Api.Test.Networks;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
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
				},
				cancellationToken: CancellationToken);

		// And delete it again
		await TestMerakiClient
			.Networks
			.DeleteNetworkAsync(newNetwork.Id, cancellationToken: CancellationToken);
	}

	[Fact]
	public Task NameTooLong_Fails()
	{
		var networkName = new string('X', Network.MaxNameLength + 1);

		Func<Task> action = async ()
			=> _ = await TestMerakiClient
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
						.GetOrganizationNetworksAsync(
							Configuration.TestOrganizationId,
							cancellationToken: CancellationToken);
		var oldNetwork = networks.SingleOrDefault(n => n.Name == networkName);
		if (oldNetwork != default)
		{
			// Get all network devices and remove them
			var oldNetworkDevices = await TestMerakiClient
				.Networks
				.Devices
				.GetNetworkDevicesAsync(
					oldNetwork.Id,
					cancellationToken: CancellationToken);
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
						},
						cancellationToken: CancellationToken);
			}

			await TestMerakiClient
				.Networks
				.DeleteNetworkAsync(
					oldNetwork.Id,
					cancellationToken: CancellationToken);
		}
	}

	[Fact]
	public async Task CreateClaimRemoveDelete_Succeeds()
	{
		const string networkName = "Meraki.Api Unit Test";

		await AssertTestDeviceIsInInventoryAsync();

		// Perform any clean-up
		await EnsureNetworkRemovedAsync(networkName);

		var newNetwork = await CreateAndVerifyNetworkAsync(networkName);

		await BindConfigurationTemplateAsync(newNetwork.Id);
		await UpdateDefaultVlanAsync(newNetwork.Id);

		var fetchedDevice = await ClaimAndFetchDeviceAsync(newNetwork.Id);
		await AssertDeviceAddressLengthIsEnforcedAsync(fetchedDevice);
		await UpdateAndVerifyManagementInterfaceAsync(newNetwork.Id, fetchedDevice.Serial!);
		await AssertDeviceIsListedForOrganizationAsync();

		// ----------
		// Create complete - now undo everything
		// ----------
		await UnbindAndDeleteNetworkAsync(newNetwork.Id);
	}

	private async Task AssertTestDeviceIsInInventoryAsync()
	{
		var devices = await TestMerakiClient
			.Organizations
			.InventoryDevices
			.GetOrganizationInventoryDevicesAsync(Configuration.TestOrganizationId, cancellationToken: CancellationToken);
		var device = devices.SingleOrDefault(d => d.Serial == Configuration.TestDeviceSerial);
		_ = device.Should().NotBeNull();
	}

	private async Task<Network> CreateAndVerifyNetworkAsync(string networkName)
	{
		var newNetwork = await TestMerakiClient
			.Organizations
			.Networks
			.CreateOrganizationNetworkAsync(
				Configuration.TestOrganizationId,
			new NetworkCreationRequest
			{
				Name = networkName,
				Tags = [],
				TimeZone = "Europe/London",
				ProductTypes = [ProductType.Wireless]
			}, cancellationToken: CancellationToken);

		_ = newNetwork.Should().NotBeNull();

		// Re-fetch the network
		var refetchedNetwork = await TestMerakiClient
			.Networks
			.GetNetworkAsync(newNetwork.Id, cancellationToken: CancellationToken);

		_ = newNetwork.Name.Should().Be(refetchedNetwork.Name);

		return newNetwork;
	}

	private async Task BindConfigurationTemplateAsync(string networkId)
	{
		var configurationTemplates = await TestMerakiClient
			.Organizations
			.ConfigTemplates
			.GetOrganizationConfigTemplatesAsync(Configuration.TestOrganizationId, cancellationToken: CancellationToken);
		_ = configurationTemplates.Should().NotBeNull();
		_ = configurationTemplates.Should().NotBeEmpty();

		var configurationTemplate = configurationTemplates[0];
		await TestMerakiClient
			.Networks
			.BindNetworkAsync(
				networkId,
				new ConfigurationTemplateBindRequest
				{
					ConfigurationTemplateId = configurationTemplate.Id,
					AutoBind = true
				}, cancellationToken: CancellationToken);
	}

	/// <summary>
	/// Binding the template brings VLAN 10 with it, which this then re-subnets.
	/// </summary>
	private async Task UpdateDefaultVlanAsync(string networkId)
	{
		var initialVlans = await TestMerakiClient
			.Appliance
			.Vlans
			.GetNetworkApplianceVlansAsync(networkId, cancellationToken: CancellationToken);
		_ = initialVlans.Should().NotBeNull();

		var vlan10 = initialVlans.SingleOrDefault(v => v.Id == "10");
		_ = vlan10.Should().NotBeNull();

		var updatedVlan = await TestMerakiClient
			.Appliance
			.Vlans
			.UpdateNetworkApplianceVlanAsync(networkId, vlan10.Id, new VlanSpec
			{
				Subnet = $"{PrivateNetworkFirst3Octets}.128/28",
				ApplianceIp = $"{PrivateNetworkFirst3Octets}.129",
				ReservedIpRanges =
				[
						new ReservedIpRange
						{
							Comment = "Temp",
							Start = $"{PrivateNetworkFirst3Octets}.129",
							End = $"{PrivateNetworkFirst3Octets}.131"
						}
				]
			},
			cancellationToken: CancellationToken);
		_ = updatedVlan.Should().NotBeNull();
	}

	private async Task<Device> ClaimAndFetchDeviceAsync(string networkId)
	{
		_ = await TestMerakiClient
			.Networks
			.Devices
			.ClaimNetworkDevicesAsync(networkId, true, new DeviceClaimRequest { Serials = [Configuration.TestDeviceSerial] }, cancellationToken: CancellationToken);

		// Make sure it's there.
		var fetchedDevice = await TestMerakiClient
			.Devices
			.GetDeviceAsync(networkId, cancellationToken: CancellationToken);
		_ = fetchedDevice.Should().BeOfType<Device>();
		_ = fetchedDevice.Should().NotBeNull();

		return fetchedDevice;
	}

	/// <summary>
	/// An address one character over the documented maximum is rejected, and one exactly at it, or a
	/// realistic multi-line address, is accepted.
	/// </summary>
	private async Task AssertDeviceAddressLengthIsEnforcedAsync(Device fetchedDevice)
	{
		Func<Task> action = async () =>
		{
			fetchedDevice.Address = new string('x', Device.MaxAddressLength + 1);
			_ = await TestMerakiClient
				.Devices
				.UpdateDeviceAsync(fetchedDevice.Serial, fetchedDevice);
		};

		_ = await action
			.Should()
			.ThrowAsync<ApiException>();

		fetchedDevice.Address = new string('x', Device.MaxAddressLength);
		_ = await TestMerakiClient
			.Devices
			.UpdateDeviceAsync(fetchedDevice.Serial, fetchedDevice, cancellationToken: CancellationToken);

		fetchedDevice.Address = "45 Heywood Avenue,\nMaidenhead,\nSL6 3JA";
		_ = await TestMerakiClient
			.Devices
			.UpdateDeviceAsync(fetchedDevice.Serial, fetchedDevice, cancellationToken: CancellationToken);
	}

	private async Task UpdateAndVerifyManagementInterfaceAsync(string networkId, string deviceSerial)
	{
		var wanSpecs = await TestMerakiClient
			.Devices
			.ManagementInterface
			.GetDeviceManagementInterfaceAsync(deviceSerial, cancellationToken: CancellationToken);
		_ = wanSpecs.Should().BeOfType<DeviceManagementInterfaceSettings>();
		_ = wanSpecs.Should().NotBeNull();

		var updatedWanSpecs = await TestMerakiClient
			.Devices
			.ManagementInterface
			.UpdateDeviceManagementInterfaceAsync(deviceSerial, new DeviceManagementInterfaceSettings
			{
				Wan1 = new Wan
				{
					StaticDns = [DnsServer],
					StaticGatewayIp = $"{PrivateNetworkFirst3Octets}.1",
					StaticIp = $"{PrivateNetworkFirst3Octets}.254",
					StaticSubnetMask = $"{SubnetMaskFirst3Octets}.0",
					UsingStaticIp = true,
					Vlan = 1,
					WanEnabledStatus = WanEnabledStatus.Enabled,
				}
			}, cancellationToken: CancellationToken);
		_ = updatedWanSpecs.Should().BeOfType<DeviceManagementInterfaceSettings>();
		_ = updatedWanSpecs.Should().NotBeNull();

		var wanSpecsRefetch = await TestMerakiClient
			.Devices
			.ManagementInterface
			.GetDeviceManagementInterfaceAsync(networkId, cancellationToken: CancellationToken);
		_ = wanSpecsRefetch.Should().NotBeNull();
		_ = wanSpecsRefetch.Wan1.Should().NotBeNull();
		_ = wanSpecsRefetch.Wan1!.StaticDns.Should().NotBeNull();
		_ = wanSpecsRefetch.Wan1.StaticDns.Should().ContainSingle();
		_ = wanSpecsRefetch.Wan1.StaticDns![0].Should().BeEquivalentTo(DnsServer);
	}

	private async Task AssertDeviceIsListedForOrganizationAsync()
	{
		var allOrganizationDevices = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesAsync(Configuration.TestOrganizationId, cancellationToken: CancellationToken);
		_ = allOrganizationDevices.Should().NotBeNull();
		_ = allOrganizationDevices.Should().Contain(d => d.Serial == Configuration.TestDeviceSerial);
	}

	private async Task UnbindAndDeleteNetworkAsync(string networkId)
	{
		_ = await TestMerakiClient
			.Networks
			.UnbindNetworkAsync(networkId, new ConfigurationTemplateUnbindRequest(), cancellationToken: CancellationToken);

		await TestMerakiClient
			.Networks
			.DeleteNetworkAsync(networkId, cancellationToken: CancellationToken);

		var action = async ()
			=> _ = await TestMerakiClient
				.Networks
				.GetNetworkAsync(networkId, cancellationToken: CancellationToken);

		_ = await action
			.Should()
			.ThrowAsync<ApiException>();
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
				.GenerateDeviceCameraSnapshotAsync(Configuration.TestCameraSerial, new CameraSnapshotRequest { Fullframe = true }, cancellationToken: CancellationToken);
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
		.GetDeviceCameraVideoLinkAsync(Configuration.TestCameraNetworkId, Configuration.TestCameraSerial!, cancellationToken: CancellationToken);
		_ = newResult.Should().NotBeNull();
	}

	[Fact]
	public async Task GetRepeatedlyInQuickSuccession_Succeeds()
	{
		// The code will call the `GetFirstNetworkAsync()` method 10 times sequentially without a pause.
		for (var i = 0; i < 10; i++)
		{
			_ = await GetFirstNetworkAsync();
		}
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
}
