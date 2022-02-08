namespace Meraki.Api.Test.Switch.Ports;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetSwitchPortStatuses_Succeeds()
	{
		var switchPorts = await TestMerakiClient
			.Switch
			.Ports
			.GetDeviceSwitchPortsAsync(Configuration.TestDeviceSerial, default)
			.ConfigureAwait(false);

		switchPorts.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task ClearPortScheduleId_Succeeds()
	{
		// ARRANGE
		var switchPorts = await TestMerakiClient
			.Switch
			.Ports
			.GetDeviceSwitchPortsAsync(Configuration.TestDeviceSerial)
			.ConfigureAwait(false);

		var switchPort = switchPorts[0];
		switchPort.PortScheduleId.Should().NotBeNullOrEmpty();

		// ACT
		switchPort.PortScheduleId = null;
		var switchPortAfterUpdate = await TestMerakiClient
			.Switch.Ports
			.UpdateDeviceSwitchPortAsync(Configuration.TestDeviceSerial, switchPort.PortId, switchPort)
			.ConfigureAwait(false);

		// ASSERT
		switchPortAfterUpdate.Should().NotBeNull();
		switchPortAfterUpdate.PortScheduleId.Should().BeNull();
	}
}
