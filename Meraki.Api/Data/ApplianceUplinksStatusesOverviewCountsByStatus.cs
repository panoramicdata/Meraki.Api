namespace Meraki.Api.Data;

/// <summary>
/// Appliance Uplinks Statuses Overview Counts By Status
/// </summary>
[DataContract]
public class ApplianceUplinksStatusesOverviewCountsByStatus
{
	/// <summary>
	/// Active - number of uplinks that are active and working
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "active")]
	public int Active { get; set; }

	/// <summary>
	/// Connecting - number of uplinks currently connecting
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "connecting")]
	public int Connecting { get; set; }

	/// <summary>
	/// Failed - number of uplinks that were working but have failed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failed")]
	public int Failed { get; set; }

	/// <summary>
	/// Not Connected - number of uplinks currently where nothing is plugged in
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "notConnected")]
	public int NotConnected { get; set; }

	/// <summary>
	/// Ready - number of uplinks that are working but on standby
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ready")]
	public int Ready { get; set; }
}
