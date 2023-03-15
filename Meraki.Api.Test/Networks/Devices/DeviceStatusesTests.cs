namespace Meraki.Api.Test.Networks.Devices;

public class DeviceStatusesTests : MerakiClientTest
{
	public DeviceStatusesTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetAllDevicesAsync_Succeeds()
	{
		//var network = await GetFirstNetworkAsync()
		//	.ConfigureAwait(false);

		var result = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesStatusesAllAsync(
				Configuration.TestOrganizationId,
				networkIds: new List<string> { "L_603482350067654439" }
				)
			.ConfigureAwait(false);
		_ = result.Should().BeOfType<List<OrganizationDeviceStatus>>();
		_ = result.Should().NotBeNull();
	}
}
