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
		_ = result.Should().BeOfType<List<ApiUsage>>();
		_ = result.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetOverviewAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ApiRequests
			.GetOrganizationApiRequestsOverviewAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		_ = result.Should().BeOfType<ApiUsageOverview>();
		_ = result.Should().NotBeNull();
		_ = result.ResponseCodeCounts.Should().NotBeNull();
		_ = result.ResponseCodeCounts.Should().NotBeEmpty();
	}
}
