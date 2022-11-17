namespace Meraki.Api.Test.Organizations.Appliance.Vpn.ThirdPartyVpnPeers;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetAllThirdPartyVpnPeersAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Appliance
			.Vpn
			.ThirdPartyVpnPeers
			.GetOrganizationApplianceVpnThirdPartyVPNPeersAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		_ = result.Should().BeOfType<Data.ThirdPartyVpnPeers>();
		_ = result.Should().NotBeNull();
	}
}
