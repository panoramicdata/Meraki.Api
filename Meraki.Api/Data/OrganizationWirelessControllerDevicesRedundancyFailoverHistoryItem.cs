namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller HA failover event
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyFailoverHistoryItem
{
	/// <summary>
	/// Failover reason
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reason")]
	public string Reason { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller cloud ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Failover time
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Details about the active unit
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "active")]
	public OrganizationWirelessControllerDevicesRedundancyFailoverHistoryItemActive Active { get; set; } = new();

	/// <summary>
	/// Details about the failed unit
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "failed")]
	public OrganizationWirelessControllerDevicesRedundancyFailoverHistoryItemFailed Failed { get; set; } = new();
}
