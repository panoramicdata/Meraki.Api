namespace Meraki.Api.Test.Switch.Stacks;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetNetworkSwitchStacksAsync_Succeeds()
	{
		Configuration.TestCameraNetworkId.Should().NotBeNull();

		var switchStacks = await TestMerakiClient
			.Switch
			.Stacks
			.GetNetworkSwitchStacksAsync(Configuration.TestCameraNetworkId, default)
			.ConfigureAwait(false);

		switchStacks.Should().NotBeNull();
	}
}