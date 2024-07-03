using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;
[Collection("API Collection")]
public class OrganizationTests : MerakiClientUnitTest
{
	public OrganizationTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetOrganizations_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var organizations = await TestMerakiClient.Organizations.GetOrganizationsAsync(default);
		_ = organizations.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BeGreaterThan(0);
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}
}
