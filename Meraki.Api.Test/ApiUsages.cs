using FluentAssertions;
using Meraki.Api.Data;
using Xunit;

namespace Meraki.Api.Test
{
	public class ApiUsages : MerakiClientTest
	{
		[Fact]
		public async void GetPageAsync_Succeeds()
		{
			var result = await MerakiClient
				.ApiRequests
				.GetPageAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetOverviewAsync_Succeeds()
		{
			var result = await MerakiClient
				.ApiRequests
				.GetOverviewAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().BeOfType<ApiUsageOverview>();
			result.Should().NotBeNull();
			result.ResponseCodeCounts.Should().NotBeNull();
			result.ResponseCodeCounts.Should().NotBeEmpty();
		}
	}
}
