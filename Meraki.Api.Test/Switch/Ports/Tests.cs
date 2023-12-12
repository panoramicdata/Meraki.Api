namespace Meraki.Api.Test.Switch.Ports;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetSwitchPortStatuses_Succeeds()
	{
		var switchPorts = await TestMerakiClient
			.Switch
			.Ports
			.GetDeviceSwitchPortsAsync(Configuration.TestDeviceSerial, default);

		_ = switchPorts.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task ClearPortScheduleId_Succeeds()
	{
		// ARRANGE
		var switchPorts = await TestMerakiClient
			.Switch
			.Ports
			.GetDeviceSwitchPortsAsync(Configuration.TestDeviceSerial);

		var switchPort = switchPorts[0];
		_ = switchPort.PortScheduleId.Should().NotBeNullOrEmpty();

		// ACT
		switchPort.PortScheduleId = null;
		var switchPortAfterUpdate = await TestMerakiClient
			.Switch.Ports
			.UpdateDeviceSwitchPortAsync(Configuration.TestDeviceSerial, switchPort.PortId, switchPort);

		// ASSERT
		_ = switchPortAfterUpdate.Should().NotBeNull();
		_ = switchPortAfterUpdate.PortScheduleId.Should().BeNull();
	}
}
