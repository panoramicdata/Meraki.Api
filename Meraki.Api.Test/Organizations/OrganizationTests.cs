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
}
