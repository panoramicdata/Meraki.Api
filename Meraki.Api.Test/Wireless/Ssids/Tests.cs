namespace Meraki.Api.Test.Wireless.Ssids;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetAllSsidsAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync()
			.ConfigureAwait(false);

		var result = await TestMerakiClient
			.Wireless
			.Ssids
			.GetNetworkWirelessSsidsAsync(network.Id)
			.ConfigureAwait(false);
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
