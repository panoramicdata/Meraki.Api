namespace Meraki.Api.Test.Appliance.Vpn.ThirdPartyVpnPeers;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetAllThirdPartyVpnPeersAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Appliance
			.Vpn
			.ThirdPartyVpnPeers
			.GetOrganizationApplianceVpnThirdPartyVPNPeersAsync(Configuration.TestOrganizationId, CancellationToken);
		_ = result.Should().BeOfType<Data.ThirdPartyVpnPeers>();
		_ = result.Should().NotBeNull();
	}
}
