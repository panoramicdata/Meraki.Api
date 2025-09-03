namespace Meraki.Api.Test.Organizations.Networks;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
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
		_ = string.IsNullOrWhiteSpace(network.Id).Should().BeFalse();
		_ = string.IsNullOrWhiteSpace(network.Name).Should().BeFalse();
		_ = string.IsNullOrWhiteSpace(network.OrganizationId).Should().BeFalse();
		_ = string.IsNullOrWhiteSpace(network.TimeZone).Should().BeFalse();
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
	public async Task CreateClaimRemoveDelete_Succeeds()
	{
		const string networkName = "Meraki.Api Unit Test";

		// Get the device
		var devices = await TestMerakiClient
			.Organizations
			.InventoryDevices
			.GetOrganizationInventoryDevicesAsync(Configuration.TestOrganizationId, cancellationToken: CancellationToken);
		var device = devices.SingleOrDefault(d => d.Serial == Configuration.TestDeviceSerial);

		_ = device.Should().NotBeNull();

		// Perform any clean-up
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

		// Bind and unbind a configuration template
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
				newNetwork.Id,
				new ConfigurationTemplateBindRequest
				{
					ConfigurationTemplateId = configurationTemplate.Id,
					AutoBind = true
				}, cancellationToken: CancellationToken);

		// Get all VLANs - should be the default one
		var initialVlans = await TestMerakiClient
			.Appliance
			.Vlans
			.GetNetworkApplianceVlansAsync(newNetwork.Id, cancellationToken: CancellationToken);
		_ = initialVlans.Should().NotBeNull();

		var vlan10 = initialVlans.SingleOrDefault(v => v.Id == "10");
		_ = vlan10.Should().NotBeNull();
		vlan10 = null!;

		// Update a VLAN
		var updatedVlan = await TestMerakiClient
			.Appliance
			.Vlans
			.UpdateNetworkApplianceVlanAsync(newNetwork.Id, vlan10.Id, new VlanSpec
			{
				Subnet = $"{PrivateNetworkFirst3Octets}.128/28",
				ApplianceIp = $"{PrivateNetworkFirst3Octets}.129",
				ReservedIpRanges =
				[
						new() {
							Comment = "Temp",
							Start = $"{PrivateNetworkFirst3Octets}.129",
							End = $"{PrivateNetworkFirst3Octets}.131"
						}
				]
			}, cancellationToken: CancellationToken);
		_ = updatedVlan.Should().NotBeNull();

		//--- Claim/Remove device
		await TestMerakiClient
			.Networks
			.Devices
			.ClaimNetworkDevicesAsync(newNetwork.Id, true, new DeviceClaimRequest { Serials = [Configuration.TestDeviceSerial] }, cancellationToken: CancellationToken);

		// Make sure it's there.
		var fetchedDevice = await TestMerakiClient
			.Devices
			.GetDeviceAsync(newNetwork.Id, cancellationToken: CancellationToken);
		_ = fetchedDevice.Should().BeOfType<Device>();
		_ = fetchedDevice.Should().NotBeNull();
		_ = fetchedDevice.Serial.Should().NotBeNull();

		// updating the device with a too-long address should fail
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

		//// But an OK length should succeed
		fetchedDevice.Address = new string('x', Device.MaxAddressLength);
		_ = await TestMerakiClient
			.Devices
			.UpdateDeviceAsync(fetchedDevice.Serial, fetchedDevice, cancellationToken: CancellationToken);

		//// Setting the address should succeed
		fetchedDevice.Address = "45 Heywood Avenue,\nMaidenhead,\nSL6 3JA";
		_ = await TestMerakiClient
			.Devices
			.UpdateDeviceAsync(fetchedDevice.Serial, fetchedDevice, cancellationToken: CancellationToken);

		//// Get the management interface settings
		var wanSpecs = await TestMerakiClient
			.Devices
			.ManagementInterface
			.GetDeviceManagementInterfaceAsync(fetchedDevice.Serial, cancellationToken: CancellationToken);
		_ = wanSpecs.Should().BeOfType<DeviceManagementInterfaceSettings>();
		_ = wanSpecs.Should().NotBeNull();

		var newDeviceManagementInterfaceSettings = new DeviceManagementInterfaceSettings
		{
			Wan1 = new Wan
			{
				StaticDns = [DnsServer],
				StaticGatewayIp = $"{PrivateNetworkFirst3Octets}.1",
				StaticIp = $"{PrivateNetworkFirst3Octets}.254",
				StaticSubnetMask = $"{SubnetMaskFirst3Octets}.0",
				UsingStaticIp = true,
				Vlan = 1,
				WanEnabledStatus = WanEnabledStatus.Enabled
			},
			Wan2 = new Wan
			{
				WanEnabledStatus = WanEnabledStatus.Disabled
			}
		};
		var updatedWanSpecs = await TestMerakiClient
			.Devices
			.ManagementInterface
			.UpdateDeviceManagementInterfaceAsync(fetchedDevice.Serial!, new DeviceManagementInterfaceSettings
			{
				Wan1 = new Wan
				{
					StaticDns = newDeviceManagementInterfaceSettings.Wan1.StaticDns,
					StaticGatewayIp = newDeviceManagementInterfaceSettings.Wan1.StaticGatewayIp,
					StaticIp = newDeviceManagementInterfaceSettings.Wan1.StaticIp,
					StaticSubnetMask = newDeviceManagementInterfaceSettings.Wan1.StaticSubnetMask,
					UsingStaticIp = newDeviceManagementInterfaceSettings.Wan1.UsingStaticIp,
					Vlan = newDeviceManagementInterfaceSettings.Wan1.Vlan,
					WanEnabledStatus = newDeviceManagementInterfaceSettings.Wan1.WanEnabledStatus,
				}
			}, cancellationToken: CancellationToken);
		_ = updatedWanSpecs.Should().BeOfType<DeviceManagementInterfaceSettings>();
		_ = updatedWanSpecs.Should().NotBeNull();

		//// Get the management interface settings
		var wanSpecsRefetch = await TestMerakiClient
			.Devices
			.ManagementInterface
			.GetDeviceManagementInterfaceAsync(newNetwork.Id, cancellationToken: CancellationToken);
		_ = wanSpecsRefetch.Should().NotBeNull();
		_ = wanSpecsRefetch.Wan1.Should().NotBeNull();
		_ = wanSpecsRefetch.Wan1!.StaticDns.Should().NotBeNull();
		_ = wanSpecsRefetch.Wan1.StaticDns.Should().HaveCount(1);
		_ = wanSpecsRefetch.Wan1.StaticDns.Should().NotBeNull();
		_ = wanSpecsRefetch.Wan1.StaticDns![0].Should().BeEquivalentTo(DnsServer);

		// Get all organization devices and make sure ours is present
		var allOrganizationDevices = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesAsync(Configuration.TestOrganizationId, cancellationToken: CancellationToken);
		_ = allOrganizationDevices.Should().NotBeNull();
		_ = allOrganizationDevices.Any(d => d.Serial == Configuration.TestDeviceSerial).Should().BeTrue();

		// ----------
		// Create complete - now undo everything
		// ----------

		_ = await TestMerakiClient
			.Networks
			.UnbindNetworkAsync(newNetwork.Id, new ConfigurationTemplateUnbindRequest(), cancellationToken: CancellationToken);

		//--- Delete the network

		// Delete the network
		await TestMerakiClient
			.Networks
			.DeleteNetworkAsync(newNetwork.Id, cancellationToken: CancellationToken);

		action = async () => _ = await TestMerakiClient
			.Networks
			.GetNetworkAsync(newNetwork.Id);

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
			var exception = await Assert.ThrowsAsync<InvalidOperationException>(
				() => TestMerakiClient
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
						}, cancellationToken: CancellationToken
					)
				);
			_ = exception.Message.Should().Be("The client options have been configured to only allow read actions");
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
