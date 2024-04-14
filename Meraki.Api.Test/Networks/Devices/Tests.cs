namespace Meraki.Api.Test.Networks.Devices;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetAllDevicesAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync();

		var result = await TestMerakiClient
			.Networks
			.Devices
			.GetNetworkDevicesAsync(network.Id);
		_ = result.Should().BeOfType<List<Device>>();
		_ = result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetDeviceAsync_Succeeds()
	{
		var devices = await TestMerakiClient
			.Networks
			.Devices
			.GetNetworkDevicesAsync(Configuration.TestCameraNetworkId);

		_ = devices
			.Should()
			.NotBeNull()
			.And
			.NotBeEmpty();

		var deviceSerial = devices[0].Serial;

		var device = await TestMerakiClient
			.Devices
			.GetDeviceAsync(deviceSerial);
		_ = device.Should().NotBeNull();

		_ = device.Serial.Should().Equals(deviceSerial);
		_ = device.Firmware.Should().NotBeNull();
	}

	[Fact]
	public async Task GetDevice_GetModelType_Succeeds()
	{
		var devices = await TestMerakiClient
			.Networks
			.Devices
			.GetNetworkDevicesAsync(Configuration.TestCameraNetworkId);

		_ = devices
			.Should()
			.NotBeNull()
			.And
			.NotBeEmpty();

		_ = devices.TrueForAll(d => d.GetModelType() == ModelType.Camera);
	}
}
