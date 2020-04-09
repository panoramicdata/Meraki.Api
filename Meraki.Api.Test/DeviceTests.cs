using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class DeviceTests : MerakiClientTest
	{
		public DeviceTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetDeviceAsync_Succeeds()
		{
			var devices = await MerakiClient
				.Devices
				.GetAllByNetworkAsync(Configuration.TestCameraNetworkId)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNull()
				.And
				.NotBeEmpty();

			var deviceSerial = devices[0].Serial;

			var device = await MerakiClient
				.Devices
				.GetAsync(Configuration.TestCameraNetworkId, deviceSerial)
				.ConfigureAwait(false);
			device.Should().NotBeNull();

			device.Serial.Should().Equals(deviceSerial);
			device.Firmware.Should().NotBeNull();
		}
	}
}
