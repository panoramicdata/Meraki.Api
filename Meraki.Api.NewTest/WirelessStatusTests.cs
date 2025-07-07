using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;

[Collection("API Collection")]
public class WirelessStatusTests(ITestOutputHelper testOutputHelper) : MerakiClientUnitTest(testOutputHelper)
{
	[Fact]
	public async Task GetDeviceWirelessStatusAsync_Succeeds()
	{
		var wirelessDevicesSerials = new List<string>
		{
			TestConfig.WirelessDeviceSerial1,
			TestConfig.WirelessDeviceSerial2
		};

		TestMerakiClient.Statistics.Reset();
		foreach (var deviceSerial in wirelessDevicesSerials)
		{
			var wirelessStatus = await TestMerakiClient
			.Wireless
			.Status
			.GetDeviceWirelessStatusAsync(
				deviceSerial,
				cancellationToken: default);
			_ = wirelessStatus.Should().NotBeNull();
		}

		_ = TestMerakiClient.Statistics.TotalRequestCount.Should().BeGreaterThan(0);
		Logger.LogInformation("Stats: {Stats}", TestMerakiClient.Statistics);
	}
}
