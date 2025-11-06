using Microsoft.Extensions.Logging;

namespace Meraki.Api.NewTest;
[Collection("API Collection")]
public class OrganizationTests(ITestOutputHelper testOutputHelper) : MerakiClientUnitTest(testOutputHelper)
{
	[Fact]
	public async Task GetOrganizations_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var organizations = await TestMerakiClient.Organizations.GetOrganizationsAsync(default);
		_ = organizations.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}

	[Fact]
	public async Task GetOrganizationWirelessDevicesPacketLossAsync_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var packetLoss = await TestMerakiClient
			.Wireless
			.Devices
			.PacketLoss
			.GetOrganizationWirelessDevicesPacketLossAsync(
				TestOrganizationId,
				perPage: 100,
				cancellationToken: default);
		_ = packetLoss.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}
}
