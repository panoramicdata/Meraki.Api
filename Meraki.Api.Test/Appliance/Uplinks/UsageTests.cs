namespace Meraki.Api.Test.Appliance.Uplinks;

public class UsageTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task GetNetworkApplianceUplinksUsageHistory_Succeeds()
	{
		// Get Appliance Networks
		var networks = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(
				Configuration.TestOrganizationId,
				productTypes: [ProductType.Appliance],
				cancellationToken: CancellationToken);

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
