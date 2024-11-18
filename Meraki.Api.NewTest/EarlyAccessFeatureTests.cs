using FluentAssertions;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;
public class EarlyAccessFeatureTests(ITestOutputHelper testOutputHelper) : MerakiClientUnitTest(testOutputHelper)
{
	[Fact]
	public async Task BasicGet_Features_Succeeds()
	{
		var result = await TestMerakiClient.Organizations.EarlyAccess.Features.GetOrganizationEarlyAccessFeaturesAsync(TestOrganizationId);
		_ = result.Should().NotBeNullOrEmpty();

	}

	[Fact]
	public async Task BasicGet_GetOptIns_Succeeds()
	{
		var result = await TestMerakiClient.Organizations.EarlyAccess.Features.GetOrganizationEarlyAccessFeaturesOptInsAsync(TestOrganizationId);
		_ = result.Should().NotBeNullOrEmpty();

	}
}
