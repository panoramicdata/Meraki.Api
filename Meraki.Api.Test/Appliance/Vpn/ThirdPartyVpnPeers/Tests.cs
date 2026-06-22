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
			.GetOrganizationApplianceVpnThirdPartyVPNPeersAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		_ = result.Should().BeOfType<global::Meraki.Api.Data.ThirdPartyVpnPeers>();
		_ = result.Should().NotBeNull();
	}
}
