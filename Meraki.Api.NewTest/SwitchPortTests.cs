using FluentAssertions;
using Meraki.Api.Extensions;
using Xunit.Abstractions;

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

		// ACT
		var updatedPort = await TestMerakiClient
					.Switch
					.Ports
					.UpdateDeviceSwitchPortSetPortScheduleIdAsync(
						TestSwitchSerial,
						"1",
						null,
						CancellationToken.None);

		// ASSERT
		_ = updatedPort.Should().NotBeNull();
		_ = updatedPort.PortScheduleId.Should().BeNull();
		_ = updatedPort.Vlan.Should().Be(firstPort?.Vlan);
	}
}
