using FluentAssertions;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;
public class EarlyAccessFeatureTests : MerakiClientUnitTest
{
	public EarlyAccessFeatureTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task BasicGet_Features_Suceeds()
	{
		var result = await TestMerakiClient.Organizations.EarlyAccess.Features.GetOrganizationEarlyAccessFeaturesAsync(TestOrganizationId);
		_ = result.Should().NotBeNullOrEmpty();

	}
}
