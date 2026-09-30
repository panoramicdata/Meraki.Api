namespace Meraki.Api.Test.Organizations;

public class OrganizationTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task GetOrganizations_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var organizations = await TestMerakiClient.Organizations.GetOrganizationsAsync(cancellationToken: CancellationToken);
		_ = organizations.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		TestOutputHelper.WriteLine($"Stats: {TestMerakiClient.Statistics}");
	}

	[Fact]
	public async Task GetOrganizationWirelessDevicesPacketLoss_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var packetLoss = await TestMerakiClient
			.Wireless
			.Devices
			.PacketLoss
			.GetOrganizationWirelessDevicesPacketLossAsync(
				Configuration.TestOrganizationId,
				perPage: 100,
				cancellationToken: CancellationToken);
		_ = packetLoss.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		TestOutputHelper.WriteLine($"Stats: {TestMerakiClient.Statistics}");
	}

	[Fact]
	public async Task GetOrganizationWirelessDevicesPacketLossAll_ReturnsEveryPage()
	{
		TestMerakiClient.Statistics.Reset();
		var firstPage = await TestMerakiClient
			.Wireless
			.Devices
			.PacketLoss
			.GetOrganizationWirelessDevicesPacketLossAsync(
				Configuration.TestOrganizationId,
				timespan: 3600,
				cancellationToken: CancellationToken);
		var everyPage = await TestMerakiClient
			.Wireless
			.Devices
			.PacketLoss
			.GetOrganizationWirelessDevicesPacketLossAllAsync(
				Configuration.TestOrganizationId,
				timespan: 3600,
				cancellationToken: CancellationToken);
		_ = everyPage.Should().HaveCountGreaterThanOrEqualTo(firstPage.Count);
		_ = everyPage.Select(item => item.Device?.Serial).Should().OnlyHaveUniqueItems();
		TestOutputHelper.WriteLine($"First page: {firstPage.Count}, every page: {everyPage.Count}. Stats: {TestMerakiClient.Statistics}");
	}
}
