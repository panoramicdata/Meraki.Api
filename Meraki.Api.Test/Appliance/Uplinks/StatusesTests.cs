namespace Meraki.Api.Test.Appliance.Uplinks;

public class StatusesTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task GetOrganizationApplianceUplinkStatusesAll_ReturnsEveryPage()
	{
		TestMerakiClient.Statistics.Reset();
		var firstPage = await TestMerakiClient
			.Appliance
			.Uplink
			.Statuses
			.GetOrganizationApplianceUplinkStatusesAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		var everyPage = await TestMerakiClient
			.Appliance
			.Uplink
			.Statuses
			.GetOrganizationApplianceUplinkStatusesAllAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		_ = everyPage.Should().HaveCountGreaterThanOrEqualTo(firstPage.Count);
		_ = everyPage.Select(status => status.Serial).Should().OnlyHaveUniqueItems();
		TestOutputHelper.WriteLine($"First page: {firstPage.Count}, every page: {everyPage.Count}. Stats: {TestMerakiClient.Statistics}");
	}
}
