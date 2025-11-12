using System.Globalization;

namespace Meraki.Api.Test.Appliance;

public class ApplianceTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task GetOrganizationApplianceVpnStatsAll_BetweenT0AndT1_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();

		var utcNow = DateTime.UtcNow;
		var vpnStatsLastHour = await TestMerakiClient
			.Appliance
			.Vpn
			.Stats
			.GetOrganizationApplianceVpnStatsAllAsync(
				Configuration.TestOrganizationId,
				t0: utcNow.AddHours(-1).ToMerakiT0T1String(),
				t1: utcNow.ToMerakiT0T1String(),
				cancellationToken: CancellationToken);
		_ = vpnStatsLastHour.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		TestOutputHelper.WriteLine($"Stats: {TestMerakiClient.Statistics}");
	}

	[Fact]
	public async Task GetOrganizationApplianceVpnStatsAll_WithTimeSpan_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var vpnStatsLastDay = await TestMerakiClient
			.Appliance
			.Vpn
			.Stats
			.GetOrganizationApplianceVpnStatsAllAsync(
				Configuration.TestOrganizationId,
				timespan: 24 * 60 * 60, // 24 hours in seconds
				cancellationToken: CancellationToken);
		_ = vpnStatsLastDay.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		TestOutputHelper.WriteLine($"Stats: {TestMerakiClient.Statistics}");
	}

	[Fact]
	public async Task GetOrganizationApplianceVpnStatsAll_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var vpnStats = await TestMerakiClient
			.Appliance
			.Vpn
			.Stats
			.GetOrganizationApplianceVpnStatsAllAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		_ = vpnStats.Should().NotBeEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		TestOutputHelper.WriteLine($"Stats: {TestMerakiClient.Statistics}");
	}

	[Fact]
	public async Task GetDeviceLldpCdp_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var lldpCdp = await TestMerakiClient
			.Devices
			.LldpCdp
			.GetDeviceLldpCdpAsync(
				Configuration.TestDeviceSerial,
				timespan: 24 * 60 * 60, // 24 hours in seconds
				cancellationToken: CancellationToken);
		_ = lldpCdp.Should().NotBeNull();
		_ = lldpCdp.Ports.Should().NotBeEmpty();
		_ = lldpCdp.Ports.Keys.Should().Contain("wan0");
		_ = lldpCdp.PortsFixed.Should().NotBeEmpty();
		_ = lldpCdp.PortsFixed.Keys.Should().NotContain("wan0");

		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		TestOutputHelper.WriteLine($"Stats: {TestMerakiClient.Statistics}");
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
				Configuration.TestDeviceSerial,
				"8.8.8.8",
				startDateTime.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture),
				endDateTime.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture),
				null,
				3600, // 1 hour in seconds,"
				cancellationToken: CancellationToken);
		_ = lossAndLatencyHistory.Should().NotBeNullOrEmpty();
		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BePositive();
		TestOutputHelper.WriteLine($"Stats: {TestMerakiClient.Statistics}");
	}
}
