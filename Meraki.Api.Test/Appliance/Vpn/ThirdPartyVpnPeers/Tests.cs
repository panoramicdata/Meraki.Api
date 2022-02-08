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
		result.Should().BeOfType<Data.ThirdPartyVpnPeers>();
		result.Should().NotBeNull();
	}
}
