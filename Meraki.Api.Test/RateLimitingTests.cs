using PanoramicData.SheetMagic;
using System.Diagnostics;

namespace Meraki.Api.Test;

public class RateLimitingTests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetAll_Succeeds()
	{
		var stopwatch = new Stopwatch();
		var timerList = new List<QueryResult>();
		foreach (var __ in Enumerable.Range(0, 10))
		{
			var queryResult = new QueryResult();
			try
			{
				stopwatch.Restart();
				var result = await TestMerakiClient
				.Organizations
				.GetOrganizationAsync(Configuration.TestOrganizationId, CancellationToken);
				_ = result.Should().BeOfType<Organization>();
			}
			catch (ApiException apiException)
			{
				queryResult.StatusCode = apiException.StatusCode;
				queryResult.ExceptionMessage = apiException.Message;
			}
			catch (Exception exception)
			{
				queryResult.ExceptionMessage = exception.Message;
			}
			finally
			{
				queryResult.DurationMs = stopwatch.ElapsedMilliseconds;
				timerList.Add(queryResult);
			}
		}

		var fileInfo = new FileInfo(Path.GetTempFileName() + ".xlsx");
		using var magicSpreadsheet = new MagicSpreadsheet(fileInfo);
		magicSpreadsheet.AddSheet(timerList);
		magicSpreadsheet.Save();
	}
}
