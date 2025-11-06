namespace Meraki.Api.Test.Devices.SensorCommands;

public class Tests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task CreateDeviceSensorCommand_EnableDownstreamPower_Succeeds()
	{
		var command = await TestMerakiClient
				.Devices
				.SensorCommands
				.CreateDeviceSensorCommandAsync(
					Configuration.TestMt40Serial,
					new()
					{
						Operation = SensorCommandOperation.EnableDownstreamPower
					},
					CancellationToken
				);

		_ = command.Status.Should().Be("pending");
	}

	[Fact]
	public async Task GetDeviceSensorCommandsAll_Succeeds()
	{
		var commands = await TestMerakiClient
			.Devices
			.SensorCommands
			.GetDeviceSensorCommandsAllAsync(
				Configuration.TestMt40Serial,
				cancellationToken: CancellationToken);

		_ = commands.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetDeviceSensorCommands_Paged_Succeeds()
	{
		var commands = await TestMerakiClient
			.Devices
			.SensorCommands
			.GetDeviceSensorCommandsAsync(
				Configuration.TestMt40Serial,
				perPage: 3,
				cancellationToken: CancellationToken);

		_ = commands.Should().NotBeEmpty();
		_ = commands.Should().HaveCount(3);
	}
}
