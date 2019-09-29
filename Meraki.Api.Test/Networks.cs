using Refit;
using System.Linq;
using Xunit;

namespace Meraki.Api.Test
{
	public class Networks : MerakiClientTest
	{
		[Fact]
		public async void GetAllSsidsAsync_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetAllSsidsAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
			Assert.NotEmpty(result);
		}

		[Fact]
		public async void GetAllDevicesAsync_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetAllSsidsAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
			Assert.NotEmpty(result);
		}

		[Fact]
		public async void CreateClaimRemoveDelete_Succeeds()
		{
			const string networkName = "Meraki.Api Unit Test";

			// Perform any clean-up
			var oldNetwork = (await MerakiClient
				.Organizations.GetAllNetworksAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false)).SingleOrDefault(n => n.Name == networkName);
			if (oldNetwork != default)
			{
				// Get all network devices and remove them
				var oldNetworkDevices = await MerakiClient
					.Networks
					.GetDevicesAsync(oldNetwork.Id)
					.ConfigureAwait(false);
				foreach (var oldNetworkDevice in oldNetworkDevices)
				{
					await MerakiClient
						.Networks
						.RemoveDeviceAsync(oldNetwork.Id, oldNetworkDevice.Serial)
						.ConfigureAwait(false);
				}

				await MerakiClient
					.Networks
					.DeleteNetworkAsync(oldNetwork.Id)
					.ConfigureAwait(false);
			}

			// Create network
			var newNetwork = await MerakiClient
				.Organizations
				.CreateNetworkAsync(
					Configuration.TestOrganizationId,
					networkName,
					"wireless switch appliance",
					"",
					"Europe/London")
				.ConfigureAwait(false);

			Assert.NotNull(newNetwork);

			// Re-fetch the network
			var refetchedNetwork = await MerakiClient
				.Networks
				.GetAsync(newNetwork.Id)
				.ConfigureAwait(false);

			Assert.Equal(newNetwork.Name, refetchedNetwork.Name);

			// Enable VLANS on the new network and check it worked
			var networkVlansEnabledStatus = await MerakiClient
				.Networks
				.SetVlansEnabledStateAsync(newNetwork.Id, true)
				.ConfigureAwait(false);
			Assert.NotNull(networkVlansEnabledStatus);
			Assert.Equal(newNetwork.Id, networkVlansEnabledStatus.NetworkId);
			Assert.True(networkVlansEnabledStatus.Enabled);

			// Get all VLANs - should be empty
			var initialVlans = await MerakiClient
				.Networks
				.GetAllVlansAsync(newNetwork.Id)
				.ConfigureAwait(false);
			Assert.NotNull(initialVlans);
			Assert.Single(initialVlans);

			// Add a VLAN
			const string vlanId = "1234";
			const string vlanName = "My VLAN";
			const string vlanSubnet = "10.222.1.0/24";
			const string vlanIpAddress = "10.222.1.1";
			await MerakiClient
				.Networks
				.AddVlanAsync(newNetwork.Id, vlanId, vlanName, vlanSubnet, vlanIpAddress)
				.ConfigureAwait(false);

			// Get all VLANs - should have the added VLAN
			var initializedVlans = await MerakiClient
				.Networks
				.GetAllVlansAsync(newNetwork.Id)
				.ConfigureAwait(false);
			Assert.NotNull(initializedVlans);
			Assert.Equal(2, initializedVlans.Count);
			var initializedVlan = initializedVlans[1]; // the second
			Assert.Equal(vlanId, initializedVlan.Id);
			Assert.Equal(vlanName, initializedVlan.Name);
			Assert.Equal(vlanSubnet, initializedVlan.Subnet);
			Assert.Equal(vlanIpAddress, initializedVlan.ApplianceIp);

			//// Bind and unbind a configuration template
			//var configurationTemplates = await MerakiClient
			//	.Organizations
			//	.GetAllConfigurationTemplatesAsync(Configuration.TestOrganizationId)
			//	.ConfigureAwait(false);
			//Assert.NotNull(configurationTemplates);
			//Assert.NotEmpty(configurationTemplates);
			//var configurationTemplate = configurationTemplates[0];
			//await MerakiClient
			//	.Networks
			//	.BindTemplateAsync(newNetwork.Id, configurationTemplate.Id)
			//	.ConfigureAwait(false);
			//await MerakiClient
			//	.Networks
			//	.UnbindTemplateAsync(newNetwork.Id)
			//	.ConfigureAwait(false);

			//--- Claim/Remove device
			await MerakiClient
				.Networks
				.ClaimDeviceAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);

			// Make sure it's there.
			var result = await MerakiClient
				.Networks
				.GetDeviceAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);
			Assert.NotNull(result);

			// Get all organization devices and make sure ours is present
			var allOrganizationDevices = await MerakiClient
				.Organizations
				.GetAllDevicesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(allOrganizationDevices);
			Assert.Contains(allOrganizationDevices, d => d.Serial == Configuration.TestDeviceSerial);

			await MerakiClient
				.Networks
				.RemoveDeviceAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);

			//--- Delete the network

			// Delete the network
			await MerakiClient
				.Networks
				.DeleteNetworkAsync(newNetwork.Id)
				.ConfigureAwait(false);

			// Re-fetch the non-existent network
			await Assert.ThrowsAsync<ApiException>(async () =>
			{
				var _ = await MerakiClient
					.Networks
					.GetAsync(newNetwork.Id)
					.ConfigureAwait(false);
			}).ConfigureAwait(false);
		}
	}
}
