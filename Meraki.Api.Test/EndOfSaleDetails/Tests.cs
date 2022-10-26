namespace Meraki.Api.Test.EndOfSaleDetails;
public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetEndOfLifeDetailsAsync_Succeeds()
	{
		var details = await MerakiClient
			.GetEndOfLifeDetailsAsync()
			.ConfigureAwait(false);

		details
			.Should()
			.BeOfType<List<DeviceModelEndOfLifeDetail>>();

		details
			.Should()
			.NotBeNull();

		// Regions should all have two letters
		details
			.Select(x => x.Region)
			.Where(x => x != null)
			.Should()
			.OnlyContain(x => x.Length == 2);

		// Device models should all start with M
		details
			.Select(x => x.DeviceModel)
			.Should()
			.OnlyContain(x => x.StartsWith("M"));
	}
}