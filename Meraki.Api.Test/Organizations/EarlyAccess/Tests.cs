namespace Meraki.Api.Test.Organizations.EarlyAccess;

public class Tests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task GetOrganizationEarlyAccessFeatures_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.EarlyAccess
			.Features
			.GetOrganizationEarlyAccessFeaturesAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		_ = result.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetOrganizationEarlyAccessFeaturesOptIns_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.EarlyAccess
			.Features
			.GetOrganizationEarlyAccessFeaturesOptInsAsync(
				Configuration.TestOrganizationId,
				cancellation: CancellationToken);
		_ = result.Should().NotBeNullOrEmpty();
	}
}
