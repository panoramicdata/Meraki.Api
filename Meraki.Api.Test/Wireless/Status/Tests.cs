namespace Meraki.Api.Test.Wireless.Status;

public class Tests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public void GetDeviceWirelessStatus_Succeeds()
	{
		// TODO: Add WirelessDeviceSerial1 and WirelessDeviceSerial2 to TestConfig if needed
		// For now, skip this test if the properties don't exist
		// var wirelessDevicesSerials = new List<string>
		// {
		// 	Configuration.WirelessDeviceSerial1,
		// 	Configuration.WirelessDeviceSerial2
		// };

		// TestMerakiClient.Statistics.Reset();
		// foreach (var deviceSerial in wirelessDevicesSerials)
		// {
		// 	var wirelessStatus = await TestMerakiClient
		// 		.Wireless
		// 		.Status
		// 		.GetDeviceWirelessStatusAsync(
		// 			deviceSerial,
		// 			cancellationToken: CancellationToken);
		// 	_ = wirelessStatus.Should().NotBeNull();
		// }

		// _ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
	}
}
