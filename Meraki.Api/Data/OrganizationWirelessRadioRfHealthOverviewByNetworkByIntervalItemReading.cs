namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Radio Rf Health Overview By Network By Interval Item Reading
/// </summary>
[DataContract]
public class OrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalItemReading
{
	/// <summary>
	/// The start time of the interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// The end time of the interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// RF health metrics for this interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "healthMetrics")]
	public OrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalItemReadingHealthMetrics HealthMetrics { get; set; } = new();
}
