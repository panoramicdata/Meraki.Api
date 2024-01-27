namespace Meraki.Api.Test.Environmental;

public class Tests : MerakiClientTest
{
	private readonly List<string> _serials;

	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
		_serials = new List<string>
		{
			Configuration.TestMt10Serial ?? string.Empty,
			Configuration.TestMt14Serial ?? string.Empty,
			Configuration.TestMt20Serial ?? string.Empty,
			Configuration.TestMt30Serial ?? string.Empty,
			Configuration.TestMt40Serial ?? string.Empty,
		}
		.Where(x => x.Length > 0)
		.ToList();
	}

	[Fact]
	public async Task GetLatestData_Succeeds()
	{
		if (!_serials.Any())
		{
			// We don't have a devices to test with
			return;
		}

		var deviceLatestReadings = await TestMerakiClient
			.Sensor
			.Readings
			.Latest
			.GetOrganizationSensorReadingsLatestAsync(Configuration.TestOrganizationId, perPage: 10, serials: _serials);

		_ = deviceLatestReadings
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetHistoricData_Succeeds()
	{
		if (!_serials.Any())
		{
			// We don't have a devices to test with
			return;
		}

		var deviceLatestReadings = await TestMerakiClient
			.Sensor
			.Readings
			.History
			.GetOrganizationSensorReadingsHistoryAsync(Configuration.TestOrganizationId, perPage: 10, serials: _serials);

		_ = deviceLatestReadings
			.Should()
			.NotBeNull();
	}
}
