namespace Meraki.Api.Test.SecureConnect;

public class Tests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task GetOrganizationSecureConnectSitesAll_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();

		// Get the sites with different page sizes

		var secureConnectOrgSites100 = await TestMerakiClient
			.Organizations
			.SecureConnect
			.Sites
			.GetOrganizationSecureConnectSitesAllAsync(
				Configuration.TestOrganizationId,
				pageSize: 100,
				cancellationToken: CancellationToken);

		var secureConnectOrgSites1000 = await TestMerakiClient
			.Organizations
			.SecureConnect
			.Sites
			.GetOrganizationSecureConnectSitesAllAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		// Get the distinct site ids
		var secureConnectOrgSites100Distinct = new HashSet<string>(secureConnectOrgSites100.Select(s => s.Id));
		var secureConnectOrgSites1000Distinct = new HashSet<string>(secureConnectOrgSites1000.Select(s => s.Id));

		// The distinct count should match the original list in each case
		_ = secureConnectOrgSites100Distinct.Should().HaveCount(secureConnectOrgSites100.Count);
		_ = secureConnectOrgSites1000Distinct.Should().HaveCount(secureConnectOrgSites1000.Count);

		// The two lists should match
		_ = secureConnectOrgSites100Distinct.Should().BeEquivalentTo(secureConnectOrgSites1000Distinct);

		TestOutputHelper.WriteLine($"Stats: {TestMerakiClient.Statistics}");
		TestOutputHelper.WriteLine($"Count: {secureConnectOrgSites100Distinct.Count}");
	}
}
