namespace Meraki.Api.Data;

/// <summary>
/// End of life details for a single row of the Meraki End-of-Life (EOL) products table.
/// A single published row frequently covers several device models and/or accessories, so
/// <see cref="DeviceModel"/> holds the full product description exactly as published and
/// <see cref="Models"/> holds the individual model identifiers parsed from it.
/// </summary>
public record DeviceModelEndOfLifeDetail
{
	/// <summary>
	/// The product description exactly as published in the EOL table. This may list several
	/// models and/or accessories (e.g. "MR36, MR36H, MR44, MR46, MR46E and Accessories").
	/// </summary>
	public string DeviceModel { get; internal set; } = string.Empty;

	/// <summary>
	/// The individual Meraki model identifiers parsed from <see cref="DeviceModel"/> on a
	/// best-effort basis, kept exactly as published (including the "-HW" hardware suffix).
	/// Descriptive / accessory text is excluded. Empty when the row contains no recognisable
	/// model identifiers.
	/// <para>
	/// Note: the Meraki Dashboard API device model omits the "-HW" suffix (e.g. "MR70"
	/// rather than "MR70-HW"), so when relating these to a device, match case-insensitively
	/// and allow a trailing "-HW".
	/// </para>
	/// </summary>
	public IReadOnlyList<string> Models { get; internal set; } = [];

	/// <summary>
	/// The geographic region codes the row applies to (e.g. "US", "UK", "EU", "NA", "WW"),
	/// parsed on a best-effort basis from either a parenthetical list (e.g. "GS110-8P (UK)"
	/// or "MA-INJ-4-XX (AU, CN, EU, UK, US)") or a model SKU suffix (e.g. "GX50-HW-US").
	/// Empty when the row is not region-specific.
	/// </summary>
	public IReadOnlyList<string> Regions { get; internal set; } = [];

	/// <summary>
	/// Legacy single-region field. The current EOL page no longer publishes a separate
	/// region column, so this is no longer populated (null). Use <see cref="Regions"/>
	/// instead, which also represents rows that apply to several regions. Retained for
	/// backwards compatibility.
	/// </summary>
	public string? Region { get; internal set; }

	/// <summary>
	/// The announcement date, or null when not published or not parseable.
	/// </summary>
	public DateTimeOffset? Announcement { get; internal set; }

	/// <summary>
	/// The end of sale date, or null when not published or not parseable.
	/// </summary>
	public DateTimeOffset? EndOfSale { get; internal set; }

	/// <summary>
	/// The end of support date, or null when not published or not parseable.
	/// </summary>
	public DateTimeOffset? EndOfSupport { get; internal set; }

	/// <summary>
	/// The URL to the official End-of-Sale / End-of-Life notice, or "Missing URL" when absent.
	/// </summary>
	public string EosNoticeUrl { get; internal set; } = string.Empty;
}
