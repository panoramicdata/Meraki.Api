namespace Meraki.Api.Test.Switch.PortSchedules;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetSwitchPortStatuses_Succeeds()
	{
		var switchPortSchedules = await TestMerakiClient
			.Switch
			.PortSchedules
			.GetNetworkSwitchPortSchedulesAsync(Configuration.TestNetworkId, cancellationToken: CancellationToken);

		_ = switchPortSchedules.Should().NotBeNull();
	}
}
