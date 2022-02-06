namespace Meraki.Api.Test.Wireless.Client.LatencyStats;

public class Tests : MerakiClientTest
{
	private readonly double _timespan = TimeSpan.FromDays(7).TotalSeconds;

	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetNetworkClientLatencyStats_Succeeds()
	{
		Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
		Configuration.TestMac.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Clients
			.LatencyStats
			.GetNetworkWirelessClientLatencyStatsAsync(
				Configuration.TestNetworkId,
				Configuration.TestMac,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
		stats.Mac.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkClientsLatencyStats_Succeeds()
	{
		Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Clients
			.LatencyStats
			.GetNetworkWirelessClientsLatencyStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
		stats.FirstOrDefault()?.Mac.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkDeviceLatencyStats_Succeeds()
	{
		Configuration.TestDeviceSerial.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.LatencyStats
			.GetDeviceWirelessLatencyStatsAsync(
				Configuration.TestDeviceSerial,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
		stats.Serial.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkDevicesLatencyStats_Succeeds()
	{
		Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.LatencyStats
			.GetNetworkWirelessLatencyStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
		stats.BackgroundTraffic.Should().NotBeNull();
	}

	[Fact]
	public async Task GetNetworkLatencyStats_Succeeds()
	{
		Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.LatencyStats
			.GetNetworkWirelessLatencyStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
	}

	[Fact]
	public async Task GetNetworkClientConnectionStats_Succeeds()
	{
		Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
		Configuration.TestMac.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Clients
			.ConnectionStats
			.GetNetworkWirelessClientConnectionStatsAsync(
				Configuration.TestNetworkId,
				Configuration.TestMac,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
		stats.Mac.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkClientsConnectionStats_Succeeds()
	{
		Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Clients
			.ConnectionStats
			.GetNetworkWirelessClientsConnectionStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
		stats.FirstOrDefault()?.Mac.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkDeviceConnectionStats_Succeeds()
	{
		Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
		Configuration.TestDeviceSerial.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Devices
			.ConnectionStats
			.GetNetworkWirelessDevicesConnectionStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
	}

	[Fact]
	public async Task GetNetworkDevicesConnectionStats_Succeeds()
	{
		Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.Devices
			.ConnectionStats
			.GetNetworkWirelessDevicesConnectionStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
		stats.FirstOrDefault()?.Serial.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkConnectionStats_Succeeds()
	{
		Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

		var stats = await TestMerakiClient
			.Wireless
			.ConnectionStats
			.GetNetworkWirelessConnectionStatsAsync(
				Configuration.TestNetworkId,
				timespan: _timespan,
				cancellationToken: default)
			.ConfigureAwait(false);

		stats.Should().NotBeNull();
	}
}
