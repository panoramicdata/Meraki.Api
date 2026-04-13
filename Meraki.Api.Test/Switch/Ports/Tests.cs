namespace Meraki.Api.Test.Switch.Ports;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetSwitchPortStatuses_Succeeds()
	{
		var switchPorts = await TestMerakiClient
			.Switch
			.Ports
			.GetDeviceSwitchPortsAsync(
				Configuration.TestDeviceSerial,
				cancellationToken: CancellationToken);

		_ = switchPorts.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task ClearPortScheduleId_Succeeds()
	{
		// ARRANGE
		var switchPorts = await TestMerakiClient
			.Switch
			.Ports
			.GetDeviceSwitchPortsAsync(
				Configuration.TestDeviceSerial,
				cancellationToken: CancellationToken);

		var switchPort = switchPorts[0];
		_ = switchPort.PortScheduleId.Should().NotBeNullOrEmpty();
		_ = switchPort.PortId.Should().NotBeNullOrEmpty();

		// ACT
		switchPort.PortScheduleId = null;
		var switchPortAfterUpdate = await TestMerakiClient
			.Switch
			.Ports
			.UpdateDeviceSwitchPortAsync(
				Configuration.TestDeviceSerial,
				switchPort.PortId,
				switchPort,
				cancellationToken: CancellationToken);

		// ASSERT
		_ = switchPortAfterUpdate.Should().NotBeNull();
		_ = switchPortAfterUpdate.PortScheduleId.Should().BeNull();
	}
}
