namespace Meraki.Api.Test.Organizations.InventoryDevices;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetInventoryAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.InventoryDevices
			.GetOrganizationInventoryDevicesAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetInventoryAllAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.InventoryDevices
			.GetOrganizationInventoryDevicesAllAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
