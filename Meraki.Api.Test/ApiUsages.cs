using FluentAssertions;
using Xunit;

namespace Meraki.Api.Test
{
	public class ApiUsages : MerakiClientTest
	{
		[Fact]
		public async void GetPageAsync_Succeeds()
		{
			var result = await MerakiClient
				.ApiUsages
				.GetPageAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetAll_Succeeds()
		{
			var result = await MerakiClient
				.ApiUsages
				.GetOverviewAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.ResponseCodeCounts.Should().NotBeNull();
			result.ResponseCodeCounts.Should().NotBeEmpty();
		}
	}
}
