namespace Meraki.Api.Test.Organizations.ApiRequests;

public class ApiRequestsTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	// Note: The original test was commented out, so leaving it commented here as well
	
	//[Fact]
	//public async Task GetApiRequests_Succeeds()
	//{
	//	TestMerakiClient.Statistics.Reset();
	//	var startTimeStamp = DateTime.Parse("2024-07-08 00:00:00Z", CultureInfo.InvariantCulture);
	//	for (var i = 0; i < 14; i++)
	//	{
	//		startTimeStamp = startTimeStamp.AddDays(i);
	//		var endTimeStamp = startTimeStamp.AddDays(1);
	//		var apiRequests = await TestMerakiClient
	//			.Organizations
	//			.ApiRequests
	//			.GetOrganizationApiRequestsAllAsync(
	//				Configuration.TestOrganizationId,
	//				t0: startTimeStamp.Date.ToString("yyyy-MM-dd 00:00:00Z", CultureInfo.InvariantCulture),
	//				t1: endTimeStamp.Date.ToString("yyyy-MM-dd 00:00:00Z", CultureInfo.InvariantCulture)
	//				);
	//		var json = System.Text.Json.JsonSerializer.Serialize(apiRequests, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
	//		// write the json to a file
	//		var outFile = Path.Combine(Path.GetTempPath(), $"apiRequests_{startTimeStamp:yyyyMMdd}.json");
	//		await File.WriteAllTextAsync(outFile, json);
	//		Debug.WriteLine($"Json written to {outFile}");
	//	}
	//}
}
