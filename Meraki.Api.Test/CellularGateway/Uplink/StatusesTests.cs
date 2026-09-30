namespace Meraki.Api.Test.CellularGateway.Uplink;

public class StatusesTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task GetOrganizationCellularGatewayUplinkStatusesAll_ReturnsEveryPage()
	{
		TestMerakiClient.Statistics.Reset();
		var firstPage = await TestMerakiClient
			.CellularGateway
			.Uplink
			.Statuses
			.GetOrganizationCellularGatewayUplinkStatusesAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		var everyPage = await TestMerakiClient
			.CellularGateway
			.Uplink
			.Statuses
			.GetOrganizationCellularGatewayUplinkStatusesAllAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		_ = everyPage.Should().HaveCountGreaterThanOrEqualTo(firstPage.Count);
		_ = everyPage.Select(status => status.Serial).Should().OnlyHaveUniqueItems();
		TestOutputHelper.WriteLine($"First page: {firstPage.Count}, every page: {everyPage.Count}. Stats: {TestMerakiClient.Statistics}");
	}
}
