namespace Meraki.Api.Test.Networks.BluetoothClients;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetBluetoothClientsAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync()
;

		var result = await TestMerakiClient
			.Networks
			.BluetoothClients
			.GetNetworkBluetoothClientsAsync(network.Id)
;
		_ = result.Should().BeOfType<List<BluetoothClient>>();
		_ = result.Should().NotBeNull();
	}
}
