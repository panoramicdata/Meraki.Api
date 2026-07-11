namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Radio Rf Health Overview By Network By Interval Item Reading Health Metrics By Band Item
/// </summary>
[DataContract]
public class OrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalItemReadingHealthMetricsByBandItem
{
	/// <summary>
	/// The band, e.g. "2.4", "5" or "6".
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "band")]
	public string Band { get; set; } = string.Empty;

	/// <summary>
	/// The RF health score, from 0 to 100.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rfScore")]
	public int RfScore { get; set; }

	/// <summary>
	/// The percentage of time channel utilization due to co-channel interference was classified as high.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "highCciPercentage")]
	public int HighCciPercentage { get; set; }

	/// <summary>
	/// The number of channel changes during this interval.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "channelChanges")]
	public int ChannelChanges { get; set; }
}
