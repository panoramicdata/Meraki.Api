namespace Meraki.Api.Test.Organizations.Devices;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetOrganizationDevices_Succeeds()
	{
		var organizationDevices = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesAsync(Configuration.TestOrganizationId,
					cancellationToken: CancellationToken);

		_ = organizationDevices.Should().NotBeNull();
	}

	[Fact]
	public async Task GetOrganizationDevicesAll_Succeeds()
	{
		var organizationDevices = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesAllAsync(Configuration.TestOrganizationId,
					cancellationToken: CancellationToken);

		_ = organizationDevices.Should().NotBeNull();
	}

	[Fact]
	public async Task GetOrganizationDeviceStatus_Succeeds()
	{
		var organizationDeviceStatus = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesStatusesAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		_ = organizationDeviceStatus.Should().NotBeNull();
	}

	[Fact]
	public async Task GetOrganizationDeviceStatusAll_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesStatusesAllAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
