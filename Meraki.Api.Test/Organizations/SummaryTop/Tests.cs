namespace Meraki.Api.Test.Organizations.SummaryTop;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetOrganizationSummaryTopSwitchesByEnergyUsageAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Summary
			.Top
			.GetOrganizationSummaryTopSwitchesByEnergyUsageAsync("542676", "2022-10-12", "2022-10-13")
			.ConfigureAwait(false);

		_ = result.Should().BeOfType<List<EnergyUsageSummary>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
