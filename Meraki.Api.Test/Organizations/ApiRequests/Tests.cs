namespace Meraki.Api.Test.Organizations.ApiRequests;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetPageAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ApiRequests
			.GetOrganizationApiRequestsAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		result.Should().BeOfType<List<ApiUsage>>();
		result.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetOverviewAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ApiRequests
			.GetOrganizationApiRequestsOverviewAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		result.Should().BeOfType<ApiUsageOverview>();
		result.Should().NotBeNull();
		result.ResponseCodeCounts.Should().NotBeNull();
		result.ResponseCodeCounts.Should().NotBeEmpty();
	}
}
