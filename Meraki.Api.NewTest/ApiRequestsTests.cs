using FluentAssertions;
using Meraki.Api.Extensions;
using System.Diagnostics;
using System.Globalization;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;
[Collection("API Collection")]
public class ApiRequestsTests : MerakiClientUnitTest
{
	private static readonly System.Text.Json.JsonSerializerOptions _jsonOptions = new() { WriteIndented = true };

	public ApiRequestsTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetApiRequests_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var startTimeStamp = DateTime.Parse("2024-07-22 00:00:00Z", CultureInfo.InvariantCulture);
		var endTimeStamp = startTimeStamp.AddDays(1);
		var apiRequests = await TestMerakiClient
			.Organizations
			.ApiRequests
			.GetOrganizationApiRequestsAllAsync(
				"213309",
				t0: startTimeStamp.Date.ToString("yyyy-MM-dd 00:00:00Z", CultureInfo.InvariantCulture),
				t1: endTimeStamp.Date.ToString("yyyy-MM-dd 00:00:00Z", CultureInfo.InvariantCulture)
				);
		_ = apiRequests.Should().NotBeEmpty();
		var json = System.Text.Json.JsonSerializer.Serialize(apiRequests, _jsonOptions);
		// write the json to a file
		var tempFile = Path.GetTempFileName();
		await File.WriteAllTextAsync(tempFile, json);
		Debug.WriteLine($"Json written to {tempFile}");
		_ = json.Should().NotBeNullOrEmpty();
	}
}
