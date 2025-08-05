namespace Meraki.Api.Test.Organizations.SummaryTop;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetOrganizationSummaryTopSwitchesByEnergyUsageAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Summary
			.Top
			.GetOrganizationSummaryTopSwitchesByEnergyUsageAsync(
				"542676",
				"2022-10-12",
				"2022-10-13",
				cancellationToken: CancellationToken);

		_ = result.Should().BeOfType<List<EnergyUsageSummary>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
