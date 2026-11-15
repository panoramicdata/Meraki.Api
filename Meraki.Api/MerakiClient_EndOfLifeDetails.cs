using HtmlAgilityPack;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;

namespace Meraki.Api;

/// <summary>
/// A Meraki Dashboard API client!
/// </summary>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class MerakiClient
{
	private const string EndOfLifeUrl = "https://documentation.meraki.com/General_Administration/Other_Topics/Meraki_End-of-Life_(EOL)_Products_and_Dates";

	private static readonly string[] _dateFormats =
	[
		"MMM d, yyyy", "MMM dd, yyyy",
		"MMMM d, yyyy", "MMMM dd, yyyy",
		"MMM d yyyy", "MMM dd yyyy",
		"MMMM d yyyy", "MMMM dd yyyy",
	];

	// A model identifier starts with a letter, contains at least one digit (checked
	// separately) and is made up of alphanumeric groups joined by '-', '/' or '.'.
	private static readonly Regex _modelLikeRegex = new(
		@"^[A-Za-z][A-Za-z0-9]*(?:[-/.][A-Za-z0-9]+)*$",
		RegexOptions.Compiled);

	// Matches a license SKU shorthand with a parenthesised duration list, e.g.
	// "LIC-MI-XS (1D, 1YR, 3YR, 5YR, 7YR, 10YR)". Group "base" is the SKU stem and
	// group "list" is the comma-separated duration suffixes.
	private static readonly Regex _licenseSuffixListRegex = new(
		@"^(?<base>[A-Za-z][A-Za-z0-9/-]*)\s*\((?<list>[^)]*)\)",
		RegexOptions.Compiled);

	// Matches a bare duration suffix used by license SKUs, e.g. "1D", "3Y", "10YR".
	private static readonly Regex _durationSuffixRegex = new(
		@"^\d+(?:YR|MO|D|W|Y|M)$",
		RegexOptions.Compiled | RegexOptions.IgnoreCase);

	// Matches a trailing duration on a full license SKU so its stem can be reused,
	// e.g. "LIC-MT-3Y" -> stem "LIC-MT-".
	private static readonly Regex _trailingDurationRegex = new(
		@"\d+(?:YR|MO|D|W|Y|M)$",
		RegexOptions.Compiled | RegexOptions.IgnoreCase);

	// Region codes observed on the Meraki EOL page (US/UK/EU regional, NA North America,
	// WW worldwide, AU Australia, CN China). Add new codes here if the page introduces them.
	private static readonly HashSet<string> _regionCodes = new(StringComparer.OrdinalIgnoreCase)
	{
		"US", "UK", "EU", "NA", "WW", "AU", "CN",
	};

	// Matches the contents of each parenthetical group, e.g. "(AU, CN, EU)".
	private static readonly Regex _parentheticalRegex = new(
		@"\(([^)]*)\)",
		RegexOptions.Compiled);

	// Matches a trailing region segment on a SKU, e.g. "GX50-HW-US" -> "US".
	private static readonly Regex _trailingRegionRegex = new(
		@"-(?<region>[A-Za-z]{2,3})$",
		RegexOptions.Compiled);

	/// <summary>
	/// Returns a list of end-of-life data.
	/// Data regularly updated from https://documentation.meraki.com/General_Administration/Other_Topics/Meraki_End-of-Life_(EOL)_Products_and_Dates
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	public static async Task<List<DeviceModelEndOfLifeDetail>> GetEndOfLifeDetailsAsync(CancellationToken cancellationToken = default)
	{
		using var httpClient = new HttpClient();
		var url = new Uri(EndOfLifeUrl);
		var response = await httpClient.GetAsync(url, cancellationToken).ConfigureAwait(false);
		var html = await response
			.Content
			.ReadAsStringAsync(cancellationToken)
			.ConfigureAwait(false)
			?? throw new InvalidDataException("Could not read response content");

		return ParseEndOfLifeDetails(html);
	}

	/// <summary>
	/// Parses the Meraki End-of-Life products table from the supplied HTML.
	/// This is separated from the HTTP fetch so it can be unit tested deterministically.
	/// </summary>
	/// <param name="html">The HTML of the Meraki EOL page (or a fragment containing the table).</param>
	internal static List<DeviceModelEndOfLifeDetail> ParseEndOfLifeDetails(string html)
	{
		// Use HtmlAgilityPack to parse the HTML
		var htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(html);

		// Find the first tbody node
		var tbody = htmlDocument.DocumentNode
			.Descendants("tbody")
			.FirstOrDefault();

		return [.. (tbody?.Descendants("tr") ?? [])
			.Select(ParseEndOfLifeRow)
			.OfType<DeviceModelEndOfLifeDetail>()];
	}

	/// <summary>
	/// Projects one table row, returning null where the row is not a data row or carries no
	/// product description.
	/// </summary>
	private static DeviceModelEndOfLifeDetail? ParseEndOfLifeRow(HtmlNode tr)
	{
		var tds = tr
			.Descendants("td")
			.ToList();

		// Data rows have four cells. The header row uses <th> (so produces no <td>)
		// and any layout rows with a different cell count are skipped.
		if (tds.Count != 4)
		{
			return null;
		}

		var productCell = tds[0];

		// The notice URL is the first hyperlink in the product cell, if any.
		var eosNoticeUrl = productCell
			.Descendants("a")
			.Select(a => a.GetAttributeValue("href", string.Empty))
			.FirstOrDefault(href => !string.IsNullOrWhiteSpace(href))
			?? "Missing URL";

		// The product description as published (may list several models / accessories).
		var productDescription = GetCellText(productCell);

		return productDescription.Length == 0
			? null
			: new DeviceModelEndOfLifeDetail
			{
				DeviceModel = productDescription,
				Models = ParseModels(productDescription),
				Regions = ParseRegions(productDescription),
				Region = null,
				EosNoticeUrl = WebUtility.HtmlDecode(eosNoticeUrl),
				Announcement = TryGetDate(tds[1], out var value) ? value : null,
				EndOfSale = TryGetDate(tds[2], out value) ? value : null,
				EndOfSupport = TryGetDate(tds[3], out value) ? value : null,
			};
	}

	/// <summary>
	/// Extracts the visible text of a table cell, treating &lt;br&gt; as a separator,
	/// decoding HTML entities and collapsing whitespace and repeated commas.
	/// </summary>
	private static string GetCellText(HtmlNode node)
	{
		var inner = node.InnerHtml;

		// Line breaks separate distinct models, so turn them into comma separators.
		inner = Regex.Replace(inner, @"<br\s*/?>", ", ", RegexOptions.IgnoreCase);

		// Remove all remaining markup. Inline tags are removed WITHOUT inserting a space so
		// that a single model split across adjacent tags is rejoined as published. Meraki
		// sometimes does this, e.g. "<a>MR70</a><a>-HW</a>" must become "MR70-HW", not "MR70 -HW".
		inner = Regex.Replace(inner, "<[^>]+>", string.Empty);

		var text = WebUtility.HtmlDecode(inner);

		// Collapse whitespace, then collapse runs of commas / spaces into a single ", ".
		text = Regex.Replace(text, @"\s+", " ").Trim();
		text = Regex.Replace(text, @"\s*(?:,\s*)+", ", ");

		// Tidy artefacts created by treating <br> as a comma separator: a comma directly
		// before "(", or directly after "and" / "&", is never intended in the product text.
		text = Regex.Replace(text, @",\s*\(", " (");
		text = Regex.Replace(text, @" (and|&)\s*,", " $1");

		return text.Trim().Trim(',').Trim();
	}
}
