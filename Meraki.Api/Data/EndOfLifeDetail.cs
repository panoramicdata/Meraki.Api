namespace Meraki.Api.Data;

/// <summary>
/// End of life details about a device model
/// </summary>
public record DeviceModelEndOfLifeDetail
{
	/// <summary>
	/// The device model
	/// </summary>
	public string DeviceModel { get; internal set; } = string.Empty;

	/// <summary>
	/// If null, all regions apply
	/// </summary>
	public string? Region { get; internal set; }

	/// <summary>
	/// The announcement date
	/// </summary>
	public DateTimeOffset? Announcement { get; internal set; }

	/// <summary>
	/// The end of sale date
	/// </summary>
	public DateTimeOffset? EndOfSale { get; internal set; }

	/// <summary>
	/// The end of support date
	/// </summary>
	public DateTimeOffset? EndOfSupport { get; internal set; }

	/// <summary>
	/// The end of support date for Meraki cloud management
	/// </summary>
	public string EosNoticeUrl { get; internal set; } = string.Empty;
}
