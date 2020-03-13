using FluentAssertions;
using Meraki.Api.Data;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Meraki.Api.Test
{
	public class OrganizationTests : MerakiClientTest
	{
		[Fact]
		public async void GetAllAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAllAsync()
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
			var firstResult = result[0];
			Validate(firstResult);
		}

		private void Validate(Organization org)
		{
			org.Should().NotBeNull();
			string.IsNullOrWhiteSpace(org.Id).Should().BeFalse();
			string.IsNullOrWhiteSpace(org.Name).Should().BeFalse();
			string.IsNullOrWhiteSpace(org.Url).Should().BeFalse();
		}

		[Fact]
		public async void GetAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Validate(result);
		}

		[Fact]
		public async void GetNetworksAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetNetworksAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
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
		public async void GetNetworksByConfigTemplateIdAsync_Succeeds()
		{
			var configurationTemplates = await MerakiClient
				.Organizations
				.GetAllConfigurationTemplatesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			configurationTemplates.Should().NotBeNull();
			if (configurationTemplates.Count == 0)
			{
				return;
			}

			var configurationTemplate = configurationTemplates[0];

			var result = await MerakiClient
				.Organizations
				.GetNetworksAsync(Configuration.TestOrganizationId, configurationTemplate.Id)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetAllThirdPartyVpnPeersAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAllThirdPartyVpnPeersAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetAllInventoryAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAllInventoryAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}

		[Fact]
		public async void GetAllConfigurationTemplatesAsync_Succeeds()
		{
			var configurationTemplates = await MerakiClient
				.Organizations
				.GetAllConfigurationTemplatesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			configurationTemplates.Should().NotBeNull();

			// Get their associated switch profiles (for the first up to 3)
			foreach (var configurationTemplate in configurationTemplates.Take(3))
			{
				var switchProfiles = await MerakiClient
				.Organizations
				.GetSwitchProfilesAsync(Configuration.TestOrganizationId, configurationTemplate.Id)
				.ConfigureAwait(false);
				switchProfiles.Should().NotBeNull();
				if (switchProfiles.Count > 0)
				{
					switchProfiles.All(switchProfile => string.IsNullOrWhiteSpace(switchProfile.Model)).Should().BeFalse();
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
			result.Should().NotBeNull();
			result.Serials.Should().NotBeEmpty();
		}

		[Fact]
		public async void GetChangeLogEntriesAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetChangeLogEntriesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}
	}
}
