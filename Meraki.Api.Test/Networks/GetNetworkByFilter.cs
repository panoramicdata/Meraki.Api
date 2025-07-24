namespace Meraki.Api.Test.Networks;
public class GetNetworkByFilter(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetNetworksByTagFilter()
	{
		var networks = await TestMerakiClient
			.Organizations.Networks.GetOrganizationNetworksAllAsync(
			Configuration.TestOrganizationId,
			tags: ["123", "network_level"],
			cancellationToken: CancellationToken);

		_ = networks.Should().NotBeEmpty();
	}
}
