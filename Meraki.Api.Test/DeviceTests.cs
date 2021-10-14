using FluentAssertions;
using Meraki.Api.Data;
using Meraki.Api.Extensions;
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
			var devices = await TestMerakiClient
				.Networks
				.GetAllDevicesAsync(Configuration.TestCameraNetworkId)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNull()
				.And
				.NotBeEmpty();

			var deviceSerial = devices[0].Serial;

			var device = await TestMerakiClient
				.Devices
				.GetAsync(deviceSerial)
				.ConfigureAwait(false);
			device.Should().NotBeNull();

			device.Serial.Should().Equals(deviceSerial);
			device.Firmware.Should().NotBeNull();
		}

		[Fact]
		public async void GetDevice_GetModelType_Succeeds()
		{
			var devices = await TestMerakiClient
				.Networks
				.GetAllDevicesAsync(Configuration.TestCameraNetworkId)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNull()
				.And
				.NotBeEmpty();

			devices.TrueForAll(d => d.GetModelType() == ModelType.Camera);
		}

		[Fact]
		public async void PutDeviceAsync_WithMoveMapMarker_Succeeds()
		{
			var devices = await TestMerakiClient
				.Networks
				.GetAllDevicesAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNullOrEmpty();

			var deviceSerial = devices[0].Serial;

			var device = await TestMerakiClient
				.Devices
				.GetAsync(deviceSerial)
				.ConfigureAwait(false);

			device.Should().NotBeNull();
			device.Serial.Should().Equals(deviceSerial);
			device.Firmware.Should().NotBeNull();

			if (device.Address != string.Empty)
			{
				device.Address = string.Empty;
				await TestMerakiClient
					.Devices
					.UpdateAsync(
						device.Serial,
						device
					)
					.ConfigureAwait(false);
			}
			//Device now has blank address

			device.Address = "Picadilly Circus, London";
			device.MoveMapMarker = true;
			var updatedDevice = await TestMerakiClient
				.Devices
				.UpdateAsync(
					device.Serial,
					device
				)
				.ConfigureAwait(false);

			updatedDevice.Should().NotBeNull();
		}

		[Fact]
		public async void BlinkDeviceAsync_Succeeds()
		{
			var deviceStatuses = await TestMerakiClient
				.Organizations
				.GetDeviceStatusesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);

			deviceStatuses
				.Should()
				.NotBeNullOrEmpty();

			var onlineDevice = deviceStatuses.Find(d => d.Status == "online");
			onlineDevice.Should().NotBeNull("Could not find an online device");

			var outcome = await TestMerakiClient
				.Devices
				.BlinkLedsAsync(
					onlineDevice!.Serial,
					new DeviceLedsBlinkRequest
					{
						Duration = 10,
						Period = 500
					})
				.ConfigureAwait(false);

			outcome
				.Should()
				.NotBeNull();
		}

		// Test disabled - could only test with temporary credentials.
		[Fact]
		public async void GetDeviceNetworkManagementSettingsAsync_Succeeds()
		{
			var devices = await TestMerakiClient
				.Networks
				.GetAllDevicesAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);

			devices
				.Should()
				.NotBeNull()
				.And
				.NotBeEmpty();

			var deviceSerial = devices[0].Serial;

			var deviceManagementInterfaceSettings = await TestMerakiClient
				.Devices
				.GetManagementInterfaceAsync(deviceSerial)
				.ConfigureAwait(false);

			deviceManagementInterfaceSettings
				.Should()
				.NotBeNull();
		}
	}
}
