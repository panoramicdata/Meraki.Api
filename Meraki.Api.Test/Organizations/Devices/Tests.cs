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

	[Fact]
	public async Task GetOrganizationDeviceAvailabilitiesChangeHistory_Succeeds()
	{
		var utcNow = DateTimeOffset.UtcNow;

		var result = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesAvailabilitiesChangeHistoryAsync(
				Configuration.TestOrganizationId,
				t0: utcNow.AddDays(-1).ToMerakiT0T1String(),
				t1: utcNow.ToMerakiT0T1String(),
				cancellationToken: CancellationToken);

		_ = result.Should().NotBeNull();

		foreach (var changeEvent in result)
		{
			_ = changeEvent.Network.Should().NotBeNull();
			_ = changeEvent.Device.Should().NotBeNull();
			_ = changeEvent.Device.Serial.Should().NotBeNullOrEmpty();
			_ = changeEvent.Category.Should().NotBeNullOrEmpty();
		}
	}
}
