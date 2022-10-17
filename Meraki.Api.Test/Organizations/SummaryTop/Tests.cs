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

		result.Should().BeOfType<List<EnergyUsageSummary>>();
		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
		//var firstResult = result[0];
		//ValidateNetwork(firstResult);
	}
}
