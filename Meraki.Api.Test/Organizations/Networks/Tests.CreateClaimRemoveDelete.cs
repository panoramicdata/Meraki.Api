namespace Meraki.Api.Test.Organizations.Networks;

/// <summary>
/// The full create, claim, reconfigure, remove and delete lifecycle for an organization
/// network, split out because it and its helpers are the bulk of this fixture.
/// </summary>
#pragma warning disable S2333
public partial class Tests
{
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
		_ = fetchedDevice.Serial.Should().NotBeNull();

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
}
#pragma warning restore S2333
