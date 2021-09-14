using FluentAssertions;
using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class NetworkTests : MerakiClientTest
	{
		public NetworkTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		//[Fact]
		//public async void GetNetworksAsync_Succeeds()
		//{
		//	var result = await MerakiClient
		//		.Networks
		//		.GetAllAsync(Configuration.TestOrganizationId)
		//		.ConfigureAwait(false);

		//	result.Should().BeOfType<List<Network>>();
		//	result.Should().NotBeNull();
		//	result.Should().NotBeEmpty();
		//	var firstResult = result[0];
		//	ValidateNetwork(firstResult);
		//}

		internal static void ValidateNetwork(Network network)
		{
			network.Should().NotBeNull();
			string.IsNullOrWhiteSpace(network.Id).Should().BeFalse();
			string.IsNullOrWhiteSpace(network.Name).Should().BeFalse();
			string.IsNullOrWhiteSpace(network.OrganizationId).Should().BeFalse();
			string.IsNullOrWhiteSpace(network.TimeZone).Should().BeFalse();
		}

		[Fact]
		public async void GetAllSsidsAsync_Succeeds()
		{
			var network = await GetFirstNetworkAsync()
				.ConfigureAwait(false);

			var result = await MerakiClient
				.Ssids
				.GetAllAsync(network.Id)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}

		[Fact]
		public async void GetAllDevicesAsync_Succeeds()
		{
			var network = await GetFirstNetworkAsync()
				.ConfigureAwait(false);

			var result = await MerakiClient
				.Devices
				.GetAllByNetworkAsync(network.Id)
				.ConfigureAwait(false);
			result.Should().BeOfType<List<Device>>();
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}

		[Fact]
		public async void SimpleCreateDelete_Succeeds()
		{
			var networkName = new string('X', Network.MaxNameLength);

			await EnsureNetworkRemovedAsync(networkName)
				.ConfigureAwait(false);

			// Create network
			var newNetwork = await MerakiClient
				.Networks
				.CreateAsync(
					Configuration.TestOrganizationId,
					new NetworkCreationRequest
					{
						Name = networkName,
						ProductTypes = new() { ProductType.Wireless },
						Tags = new List<string>(),
						TimeZone = "Europe/London"
					})
				.ConfigureAwait(false);

			// And delete it again
			await MerakiClient
				.Networks
				.DeleteAsync(newNetwork.Id)
				.ConfigureAwait(false);
		}

		[Fact]
		public async void NameTooLong_Fails()
		{
			var networkName = new string('X', Network.MaxNameLength + 1);

			Func<Task> action = async () =>
			{
				var newNetwork = await MerakiClient
					 .Networks
					 .CreateAsync(
					Configuration.TestOrganizationId,
					new NetworkCreationRequest
					{
						Name = networkName,
						Tags = new List<string>(),
						TimeZone = "Europe/London"
					})
					 .ConfigureAwait(false);
			};

			await action
				.Should()
				.ThrowAsync<ApiException>()
				.ConfigureAwait(false);
		}

		private async Task EnsureNetworkRemovedAsync(string networkName)
		{
			// Perform any clean-up
			var networks = await MerakiClient
							.Organizations
							.GetNetworksAsync(Configuration.TestOrganizationId)
							.ConfigureAwait(false);
			var oldNetwork = networks.SingleOrDefault(n => n.Name == networkName);
			if (oldNetwork != default)
			{
				// Get all network devices and remove them
				var oldNetworkDevices = await MerakiClient
					.Devices
					.GetAllByNetworkAsync(oldNetwork.Id)
					.ConfigureAwait(false);
				foreach (var oldNetworkDevice in oldNetworkDevices)
				{
					await MerakiClient
						.Devices
						.RemoveAsync(oldNetwork.Id)
						.ConfigureAwait(false);
				}

				await MerakiClient
					.Networks
					.DeleteAsync(oldNetwork.Id)
					.ConfigureAwait(false);
			}
		}

		[Fact]
		public async void CreateClaimRemoveDelete_Succeeds()
		{
			const string networkName = "Meraki.Api Unit Test";

			// Get the device
			var devices = await MerakiClient
				.Organizations
				.GetInventoryAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			var device = devices.SingleOrDefault(d => d.Serial == Configuration.TestDeviceSerial);
			if (device?.NetworkId != null)
			{
				// Unclaim the device
				await MerakiClient
					 .Devices
					 .RemoveAsync(device.NetworkId)
					 .ConfigureAwait(false);
			}

			// Perform any clean-up
			await EnsureNetworkRemovedAsync(networkName)
				.ConfigureAwait(false);

			// Create network
			var newNetwork = await MerakiClient
				.Networks
				.CreateAsync(
					Configuration.TestOrganizationId,
				new NetworkCreationRequest
				{
					Name = networkName,
					Tags = new List<string>(),
					TimeZone = "Europe/London"
				})
				.ConfigureAwait(false);

			newNetwork.Should().NotBeNull();

			// Re-fetch the network
			var refetchedNetwork = await MerakiClient
				.Networks
				.GetAsync(newNetwork.Id)
				.ConfigureAwait(false);

			newNetwork.Name.Should().Be(refetchedNetwork.Name);

			// Bind and unbind a configuration template
			var configurationTemplates = await MerakiClient
				.ConfigurationTemplates
				.GetAllAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			configurationTemplates.Should().NotBeNull();
			configurationTemplates.Should().NotBeEmpty();
			var configurationTemplate = configurationTemplates[0];
			await MerakiClient
				.Networks
				.BindConfigurationTemplateAsync(
					newNetwork.Id,
					new ConfigurationTemplateBindRequest
					{
						ConfigurationTemplateId = configurationTemplate.Id,
						AutoBind = true
					})
				.ConfigureAwait(false);

			// Get all VLANs - should be the default one
			var initialVlans = await MerakiClient
				.Vlans
				.GetNetworkVlansAsync(newNetwork.Id)
				.ConfigureAwait(false);
			initialVlans.Should().NotBeNull();

			var vlan10 = initialVlans.SingleOrDefault(v => v.Id == "10");
			vlan10.Should().NotBeNull();
			vlan10 = null!;

			// Update a VLAN
			var updatedVlan = await MerakiClient
				.Vlans
				.UpdateNetworkVlanAsync(newNetwork.Id, vlan10.Id, new VlanSpec
				{
					Subnet = "10.250.82.128/28",
					ApplianceIp = "10.250.82.129",
					ReservedIpRanges = new List<ReservedIpRange>
					{
						new ReservedIpRange
						{
							Comment = "Temp",
							Start = "10.250.82.129",
							End = "10.250.82.131"
						}
					}
				})
				.ConfigureAwait(false);
			updatedVlan.Should().NotBeNull();

			//--- Claim/Remove device
			await MerakiClient
				.Devices
				.ClaimAsync(newNetwork.Id, new DeviceClaimRequest { Serials = new List<string> { Configuration.TestDeviceSerial } })
				.ConfigureAwait(false);

			// Make sure it's there.
			var fetchedDevice = await MerakiClient
				.Devices
				.GetAsync(newNetwork.Id)
				.ConfigureAwait(false);
			fetchedDevice.Should().BeOfType<Device>();
			fetchedDevice.Should().NotBeNull();

			// updating the device with a too-long address should fail
			Func<Task> action = async () =>
			{
				fetchedDevice.Address = new string('x', Device.MaxAddressLength + 1);
				await MerakiClient
					.Devices
					.UpdateAsync(fetchedDevice.Serial, fetchedDevice)
					.ConfigureAwait(false);
			};

			await action
				.Should()
				.ThrowAsync<ApiException>()
				.ConfigureAwait(false);

			//// But an OK length should succeed
			fetchedDevice.Address = new string('x', Device.MaxAddressLength);
			await MerakiClient
				.Devices
				.UpdateAsync(fetchedDevice.Serial, fetchedDevice)
				.ConfigureAwait(false);

			//// Setting the address should succeed
			fetchedDevice.Address = "45 Heywood Avenue,\nMaidenhead,\nSL6 3JA";
			await MerakiClient
				.Devices
				.UpdateAsync(fetchedDevice.Serial, fetchedDevice)
				.ConfigureAwait(false);

			//// Get the management interface settings
			var wanSpecs = await MerakiClient
				.ManagementInterfaceSettings
				.GetAsync(newNetwork.Id)
				.ConfigureAwait(false);
			wanSpecs.Should().BeOfType<WanSpecs>();
			wanSpecs.Should().NotBeNull();

			const string googleDns = "8.8.8.8";
			var newWanSpecs = new WanSpecs
			{
				Wan1 = new Wan
				{
					StaticDns = new List<string> { googleDns },
					StaticGatewayIp = "192.168.1.1",
					StaticIp = "192.168.1.254",
					StaticSubnetMask = "255.255.255.0",
					UsingStaticIp = true,
					Vlan = 1,
					WanEnabledStatus = WanEnabledStatus.Enabled
				},
				Wan2 = new Wan
				{
					WanEnabledStatus = WanEnabledStatus.Disabled
				}
			};
			var updatedWanSpecs = await MerakiClient
				.ManagementInterfaceSettings
				.UpdateAsync(newNetwork.Id, new ManagementInterfaceSettingsUpdateRequest
				{
					Wan1 = new Wan
					{
						StaticDns = newWanSpecs.Wan1.StaticDns,
						StaticGatewayIp = newWanSpecs.Wan1.StaticGatewayIp,
						StaticIp = newWanSpecs.Wan1.StaticIp,
						StaticSubnetMask = newWanSpecs.Wan1.StaticSubnetMask,
						UsingStaticIp = newWanSpecs.Wan1.UsingStaticIp,
						Vlan = newWanSpecs.Wan1.Vlan,
						WanEnabledStatus = newWanSpecs.Wan1.WanEnabledStatus,
					}
				})
				.ConfigureAwait(false);
			updatedWanSpecs.Should().BeOfType<WanSpecs>();
			updatedWanSpecs.Should().NotBeNull();

			//// Get the management interface settings
			var wanSpecsRefetch = await MerakiClient
				.ManagementInterfaceSettings
				.GetAsync(newNetwork.Id)
				.ConfigureAwait(false);
			wanSpecsRefetch.Should().NotBeNull();
			wanSpecsRefetch.Wan1.Should().NotBeNull();
			wanSpecsRefetch.Wan1!.StaticDns.Should().NotBeNull();
			wanSpecsRefetch.Wan1.StaticDns.Should().HaveCount(1);
			wanSpecsRefetch.Wan1.StaticDns.Should().NotBeNull();
			wanSpecsRefetch.Wan1.StaticDns![0].Should().BeEquivalentTo(googleDns);

			// Get all organization devices and make sure ours is present
			var allOrganizationDevices = await MerakiClient
				.Devices
				.GetPageByOrganizationAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			allOrganizationDevices.Should().NotBeNull();
			allOrganizationDevices.Any(d => d.Serial == Configuration.TestDeviceSerial).Should().BeTrue();

			// ----------
			// Create complete - now undo everything
			// ----------

			await MerakiClient
				.Devices
				.RemoveAsync(newNetwork.Id)
				.ConfigureAwait(false);

			await MerakiClient
				.Networks
				.UnbindConfigurationTemplateAsync(newNetwork.Id)
				.ConfigureAwait(false);

			//--- Delete the network

			// Delete the network
			await MerakiClient
				.Networks
				.DeleteAsync(newNetwork.Id)
				.ConfigureAwait(false);

			action = async () =>
			{
				var _ = await MerakiClient
					.Networks
					.GetAsync(newNetwork.Id)
					.ConfigureAwait(false);
			};

			await action
				.Should()
				.ThrowAsync<ApiException>()
				.ConfigureAwait(false);
		}

		[Fact]
		public async void GetClientsAsync_Succeeds()
		{
			var network = await GetFirstNetworkAsync()
				.ConfigureAwait(false);

			var result = await MerakiClient
				.Clients
				.GetByNetworkAsync(network.Id)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}

		[Fact]
		public async void GetBluetoothClientsAsync_Succeeds()
		{
			var network = await GetFirstNetworkAsync()
				.ConfigureAwait(false);

			var result = await MerakiClient
				.BluetoothClients
				.GetAllAsync(network.Id)
				.ConfigureAwait(false);
			result.Should().BeOfType<List<BluetoothClient>>();
			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetWirelessSettingsAsync_Succeeds()
		{
			var network = await GetFirstNetworkAsync()
				.ConfigureAwait(false);

			// Get the wireless settings
			var originalResult = await MerakiClient
				.WirelessSettings
				.GetAsync(network.Id)
				.ConfigureAwait(false);
			originalResult.Should().BeOfType<WirelessSettings>();
			originalResult.Should().NotBeNull();
			originalResult.Should().BeOfType<List<BluetoothClient>>();

			// Re-set the wireless settings (to the same values)
			var newResult = await MerakiClient
				.WirelessSettings
				.UpdateAsync(network.Id, new WirelessSettingsUpdateDto
				{
					Ipv6BridgeEnabled = originalResult.Ipv6BridgeEnabled,
					LedLightsOn = originalResult.LedLightsOn,
					LocationAnalyticsEnabled = originalResult.LocationAnalyticsEnabled,
					MeshingEnabled = originalResult.MeshingEnabled,
				})
				.ConfigureAwait(false);
			newResult.Should().BeOfType<WirelessSettings>();
			newResult.Should().NotBeNull();

			// The two should match
			newResult.MeshingEnabled.Should().Be(originalResult.MeshingEnabled);
			newResult.Ipv6BridgeEnabled.Should().Be(originalResult.Ipv6BridgeEnabled);
			newResult.LocationAnalyticsEnabled.Should().Be(originalResult.LocationAnalyticsEnabled);
		}

		[Fact]
		public async void GetCameraSnapshotAsync_Succeeds()
		{
			// Get a snapshot from the camera
			var newResult = await MerakiClient
				.Cameras
				.GetSnapshotAsync(Configuration.TestCameraSerial, new CameraSnapshotRequest { Fullframe = true })
				.ConfigureAwait(false);
			newResult.Should().NotBeNull();

			//Download the image
			using var client = new WebClient();
			using var stream = client.OpenRead(newResult.Url);
			using var bitmap = new Bitmap(stream);

			bitmap.Save("temp.png", ImageFormat.Png);

			stream.Flush();
			stream.Close();
		}

		[Fact]
		public async void GetCameraVideoLinkAsync_Succeeds()
		{
			Configuration.TestCameraNetworkId.Should().NotBeNull();

			// Get a snapshot from the camera
			var newResult = await MerakiClient
				.Cameras
				.GetVideoLinkAsync(Configuration.TestCameraNetworkId, Configuration.TestCameraSerial!)
				.ConfigureAwait(false);
			newResult.Should().NotBeNull();
		}

		[Fact]
		public async void GetRepeatedlyInQuickSuccession_Succeeds()
		{
			foreach (var _ in Enumerable.Range(0, 10))
			{
				await GetFirstNetworkAsync()
					.ConfigureAwait(false);
			}
		}

		[Fact]
		public async void GetDeviceSwitchPortsAsync_Succeeds()
		{
			Configuration.TestSwitchSerial.Should().NotBeNull();

			var switchPorts = await MerakiClient
				.SwitchPorts
				.GetDeviceSwitchPortsAsync(Configuration.TestSwitchSerial, default)
				.ConfigureAwait(false);

			switchPorts.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetNetworkSwitchStacksAsync_Succeeds()
		{
			Configuration.TestCameraNetworkId.Should().NotBeNull();

			var switchStacks = await MerakiClient
				.SwitchStacks
				.GetNetworkSwitchStacksAsync(Configuration.TestCameraNetworkId, default)
				.ConfigureAwait(false);

			switchStacks.Should().NotBeNull();
		}
	}
}
