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

namespace Meraki.Api.Test
{
	public class NetworkTests : MerakiClientTest
	{
		[Fact]
		public async void GetNetworksAsync_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetAllAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().BeOfType<List<Network>>();
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
			var firstResult = result[0];
			Validate(firstResult);
		}

		private void Validate(Network network)
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
			var network = await GetTestNetworkAsync()
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
			var network = await GetTestNetworkAsync()
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
					new NetworkCreationDto
					{
						Name = networkName,
						Type = "wireless switch appliance",
						Tags = "network_level",
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
					new NetworkCreationDto
					{
						Name = networkName,
						Type = "wireless switch appliance",
						Tags = "network_level",
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
			var oldNetwork = (await MerakiClient
				.Networks
				.GetAllAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false)).SingleOrDefault(n => n.Name == networkName);
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
						.RemoveAsync(oldNetwork.Id, oldNetworkDevice.Serial)
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

			//var bulkClaim = await MerakiClient
			//	.Organizations
			//	.BulkClaimAsync(Configuration.TestOrganizationId, new OrganizationBulkClaim { Serials = new List<string> { Configuration.TestDeviceSerial } })
			//	.ConfigureAwait(false);

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
					 .RemoveAsync(device.NetworkId, Configuration.TestDeviceSerial)
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
				new NetworkCreationDto
				{
					Name = networkName,
					Type = "wireless switch appliance",
					Tags = "network_level",
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
				.BindTemplateAsync(newNetwork.Id, configurationTemplate.Id, true)
				.ConfigureAwait(false);

			// Get all VLANs - should be the default one
			var initialVlans = await MerakiClient
				.Vlans
				.GetAllAsync(newNetwork.Id)
				.ConfigureAwait(false);
			initialVlans.Should().NotBeNull();

			var vlan10 = initialVlans.SingleOrDefault(v => v.Id == "10");
			vlan10.Should().NotBeNull();

			// Update a VLAN
			var updatedVlan = await MerakiClient
				.Vlans
				.UpdateAsync(newNetwork.Id, vlan10.Id, new VlanSpec
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
				.ClaimAsync(newNetwork.Id, new ClaimNetworkDevices { Serials = new List<string> { Configuration.TestDeviceSerial } })
				.ConfigureAwait(false);

			// Make sure it's there.
			var fetchedDevice = await MerakiClient
				.Devices
				.GetAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);
			fetchedDevice.Should().BeOfType<Device>();
			fetchedDevice.Should().NotBeNull();

			// Updating the device with a too-long address should fail
			Func<Task> action = async () =>
			{
				await MerakiClient
								.Devices
								.UpdateAsync(newNetwork.Id, Configuration.TestDeviceSerial, new DeviceUpdateDto { Address = new string('X', Device.MaxAddressLength + 1) })
								.ConfigureAwait(false);
			};

			await action
				.Should()
				.ThrowAsync<ApiException>()
				.ConfigureAwait(false);

			// But an OK length should succeed
			await MerakiClient
				.Devices
				.UpdateAsync(newNetwork.Id, Configuration.TestDeviceSerial, new DeviceUpdateDto { Address = new string('X', Device.MaxAddressLength) })
				.ConfigureAwait(false);

			// Setting the address should succeed
			await MerakiClient
				.Devices
				.UpdateAsync(newNetwork.Id, Configuration.TestDeviceSerial, new DeviceUpdateDto { Address = "45 Heywood Avenue,\nMaidenhead,\nSL6 3JA" })

			// Get the management interface settings
			var wanSpecs = await MerakiClient
				.Networks
				.GetDeviceManagementInterfaceSettingsAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);
			wanSpecs.Should().NotBeNull();

			const string googleDns = "8.8.8.8";
			var newWanSpecs = new WanSpecs
			{
				WanSpec1 = new WanSpec
				{
					StaticDns = new List<string> { googleDns },
					StaticGatewayIp = "192.168.1.1",
					StaticIp = "192.168.1.254",
					StaticSubnetMask = "255.255.255.0",
					UsingStaticIp = true,
					Vlan = 1,
					WanEnabled = WanEnabledStatus.Enabled
				},
				WanSpec2 = new WanSpec
				{
					WanEnabled = WanEnabledStatus.Disabled
				}
			};
			var wanSpec = await MerakiClient
				.Networks
				.UpdateDeviceManagementInterfaceSettingsAsync(newNetwork.Id, Configuration.TestDeviceSerial, newWanSpecs)
				.ConfigureAwait(false);
			wanSpec.Should().NotBeNull();

			// Get the management interface settings
			var wanSpecsRefetch = await MerakiClient
				.Networks
				.GetDeviceManagementInterfaceSettingsAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);
			wanSpecsRefetch.Should().NotBeNull();
			wanSpecsRefetch.WanSpec1.Should().NotBeNull();
			wanSpecsRefetch.WanSpec1!.StaticDns.Should().NotBeNull();
			wanSpecsRefetch.WanSpec1.StaticDns.Should().HaveCount(1);
			wanSpecsRefetch.WanSpec1.StaticDns.Should().NotBeNull();
			wanSpecsRefetch.WanSpec1.StaticDns![0].Should().BeEquivalentTo(googleDns);

			// Get all organization devices and make sure ours is present
			var allOrganizationDevices = await MerakiClient
				.Organizations
				.GetAllDevicesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			allOrganizationDevices.Should().NotBeNull();
			allOrganizationDevices.Any(d => d.Serial == Configuration.TestDeviceSerial).Should().BeTrue();

			// ----------
			// Create complete - now undo everything
			// ----------

			await MerakiClient
				.Devices
				.RemoveAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);

			await MerakiClient
				.Networks
				.UnbindTemplateAsync(newNetwork.Id)
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
			var network = await GetTestNetworkAsync()
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
			var network = await GetTestNetworkAsync()
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
			var network = await GetTestNetworkAsync()
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
				.GetSnapshotAsync(Configuration.TestCameraNetworkId, Configuration.TestCameraSerial!, new CameraSnapshotRequest { Fullframe = true })
				.ConfigureAwait(false);
			newResult.Should().NotBeNull();

			// Download the image
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
		public async void GetFast_Succeeds()
		{
			foreach (var _ in Enumerable.Range(0, 100))
			{
				await GetTestNetworkAsync()
					.ConfigureAwait(false);
			}
		}
	}
}
