namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Radio Rf Health Overview By Network By Interval
/// </summary>
[DataContract]
public class OrganizationWirelessRadioRfHealthOverviewByNetworkByInterval
{
	/// <summary>
	/// RF health metrics, by network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalItem> Items { get; set; } = [];
}
