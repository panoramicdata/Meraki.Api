namespace Meraki.Api.Test.Wireless.Client.LatencyStats;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	private readonly double _timespan = TimeSpan.FromDays(7).TotalSeconds;

	[Fact]
	public async Task GetNetworkClientLatencyStats_Succeeds()
	{
		_ = Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
		_ = Configuration.TestMac.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Clients
			.LatencyStats
			.GetNetworkWirelessClientLatencyStatsAsync(
				Configuration.TestNetworkId,
				Configuration.TestMac,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
		_ = stats.Mac.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkClientsLatencyStats_Succeeds()
	{
		_ = Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Clients
			.LatencyStats
			.GetNetworkWirelessClientsLatencyStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
		_ = (stats.FirstOrDefault()?.Mac.Should().NotBeNullOrEmpty());
	}

	[Fact]
	public async Task GetNetworkDeviceLatencyStats_Succeeds()
	{
		_ = Configuration.TestDeviceSerial.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.LatencyStats
			.GetDeviceWirelessLatencyStatsAsync(
				Configuration.TestDeviceSerial,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
		_ = stats.Serial.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkDevicesLatencyStats_Succeeds()
	{
		_ = Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.LatencyStats
			.GetNetworkWirelessLatencyStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
		_ = stats.BackgroundTraffic.Should().NotBeNull();
	}

	[Fact]
	public async Task GetNetworkLatencyStats_Succeeds()
	{
		_ = Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.LatencyStats
			.GetNetworkWirelessLatencyStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
	}

	[Fact]
	public async Task GetNetworkClientConnectionStats_Succeeds()
	{
		_ = Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
		_ = Configuration.TestMac.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Clients
			.ConnectionStats
			.GetNetworkWirelessClientConnectionStatsAsync(
				Configuration.TestNetworkId,
				Configuration.TestMac,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
		_ = stats.Mac.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkClientsConnectionStats_Succeeds()
	{
		_ = Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Clients
			.ConnectionStats
			.GetNetworkWirelessClientsConnectionStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
		_ = (stats.FirstOrDefault()?.Mac.Should().NotBeNullOrEmpty());
	}

	[Fact]
	public async Task GetNetworkDeviceConnectionStats_Succeeds()
	{
		_ = Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
		_ = Configuration.TestDeviceSerial.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Devices
			.ConnectionStats
			.GetNetworkWirelessDevicesConnectionStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
	}

	[Fact]
	public async Task GetNetworkDevicesConnectionStats_Succeeds()
	{
		_ = Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Devices
			.ConnectionStats
			.GetNetworkWirelessDevicesConnectionStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
		_ = (stats.FirstOrDefault()?.Serial.Should().NotBeNullOrEmpty());
	}

	[Fact]
	public async Task GetNetworkConnectionStats_Succeeds()
	{
		_ = Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.ConnectionStats
			.GetNetworkWirelessConnectionStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default);

		_ = stats.Should().NotBeNull();
	}
}
