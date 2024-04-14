namespace Meraki.Api.Test.Networks.Vlans;
public class GetNetworkVlansTests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetAllNetworkVlans()
	{
		var network = await GetFirstNetworkAsync();

		var result = await TestMerakiClient
			.Appliance
			.Vlans
			.GetNetworkApplianceVlansAsync(network.Id);
		_ = result.Should().BeOfType<List<Vlan>>();
		_ = result.Should().NotBeNull();
	}
}
