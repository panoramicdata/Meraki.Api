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
	}
}
