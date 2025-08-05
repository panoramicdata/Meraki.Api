namespace Meraki.Api.Test.Switch.Stacks;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetNetworkSwitchStacksAsync_Succeeds()
	{
		_ = Configuration.TestCameraNetworkId.Should().NotBeNull();

		var switchStacks = await TestMerakiClient
			.Switch
			.Stacks
			.GetNetworkSwitchStacksAsync(Configuration.TestCameraNetworkId, CancellationToken);

		_ = switchStacks.Should().NotBeNull();
	}
}