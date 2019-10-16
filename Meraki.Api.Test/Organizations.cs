using Meraki.Api.Data;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Meraki.Api.Test
{
	public class Organizations : MerakiClientTest
	{
		[Fact]
		public async void GetAllAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAllAsync()
				.ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetAllNetworksAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAllNetworksAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
			Assert.NotEmpty(result);
		}

		[Fact]
		public async void GetAllThirdPartyVpnPeersAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAllThirdPartyVpnPeersAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetAllInventoryAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAllInventoryAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
			Assert.NotEmpty(result);
		}

		[Fact]
		public async void GetAllConfigurationTemplatesAsync_Succeeds()
		{
			var configurationTemplates = await MerakiClient
				.Organizations
				.GetAllConfigurationTemplatesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(configurationTemplates);
			Assert.NotEmpty(configurationTemplates);

			// Get their assocaited switch profiles (for the first up to 3)
			foreach (var configurationTemplate in configurationTemplates.Take(3))
			{
				var switchProfiles = await MerakiClient
				.Organizations
				.GetSwitchProfilesAsync(Configuration.TestOrganizationId, configurationTemplate.Id)
				.ConfigureAwait(false);
				Assert.NotNull(switchProfiles);
				if (switchProfiles.Count > 0)
				{
					Assert.All(switchProfiles, switchProfile => Assert.False(string.IsNullOrWhiteSpace(switchProfile.Model)));
				}
			}
		}

		[Fact]
		public async void ClaimDeviceAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.BulkClaimAsync(Configuration.TestOrganizationId, new OrganizationBulkClaim { Serials = new List<string> { Configuration.TestDeviceSerial } })
				.ConfigureAwait(false);
			Assert.NotNull(result);
			Assert.NotEmpty(result.Serials);
			Assert.Empty(result.Orders);
			Assert.Empty(result.Licenses);
		}
	}
}
