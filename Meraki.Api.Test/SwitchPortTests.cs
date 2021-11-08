using FluentAssertions;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class SwitchPortTests : MerakiClientTest
	{
		public SwitchPortTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetSwitchPortStatuses_Succeeds()
		{
			var switchPorts = await TestMerakiClient
				.SwitchPorts
				.GetAllAsync(Configuration.TestDeviceSerial)
				.ConfigureAwait(false);

			switchPorts.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async Task ClearPortScheduleId_Succeeds()
		{
			// ARRANGE
			var switchPorts = await TestMerakiClient
				.SwitchPorts
				.GetAllAsync(Configuration.TestDeviceSerial)
				.ConfigureAwait(false);

			var switchPort = switchPorts[0];
			switchPort.PortScheduleId.Should().NotBeNullOrEmpty();

			// ACT
			switchPort.PortScheduleId = null;
			var switchPortAfterUpdate = await TestMerakiClient
				.SwitchPorts
				.UpdateDeviceSwitchPortAsync(Configuration.TestDeviceSerial, switchPort.PortId, switchPort)
				.ConfigureAwait(false);

			// ASSERT
			switchPortAfterUpdate.Should().NotBeNull();
			switchPortAfterUpdate.PortScheduleId.Should().BeNull();
		}
	}
}
