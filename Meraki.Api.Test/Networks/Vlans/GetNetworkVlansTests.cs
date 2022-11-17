namespace Meraki.Api.Test.Networks.Vlans;
public class GetNetworkVlansTests : MerakiClientTest
{
	public GetNetworkVlansTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetAllNetworkVlans()
	{
		var network = await GetFirstNetworkAsync()
			.ConfigureAwait(false);

		var result = await TestMerakiClient
			.Appliance
			.Vlans
			.GetNetworkApplianceVlansAsync(network.Id)
			.ConfigureAwait(false);
		_ = result.Should().BeOfType<List<Vlan>>();
		_ = result.Should().NotBeNull();
	}
}
