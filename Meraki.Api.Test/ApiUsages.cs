using FluentAssertions;
using Meraki.Api.Data;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class ApiUsages : MerakiClientTest
	{
		public ApiUsages(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetPageAsync_Succeeds()
		{
			var result = await TestMerakiClient
				.ApiRequests
				.GetPageAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().BeOfType<List<ApiUsage>>();
			result.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetOverviewAsync_Succeeds()
		{
			var result = await TestMerakiClient
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
