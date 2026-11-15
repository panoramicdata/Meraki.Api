using HtmlAgilityPack;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;

namespace Meraki.Api;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public partial class MerakiClient
{
	/// <summary>
	/// Parses the individual model identifiers from a product description on a best-effort
	/// basis. Parenthetical qualifiers are dropped, the separators ',', '&amp;' and 'and'
	/// are honoured, the "-HW" suffix is removed, and only model-shaped tokens (those
	/// containing a digit) are returned.
	/// </summary>
	private static List<string> ParseModels(string productDescription)
	{
		var expandedLicenseSkus = TryExpandLicenseSkuList(productDescription);
		if (expandedLicenseSkus is not null)
		{
			return expandedLicenseSkus;
		}

		var models = new List<string>();

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

			if (!IsModelLike(candidate))
			{
				continue;
			}

			AddModel(models, candidate);
			licenseStem = GetLicenseStem(candidate);
		}

		return models;
	}

	/// <summary>
	/// Expands the license SKU shorthand with a parenthesised duration list, e.g.
	/// "LIC-MI-XS (1D, 1YR, 3YR, 5YR, 7YR, 10YR)" to LIC-MI-XS-1D, LIC-MI-XS-1YR and so on.
	/// Returns null where the description is not in that form.
	/// </summary>
	private static List<string>? TryExpandLicenseSkuList(string productDescription)
	{
		var licenseMatch = _licenseSuffixListRegex.Match(productDescription);
		if (!licenseMatch.Success)
		{
			return null;
		}

		var stem = licenseMatch.Groups["base"].Value.Trim();
		var suffixes = licenseMatch.Groups["list"].Value
			.Split(',')
			.Select(suffix => suffix.Trim())
			.ToList();

		if (!stem.StartsWith("LIC", StringComparison.OrdinalIgnoreCase)
			|| suffixes.Count == 0
			|| !suffixes.TrueForAll(_durationSuffixRegex.IsMatch))
		{
			return null;
		}

		var models = new List<string>();
		foreach (var suffix in suffixes)
		{
			AddModel(models, stem + "-" + suffix);
		}

		return models;
	}

	/// <summary>
	/// A model identifier contains at least one digit and matches a model-like shape.
	/// </summary>
	private static bool IsModelLike(string candidate)
		=> candidate.Length >= 2
			&& Regex.IsMatch(candidate, @"\d")
			&& _modelLikeRegex.IsMatch(candidate);

	/// <summary>
	/// Where the candidate is a license SKU ending in a duration, returns its stem so that any
	/// following bare-suffix continuations can inherit it. Otherwise returns null.
	/// </summary>
	private static string? GetLicenseStem(string candidate)
		=> candidate.StartsWith("LIC", StringComparison.OrdinalIgnoreCase)
			&& _trailingDurationRegex.IsMatch(candidate)
			? _trailingDurationRegex.Replace(candidate, string.Empty)
			: null;

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
