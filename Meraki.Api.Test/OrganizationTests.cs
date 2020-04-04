using FluentAssertions;
using Meraki.Api.Data;
using System.Collections.Generic;
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
			result.Should().BeOfType<List<Organization>>();
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
		public async void GetAllThirdPartyVpnPeersAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetThirdPartyVpnPeersAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().BeOfType<List<Peer>>();
			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetAllInventoryAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetInventoryAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}

		[Fact]
		public async void ClaimDeviceAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.ClaimAsync(Configuration.TestOrganizationId, new OrganizationClaimRequest { Serials = new List<string> { Configuration.TestDeviceSerial } })
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Serials.Should().NotBeEmpty();
		}
	}
}
