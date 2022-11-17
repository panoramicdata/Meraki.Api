namespace Meraki.Api.Test.Networks.Devices;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetAllDevicesAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync()
			.ConfigureAwait(false);

		var result = await TestMerakiClient
			.Networks
			.Devices
			.GetNetworkDevicesAsync(network.Id)
			.ConfigureAwait(false);
		_ = result.Should().BeOfType<List<Device>>();
		_ = result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetDeviceAsync_Succeeds()
	{
		var devices = await TestMerakiClient
			.Networks
			.Devices
			.GetNetworkDevicesAsync(Configuration.TestCameraNetworkId)
			.ConfigureAwait(false);

		_ = devices
			.Should()
			.NotBeNull()
			.And
			.NotBeEmpty();

		var deviceSerial = devices[0].Serial;

		var device = await TestMerakiClient
			.Devices
			.GetDeviceAsync(deviceSerial)
			.ConfigureAwait(false);
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
			.GetNetworkDevicesAsync(Configuration.TestCameraNetworkId)
			.ConfigureAwait(false);

		_ = devices
			.Should()
			.NotBeNull()
			.And
			.NotBeEmpty();

		_ = devices.TrueForAll(d => d.GetModelType() == ModelType.Camera);
	}
}
