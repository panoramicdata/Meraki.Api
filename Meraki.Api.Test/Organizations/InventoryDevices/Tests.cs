namespace Meraki.Api.Test.Organizations.InventoryDevices;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetInventoryAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.InventoryDevices
			.GetOrganizationInventoryDevicesAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetInventoryAllAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.InventoryDevices
			.GetOrganizationInventoryDevicesAllAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
