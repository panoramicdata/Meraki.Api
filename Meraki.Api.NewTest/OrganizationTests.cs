using FluentAssertions;
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
		var organizations = await TestMerakiClient.Organizations.GetOrganizationsAsync(default);
		_ = organizations.Should().NotBeEmpty();
	}
}
