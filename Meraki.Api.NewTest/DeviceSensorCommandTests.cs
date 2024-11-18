using FluentAssertions;
using Meraki.Api.Data;
using Meraki.Api.Extensions;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;

[Collection("API Collection")]
public class DeviceSensorCommandTests(ITestOutputHelper testOutputHelper) : MerakiClientUnitTest(testOutputHelper)
{
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

	[Fact]
	public async Task GetAll_Succeeds()
	{
		var commands = await TestMerakiClient
			.Devices
			.SensorCommands
			.GetDeviceSensorCommandsAllAsync(TestMt40DeviceSerial);

		_ = commands.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetAllPaged_Succeeds()
	{
		var commands = await TestMerakiClient
			.Devices
			.SensorCommands
			.GetDeviceSensorCommandsAsync(TestMt40DeviceSerial, perPage: 3);

		_ = commands.Should().NotBeEmpty();
		_ = commands.Should().HaveCount(3);
	}
}
