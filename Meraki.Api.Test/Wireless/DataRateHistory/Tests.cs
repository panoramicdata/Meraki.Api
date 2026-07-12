namespace Meraki.Api.Test.Wireless.DataRateHistory;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	// Verifies the newly-wired WirelessSection.DataRateHistory endpoint (the only new part of the wireless section -
	// RF Health, latency and channel utilization were already wired and proven). Like the RF Health test, not every
	// network returns data: if this is empty, point TestNetworkId at a wireless network with recent traffic.
	[Fact]
	public async Task GetNetworkWirelessDataRateHistory_Succeeds()
	{
		var result = await TestMerakiClient
			.Wireless
			.DataRateHistory
			.GetNetworkWirelessDataRateHistoryAsync(
				Configuration.TestNetworkId,
				timespan: 86400,
				resolution: 3600,
				cancellationToken: CancellationToken);

		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();

		var first = result[0];
		_ = first.StartTs.Should().NotBeNullOrEmpty();
		_ = first.EndTs.Should().NotBeNullOrEmpty();
	}
}
