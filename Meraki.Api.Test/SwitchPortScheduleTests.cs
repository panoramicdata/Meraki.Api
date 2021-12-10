namespace Meraki.Api.Test;

public class SwitchPortScheduleTests : MerakiClientTest
{
	public SwitchPortScheduleTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetSwitchPortStatuses_Succeeds()
	{
		var switchPortSchedules = await TestMerakiClient
			.Switch.PortSchedules
			.GetNetworkSwitchPortSchedulesAsync(Configuration.TestNetworkId)
			.ConfigureAwait(false);

		switchPortSchedules.Should().NotBeNull();
	}
}
