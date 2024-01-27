namespace Meraki.Api.Test.Organizations.ApiRequests;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetPageAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ApiRequests
			.GetOrganizationApiRequestsAsync(Configuration.TestOrganizationId);
		_ = result.Should().BeOfType<List<ApiUsage>>();
		_ = result.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetOverviewAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ApiRequests
			.GetOrganizationApiRequestsOverviewAsync(Configuration.TestOrganizationId);
		_ = result.Should().BeOfType<ApiUsageOverview>();
		_ = result.Should().NotBeNull();
		_ = result.ResponseCodeCounts.Should().NotBeNull();
		_ = result.ResponseCodeCounts.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetOverviewResponseCodesByIntervalAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ApiRequests
			.GetOrganizationApiRequestsOverviewResponseCodesByIntervalAsync(Configuration.TestOrganizationId);
		_ = result.Should().BeOfType<List<ApiRequestsOverview>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
		_ = result[0].Counts.Should().NotBeEmpty();
		_ = result[0].StartTs.Should().NotBe(DateTime.MinValue);
		_ = result[0].EndTs.Should().NotBe(DateTime.MaxValue);
	}
}
