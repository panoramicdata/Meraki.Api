using HtmlAgilityPack;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;

namespace Meraki.Api;

/// <summary>
/// A Meraki Dashboard API client!
/// </summary>
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
#if NETSTANDARD2_0
		var html = await response
			.Content
			.ReadAsStringAsync()
			.ConfigureAwait(false)
			?? throw new InvalidDataException("Could not read response content");
#else
		var html = await response
			.Content
			.ReadAsStringAsync(cancellationToken)
			.ConfigureAwait(false)
			?? throw new InvalidDataException("Could not read response content");
#endif

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

		var endOfLifeDetails = new List<DeviceModelEndOfLifeDetail>();
		foreach (var tr in tbody?.Descendants("tr") ?? [])
		{
			var tds = tr
				.Descendants("td")
				.ToList();

			// Data rows have four cells. The header row uses <th> (so produces no <td>)
			// and any layout rows with a different cell count are skipped.
			if (tds.Count != 4)
			{
				continue;
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
			if (productDescription.Length == 0)
			{
				continue;
			}

			endOfLifeDetails.Add(new DeviceModelEndOfLifeDetail
			{
				DeviceModel = productDescription,
				Models = ParseModels(productDescription),
				Regions = ParseRegions(productDescription),
				Region = null,
				EosNoticeUrl = WebUtility.HtmlDecode(eosNoticeUrl),
				Announcement = TryGetDate(tds[1], out var value) ? value : null,
				EndOfSale = TryGetDate(tds[2], out value) ? value : null,
				EndOfSupport = TryGetDate(tds[3], out value) ? value : null,
			});
		}

		return endOfLifeDetails;
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

	/// <summary>
	/// Parses the individual model identifiers from a product description on a best-effort
	/// basis. Parenthetical qualifiers are dropped, the separators ',', '&amp;' and 'and'
	/// are honoured, the "-HW" suffix is removed, and only model-shaped tokens (those
	/// containing a digit) are returned.
	/// </summary>
	private static List<string> ParseModels(string productDescription)
	{
		var models = new List<string>();

		// License SKU shorthand with a parenthesised duration list, e.g.
		// "LIC-MI-XS (1D, 1YR, 3YR, 5YR, 7YR, 10YR)" -> LIC-MI-XS-1D, LIC-MI-XS-1YR, ...
		var licenseMatch = _licenseSuffixListRegex.Match(productDescription);
		if (licenseMatch.Success)
		{
			var stem = licenseMatch.Groups["base"].Value.Trim();
			var suffixes = licenseMatch.Groups["list"].Value
				.Split(',')
				.Select(suffix => suffix.Trim())
				.ToList();

			if (stem.StartsWith("LIC", StringComparison.OrdinalIgnoreCase)
				&& suffixes.Count > 0
				&& suffixes.TrueForAll(_durationSuffixRegex.IsMatch))
			{
				foreach (var suffix in suffixes)
				{
					AddModel(models, stem + "-" + suffix);
				}

				return models;
			}
		}

		// Drop any parenthetical qualifier (now known not to be a duration list), e.g.
		// "(For MR42E, MR53E, MR46E)" or "(UK)".
		var text = productDescription.Split('(')[0];

		// Normalise the common joining words to comma separators.
		text = text.Replace(" & ", ", ");
		text = Regex.Replace(text, @"\s+and\s+", ", ", RegexOptions.IgnoreCase);

		// The stem of the most recent license SKU, so bare-suffix continuations can inherit
		// it, e.g. "LIC-MT-3Y, 5Y, 7Y, 10Y" -> LIC-MT-3Y, LIC-MT-5Y, LIC-MT-7Y, LIC-MT-10Y.
		string? licenseStem = null;

		foreach (var part in text.Split(','))
		{
			// Take the leading token; descriptive words (e.g. "Series", "Antennas") follow
			// the model identifier after a space. The "-HW" hardware suffix is preserved
			// because it is part of the published model number.
			var candidate = part.Trim().Split(' ')[0].Trim().Trim(',').Trim();

			// A bare duration suffix continues the previous license SKU.
			if (licenseStem is not null && _durationSuffixRegex.IsMatch(candidate))
			{
				AddModel(models, licenseStem + candidate);
				continue;
			}

			// A model identifier contains at least one digit and matches a model-like shape.
			if (candidate.Length < 2
				|| !Regex.IsMatch(candidate, @"\d")
				|| !_modelLikeRegex.IsMatch(candidate))
			{
				continue;
			}

			AddModel(models, candidate);

			// If this is a license SKU ending in a duration, remember its stem so any
			// following bare-suffix continuations can inherit it.
			licenseStem = candidate.StartsWith("LIC", StringComparison.OrdinalIgnoreCase)
				&& _trailingDurationRegex.IsMatch(candidate)
				? _trailingDurationRegex.Replace(candidate, string.Empty)
				: null;
		}

		return models;
	}

	private static void AddModel(List<string> models, string model)
	{
		if (!models.Contains(model))
		{
			models.Add(model);
		}
	}

	/// <summary>
	/// Parses the geographic region codes a row applies to, on a best-effort basis, from
	/// either a parenthetical list (e.g. "GS110-8P (UK)" or "MA-INJ-4-XX (AU, CN, EU, UK,
	/// US)") or a model SKU suffix (e.g. "GX50-HW-US"). Only known region codes are returned.
	/// </summary>
	private static List<string> ParseRegions(string productDescription)
	{
		var regions = new List<string>();

		// Region codes inside parentheses, e.g. "(UK)" or "(AU, CN, EU, UK, US)".
		foreach (Match paren in _parentheticalRegex.Matches(productDescription))
		{
			foreach (var item in paren.Groups[1].Value.Split(','))
			{
				AddRegionIfKnown(regions, item.Trim());
			}
		}

		// Region code as a trailing SKU segment, e.g. "GX50-HW-US" or "MG21-HW-WW".
		foreach (var token in Regex.Split(productDescription, @"[\s,]+"))
		{
			var match = _trailingRegionRegex.Match(token);
			if (match.Success)
			{
				AddRegionIfKnown(regions, match.Groups["region"].Value);
			}
		}

		return regions;
	}

	private static void AddRegionIfKnown(List<string> regions, string candidate)
	{
		if (!_regionCodes.Contains(candidate))
		{
			return;
		}

		var normalised = candidate.ToUpperInvariant();
		if (!regions.Contains(normalised))
		{
			regions.Add(normalised);
		}
	}

	/// <summary>
	/// Tries to get the date from the cell text.
	/// The text is written by humans and varies in quality (abbreviated or full month
	/// names, with or without a leading zero, and sometimes without a comma), so a range
	/// of formats is accepted. Returns false (null date) rather than throwing on failure.
	/// </summary>
	/// <param name="htmlNode">The cell node.</param>
	/// <param name="dateTimeOffset">The parsed date, at UTC offset zero.</param>
	/// <returns>True if successfully parsed, otherwise false.</returns>
	private static bool TryGetDate(HtmlNode htmlNode, out DateTimeOffset dateTimeOffset)
	{
		// Initialize the out parameter
		dateTimeOffset = default;

		// Decode the HTML
		var text = WebUtility.HtmlDecode(htmlNode.InnerText);
		if (string.IsNullOrWhiteSpace(text))
		{
			return false;
		}

		// Drop any parenthetical footnote, then collapse whitespace.
		text = text.Split('(')[0];
		text = Regex.Replace(text, @"\s+", " ").Trim();

		if (DateTime.TryParseExact(
				text,
				_dateFormats,
				CultureInfo.InvariantCulture,
				DateTimeStyles.None,
				out var dateTime)
			|| DateTime.TryParse(
				text,
				CultureInfo.InvariantCulture,
				DateTimeStyles.None,
				out dateTime))
		{
			dateTimeOffset = new DateTimeOffset(dateTime, TimeSpan.Zero);
			return true;
		}

		return false;
	}
}
