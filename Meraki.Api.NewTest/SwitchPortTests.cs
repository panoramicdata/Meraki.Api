namespace Meraki.Api.NewTest;

[Collection("API Collection")]
public class SwitchPortTests(ITestOutputHelper testOutputHelper) : MerakiClientUnitTest(testOutputHelper)
{
	[Fact]
	public async Task UpdateDeviceSwitchPort_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();

		// ARRANGE
		var switchPorts = await TestMerakiClient
			.Switch
			.Ports
			.GetDeviceSwitchPortsAsync(TestSwitchSerial, CancellationToken.None);

		// pick the first port
		var firstPort = switchPorts.FirstOrDefault();

		if (firstPort == null || firstPort.PortId == null)
		{
			throw new InvalidOperationException("No switch ports found for the test switch.");
		}

		// ACT
		var updatedPort = await TestMerakiClient
					.Switch
					.Ports
					.UpdateDeviceSwitchPortSetPortScheduleIdAsync(
						TestSwitchSerial,
						firstPort.PortId,
						null,
						CancellationToken.None);

		// ASSERT
		_ = updatedPort.Should().NotBeNull();
		_ = updatedPort.PortScheduleId.Should().BeNull();
		_ = updatedPort.Vlan.Should().Be(firstPort?.Vlan);
	}

	[Fact]
	public async Task UpdateDeviceSwitchPortSetVlan_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		// ARRANGE
		var switchPorts = await TestMerakiClient
			.Switch
			.Ports
			.GetDeviceSwitchPortsAsync(TestSwitchSerial, CancellationToken.None);
		// pick the first port
		var firstPort = switchPorts.FirstOrDefault();

		if (firstPort == null || firstPort.PortId == null)
		{
			throw new InvalidOperationException("No switch ports found for the test switch.");
		}

		// ACT
		var updatedPort = await TestMerakiClient
					.Switch
					.Ports
					.UpdateDeviceSwitchPortSetVlanAsync(
						TestSwitchSerial,
						firstPort.PortId,
						null,
						CancellationToken.None);
		// ASSERT
		_ = updatedPort.Should().NotBeNull();
		_ = updatedPort.Vlan.Should().BeNull();
		_ = updatedPort.PortScheduleId.Should().Be(firstPort?.PortScheduleId);
	}
}
