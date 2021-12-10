namespace Meraki.Api.Test;

public class SwitchPortStatusTests : MerakiClientTest
{
	public SwitchPortStatusTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetSwitchPortStatuses_Succeeds()
	{
		var switchPortStatuses = await TestMerakiClient
			.Switch.Ports
			.GetDeviceSwitchPortsStatusesAsync(Configuration.TestDeviceSerial)
			.ConfigureAwait(false);

		switchPortStatuses.Should().NotBeNullOrEmpty();
	}
}
