using Microsoft.Extensions.Logging;
using System.Globalization;

namespace Meraki.Api.NewTest;

[Collection("API Collection")]
public class ApplianceTests(ITestOutputHelper testOutputHelper) : MerakiClientUnitTest(testOutputHelper)
{
	[Fact]
	public async Task GetOrganizationApplianceVpnStatsAllAsync_BetweenT0AndT1_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();

		var utcNow = DateTime.UtcNow;
		var vpnStatsLastHour = await TestMerakiClient
			.Appliance
			.Vpn
			.Stats
			.GetOrganizationApplianceVpnStatsAllAsync(
				TestOrganizationId,
				t0: utcNow.AddHours(-1).ToMerakiT0T1String(),
				t1: utcNow.ToMerakiT0T1String(),
				cancellationToken: default);
		_ = vpnStatsLastHour.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}

	[Fact]
	public async Task GetOrganizationApplianceVpnStatsAllAsync_WithTimeSpan_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var vpnStatsLastDay = await TestMerakiClient
			.Appliance
			.Vpn
			.Stats
			.GetOrganizationApplianceVpnStatsAllAsync(
				TestOrganizationId,
				timespan: 24 * 60 * 60, // 24 hours in seconds
				cancellationToken: default);
		_ = vpnStatsLastDay.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}

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
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}

	[Fact]
	public async Task GetDeviceLldpCdpAsync_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var lldpCdp = await TestMerakiClient
			.Devices
			.LldpCdp
			.GetDeviceLldpCdpAsync(
				TestApplianceSerial,
				timespan: 24 * 60 * 60, // 24 hours in seconds
				cancellationToken: default);
		_ = lldpCdp.Should().NotBeNull();
		_ = lldpCdp.Ports.Should().NotBeEmpty();
		_ = lldpCdp.Ports.Keys.Should().Contain("wan0");
		_ = lldpCdp.PortsFixed.Should().NotBeEmpty();
		_ = lldpCdp.PortsFixed.Keys.Should().NotContain("wan0");

		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}

	[Fact]
	public async Task GetDeviceLossAndLatencyHistory_Succeeds()
	{
		var utcNow = DateTime.UtcNow;
		var startDateTime = utcNow.Date.AddHours(utcNow.Hour - 2);
		var endDateTime = startDateTime.AddHours(1);

		TestMerakiClient.Statistics.Reset();
		var lossAndLatencyHistory = await TestMerakiClient
			.Devices
			.LossAndLatencyHistory
			.GetDeviceLossAndLatencyHistoryAsync(
				TestApplianceSerial,
				"8.8.8.8",
				startDateTime.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture),
				endDateTime.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture),
				null,
				3600, // 1 hour in seconds,"
				cancellationToken: default);
		_ = lossAndLatencyHistory.Should().NotBeNullOrEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}
}
