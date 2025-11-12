namespace Meraki.Api.Test.Appliance.Dhcp;

public class DhcpTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task GetDhcpSubNetsForSwitch_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();

		var dhcpSubnets = await TestMerakiClient
			.Appliance
			.Dhcp
			.Subnets
			.GetDeviceApplianceDhcpSubnetsAsync(
				Configuration.TestSwitchSerial,
				cancellationToken: CancellationToken);
		
		_ = dhcpSubnets.Should().NotBeNullOrEmpty();

		TestOutputHelper.WriteLine($"Stats: {TestMerakiClient.Statistics}");
	}
}
