namespace Meraki.Api.Test.Organizations.Clients;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetOrganizationClients_Succeeds()
	{
		var organizationClientSearch = await TestMerakiClient
			.Organizations
			.Clients
			.GetOrganizationClientsSearchAsync(Configuration.TestOrganizationId, Configuration.TestMac, cancellationToken: CancellationToken);

		_ = organizationClientSearch.Should().NotBeNull();
	}
}
