namespace Meraki.Api.Test.Organizations.Clients;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetOrganizationClients_Succeeds()
	{
		var organizationClientSearch = await TestMerakiClient
			.Organizations
			.Clients
			.GetOrganizationClientsSearchAsync(Configuration.TestOrganizationId, Configuration.TestMac)
			.ConfigureAwait(false);

		_ = organizationClientSearch.Should().NotBeNull();
	}
}
