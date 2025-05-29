namespace Meraki.Api.Data;

/// <summary>
/// A reading for a specific port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReading
{
	/// <summary>
	/// Timestamp for the end of the bandwidth usage snapshot, inclusive.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// The product ID for the Small Form Factor Pluggable (SFP) currently inserted into the given port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sfpProductId")]
	public string SfpProductId { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp for the beginning of the bandwidth usage snapshot, exclusive.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier used to associate readings from the Small Form Factor Pluggable (SFP) module to the appropriate set of thresholds
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "thresholdSetId")]
	public string ThresholdSetId { get; set; } = string.Empty;

	/// <summary>
	/// All reading data, grouped by the reading metric
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byMetric")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetric ByMetric { get; set; } = new();
}
