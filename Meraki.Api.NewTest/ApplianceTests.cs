using FluentAssertions;
using Meraki.Api.Extensions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;

[Collection("API Collection")]
public class ApplianceTests(ITestOutputHelper testOutputHelper) : MerakiClientUnitTest(testOutputHelper)
{
	[Fact]
	public async Task GetOrganizationApplianceVpnStatsAllAsync_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var vpnStats = await TestMerakiClient
			.Appliance
			.Vpn
			.Stats
			.GetOrganizationApplianceVpnStatsAllAsync(
				TestOrganizationId,
				cancellationToken: default);
		_ = vpnStats.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BeGreaterThan(0);
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}
}
