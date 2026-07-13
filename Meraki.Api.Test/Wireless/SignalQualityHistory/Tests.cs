namespace Meraki.Api.Test.Wireless.SignalQualityHistory;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	// Exercises WirelessSection.SignalQualityHistory (SNR / RSSI) - the endpoint DataMagic's WirelessHealth
	// signal-quality pass consumes (MS-24656 Phase 3c). Unlike the network-wide wireless-history endpoints,
	// signalQualityHistory REQUIRES a client / AP filter, so TestDeviceSerial must be a wireless access point
	// (MR / CW series) in TestNetworkId with recent client traffic. If this returns empty, point TestNetworkId /
	// TestDeviceSerial at such an access point.
	[Fact]
	public async Task GetNetworkWirelessSignalQualityHistory_ForAccessPoint_Succeeds()
	{
		var result = await TestMerakiClient
			.Wireless
			.SignalQualityHistory
			.GetNetworkWirelessSignalQualityHistoryAsync(
				Configuration.TestNetworkId,
				timespan: 86400,
				resolution: 3600,
				deviceSerial: Configuration.TestDeviceSerial,
				cancellationToken: CancellationToken);

		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();

		var first = result[0];
		_ = first.StartTs.Should().NotBeNullOrEmpty();
		_ = first.EndTs.Should().NotBeNullOrEmpty();
	}
}
