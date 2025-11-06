namespace Meraki.Api.NewTest;

[Collection("API Collection")]
public class UplinkUsageTests(ITestOutputHelper testOutputHelper) : MerakiClientUnitTest(testOutputHelper)
{
	[Fact]
	public async Task UplinkUsage_Succeeds()
	{
		// Get Appliance Networks
		var networks = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(TestOrganizationId, productTypes: [ProductType.Appliance]);

		if (networks.Count == 0)
		{
			// No appliance networks to test
			return;
		}

		// Get the first appliance network
		var applianceNetwork = networks.First();

		// Get the uplink usage history
		var uplinkUsageHistory = await TestMerakiClient
		.Appliance
		.Uplinks
		.UsageHistory
		.GetNetworkApplianceUplinksUsageHistoryAsync(
			applianceNetwork.Id,
			timespan: 7200);

		_ = uplinkUsageHistory.Should().NotBeNull();
	}
}
