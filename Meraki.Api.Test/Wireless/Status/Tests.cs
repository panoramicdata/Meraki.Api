namespace Meraki.Api.Test.Wireless.Status;

public class Tests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	// The body was previously commented out, so the test asserted nothing and always passed.
	// Restoring it needs WirelessDeviceSerial1 and WirelessDeviceSerial2 on TestConfig; until those
	// exist the gap is declared rather than hidden. See git history for the original body.
	[Fact(Skip = "Needs WirelessDeviceSerial1 and WirelessDeviceSerial2 on TestConfig.")]
	public void GetDeviceWirelessStatus_Succeeds()
	{
	}
}
