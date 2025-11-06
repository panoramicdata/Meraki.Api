using HtmlAgilityPack;
using System.Globalization;
using System.Net;

namespace Meraki.Api;

/// <summary>
/// A Meraki Dashboard API client!
/// </summary>
public partial class MerakiClient
{
	/// <summary>
	/// Returns a list of end-of-life data
	/// Data regularly updated from https://documentation.meraki.com/General_Administration/Other_Topics/Meraki_End-of-Life_(EOL)_Products_and_Dates
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	public static async Task<List<DeviceModelEndOfLifeDetail>> GetEndOfLifeDetailsAsync(CancellationToken cancellationToken = default)
	{
		using var HttpClient = new HttpClient();
		var url = new Uri("https://documentation.meraki.com/General_Administration/Other_Topics/Meraki_End-of-Life_(EOL)_Products_and_Dates");
		var response = await HttpClient.GetAsync(url, cancellationToken);
#if NETSTANDARD2_0
		var html = await response
			.Content
			.ReadAsStringAsync()
			?? throw new InvalidDataException("Could not read response content");
#else
		var html = await response
			.Content
			.ReadAsStringAsync(cancellationToken)
			?? throw new InvalidDataException("Could not read response content");
#endif

		// Use HtmlAgilityPack to parse the HTML
		var htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(html);

		// Find the first tbody node
		var tbody = htmlDocument.DocumentNode
			.Descendants("tbody")
			.FirstOrDefault();

		var endOfLifeDetails = new List<DeviceModelEndOfLifeDetail>();
		foreach (var tr in tbody?.Descendants("tr") ?? [])
		{
			var tds = tr
				.Descendants("td")
				.ToList();

			// Are there four cells?
			if (tds.Count != 4)
			{
				// No. Skip this row
				continue;
			}
			// Yes.

			// Determine the deviceModel and region (if any)
			var firstCellInnerText = WebUtility.HtmlDecode(tds[0].InnerText);
			var parts = firstCellInnerText.Split(' ');
			var deviceModel = parts[0];
			var region = parts.Length > 1
				? parts[1]
					.Replace("(", string.Empty)
					.Replace(")", string.Empty)
				: null;

			// Get the notice URL
			var eosNoticeUrl = tds[0]
				.Descendants("a")
				.FirstOrDefault()?
				.Attributes["href"]?
				.Value
				?? "Missing URL";

			var endOfLifeDetail = new DeviceModelEndOfLifeDetail
			{
				DeviceModel = deviceModel,
				Region = region,
				EosNoticeUrl = eosNoticeUrl,
				Announcement = TryGetDate(tds[1], out var value) ? value : null,
				EndOfSale = TryGetDate(tds[2], out value) ? value : null,
				EndOfSupport = TryGetDate(tds[3], out value) ? value : null,
			};
			endOfLifeDetails.Add(endOfLifeDetail);
		}

		return endOfLifeDetails;
	}

	/// <summary>
	/// Tries to get the date from the text.
	/// Note that the text is written by humans and varies in quality.
	/// For this reason, we don't stop parsing if we encounter an error.
	/// Instead, we just return null.
	/// </summary>
	/// <param name="htmlNode"></param>
	/// <param name="dateTimeOffset"></param>
	/// <returns>True if successfully parsed, otherwise false.</returns>
	private static bool TryGetDate(HtmlNode htmlNode, out DateTimeOffset dateTimeOffset)
	{
		// Initialize the out parameter
		dateTimeOffset = default;

		// Decode the HTML
		var text = WebUtility.HtmlDecode(htmlNode.InnerText);
		if (DateTime.TryParseExact(
			text,
			[
				"MMM d, yyyy",
				"MMM dd, yyyy",
				"MMMM d, yyyy",
				"MMMM dd, yyyy",
				"MMMdd, yyyy",
			],
			CultureInfo.InvariantCulture,
			DateTimeStyles.None,
			out var dateTime))
		{
			dateTimeOffset = new DateTimeOffset(dateTime, TimeSpan.Zero);
			return true;
		}

		return false;
	}
}
