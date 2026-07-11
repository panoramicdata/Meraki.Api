namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Radio Rf Health Overview By Network By Interval Item Reading Health Metrics
/// </summary>
[DataContract]
public class OrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalItemReadingHealthMetrics
{
	/// <summary>
	/// RF health metrics broken down by band. One entry per band present (e.g. 2.4, 5, 6).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byBand")]
	public List<OrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalItemReadingHealthMetricsByBandItem> ByBand { get; set; } = [];
}
