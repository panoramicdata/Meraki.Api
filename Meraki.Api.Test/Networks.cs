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
		public async void GetDeviceAsync_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetDeviceAsync(Configuration.TestNetworkId, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);
			Assert.NotNull(result);
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

			//--- Claim/Remove device
			await MerakiClient
				.Networks
				.ClaimDeviceAsync(newNetwork.Id, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);

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
