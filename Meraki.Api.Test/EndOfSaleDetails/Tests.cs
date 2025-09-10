namespace Meraki.Api.Test.EndOfSaleDetails;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetEndOfLifeDetailsAsync_Succeeds()
	{
		var details = await MerakiClient
			.GetEndOfLifeDetailsAsync(CancellationToken);

		_ = details
			.Should()
			.BeOfType<List<DeviceModelEndOfLifeDetail>>();

		_ = details
			.Should()
			.NotBeNull();

		// Regions should all have two letters
		_ = details
			.Select(x => x.Region)
			.Where(x => x != null)
			.Should()
			.OnlyContain(x => x.Length == 2);

		// Device models should all start with M
		_ = details
			.Select(x => x.DeviceModel)
			.Should()
			.OnlyContain(x => x.StartsWith('M'));
	}
}