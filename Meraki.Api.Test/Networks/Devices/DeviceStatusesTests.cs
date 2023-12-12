namespace Meraki.Api.Test.Networks.Devices;

public class DeviceStatusesTests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetAllDevicesAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesStatusesAllAsync(
				Configuration.TestOrganizationId,
				networkIds: ["L_603482350067654439"]
				);
		_ = result.Should().BeOfType<List<OrganizationDeviceStatus>>();
		_ = result.Should().NotBeNull();
	}
}
