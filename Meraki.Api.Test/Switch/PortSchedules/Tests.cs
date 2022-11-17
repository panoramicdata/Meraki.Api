namespace Meraki.Api.Test.Switch.PortSchedules;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetSwitchPortStatuses_Succeeds()
	{
		var switchPortSchedules = await TestMerakiClient
			.Switch
			.PortSchedules
			.GetNetworkSwitchPortSchedulesAsync(Configuration.TestNetworkId)
			.ConfigureAwait(false);

		_ = switchPortSchedules.Should().NotBeNull();
	}
}
