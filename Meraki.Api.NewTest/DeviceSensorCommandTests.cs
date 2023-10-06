using FluentAssertions;
using Meraki.Api.Data;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;

[Collection("API Collection")]
public class DeviceSensorCommandTests : MerakiClientUnitTest
{
	public DeviceSensorCommandTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task EnableMT40Device_Succeeds()
	{
		var command = await TestMerakiClient
				.Devices
				.SensorCommands
				.CreateDeviceSensorCommandAsync(
					TestMt40DeviceSerial,
					new()
					{
						Operation = SensorCommandOperation.EnableDownstreamPower
					},
					CancellationToken.None
				);

		_ = command.Status.Should().Be("pending");
	}
}
