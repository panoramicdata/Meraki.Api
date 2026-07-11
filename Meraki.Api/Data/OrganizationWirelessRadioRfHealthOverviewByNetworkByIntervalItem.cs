namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Radio Rf Health Overview By Network By Interval Item
/// </summary>
[DataContract]
public class OrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalItem
{
	/// <summary>
	/// Network for the given RF health metrics.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalItemNetwork Network { get; set; } = new();

	/// <summary>
	/// RF health readings over the requested timespan, one per interval bucket.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "readings")]
	public List<OrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalItemReading> Readings { get; set; } = [];
}
