namespace Meraki.Api.Test.Networks;
public class GetNetworkByFilter : MerakiClientTest
{
	public GetNetworkByFilter(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetNetworksByTagFilter()
	{
		var networks = await TestMerakiClient
			.Organizations.Networks.GetOrganizationNetworksAllAsync(
			Configuration.TestOrganizationId,
			tags: new List<string> { "123", "network_level" })
			.ConfigureAwait(false);

		_ = networks.Should().NotBeEmpty();
	}
}
