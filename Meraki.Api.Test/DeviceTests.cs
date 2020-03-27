using FluentAssertions;
using Xunit;

namespace Meraki.Api.Test
{
	public class DeviceTests : MerakiClientTest
	{
		[Fact]
		public async void GetDeviceAsync_Succeeds()
		{
			var network = await GetCameraNetworkAsync()
				.ConfigureAwait(false);

			var devices = await MerakiClient
				.Networks
				.GetDevicesAsync(network.Id)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNull()
				.And
				.NotBeEmpty();

			var deviceSerial = devices[0].Serial;

			var device = await MerakiClient
				.Devices
				.GetAsync(network.Id, deviceSerial)
				.ConfigureAwait(false);
			device.Should().NotBeNull();

			device.Serial.Should().Equals(deviceSerial);
			device.Firmware.Should().NotBeNull();
		}
	}
}
