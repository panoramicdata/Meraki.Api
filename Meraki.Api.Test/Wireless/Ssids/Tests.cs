namespace Meraki.Api.Test.Wireless.Ssids;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetAllSsidsAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync();

		var result = await TestMerakiClient
			.Wireless
			.Ssids
			.GetNetworkWirelessSsidsAsync(
				network.Id,
				cancellationToken: CancellationToken);

		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
