using FluentAssertions;
using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class WirelessHealthTests : MerakiClientTest
	{
		private readonly double _timespan = TimeSpan.FromDays(7).TotalSeconds;

		public WirelessHealthTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetNetworkClientLatencyStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
			Configuration.TestMac.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkClientLatencyStatsAsync(
					Configuration.TestNetworkId,
					Configuration.TestMac,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
			stats.Mac.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetNetworkClientsLatencyStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkClientsLatencyStatsAsync(
					Configuration.TestNetworkId,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
			stats.FirstOrDefault()?.Mac.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetNetworkDeviceLatencyStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
			Configuration.TestDeviceSerial.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkDeviceLatencyStatsAsync(
					Configuration.TestNetworkId,
					Configuration.TestDeviceSerial,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
			stats.Serial.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetNetworkDevicesLatencyStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkDevicesLatencyStatsAsync(
					Configuration.TestNetworkId,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
			stats.FirstOrDefault()?.Serial.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetNetworkLatencyStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkLatencyStatsAsync(
					Configuration.TestNetworkId,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
		}

		[Fact]
		public async void GetNetworkClientConnectionStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
			Configuration.TestMac.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkClientConnectionStatsAsync(
					Configuration.TestNetworkId,
					Configuration.TestMac,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
			stats.Mac.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetNetworkClientsConnectionStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkClientsConnectionStatsAsync(
					Configuration.TestNetworkId,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
			stats.FirstOrDefault()?.Mac.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetNetworkDeviceConnectionStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();
			Configuration.TestDeviceSerial.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkDeviceConnectionStatsAsync(
					Configuration.TestNetworkId,
					Configuration.TestDeviceSerial,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
			stats.Serial.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetNetworkDevicesConnectionStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkDevicesConnectionStatsAsync(
					Configuration.TestNetworkId,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
			stats.FirstOrDefault()?.Serial.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetNetworkConnectionStats_Succeeds()
		{
			Configuration.TestNetworkId.Should().NotBeNullOrEmpty();

			var stats = await MerakiClient
				.WirelessHealth
				.GetNetworkConnectionStatsAsync(
					Configuration.TestNetworkId,
					timespan: _timespan,
					cancellationToken: default)
				.ConfigureAwait(false);

			stats.Should().NotBeNull();
		}
	}
}
