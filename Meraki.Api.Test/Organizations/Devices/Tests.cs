namespace Meraki.Api.Test.Organizations.Devices;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetOrganizationDevices_Succeeds()
	{
		var organizationDevices = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesAsync(Configuration.TestOrganizationId, default)
			.ConfigureAwait(false);

		_ = organizationDevices.Should().NotBeNull();
	}

	[Fact]
	public async Task GetOrganizationDeviceStatus_Succeeds()
	{
		var organizationDeviceStatus = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesStatusesAsync(Configuration.TestOrganizationId, default)
			.ConfigureAwait(false);

		_ = organizationDeviceStatus.Should().NotBeNull();
	}

	[Fact]
	public async Task GetOrganizationDeviceStatusAll_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesStatusesAllAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
