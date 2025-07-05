namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller redundancy status
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyStatusesItem
{
	/// <summary>
	/// Wireless LAN controller redundancy mobility mac
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mobilityMac")]
	public string MobilityMac { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller redundancy SSO (stateful switchover)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string Mode { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller cloud ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller redundancy enablement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Wireless LAN controller failover information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failover")]
	public OrganizationWirelessControllerDevicesRedundancyStatusesItemFailover Failover { get; set; } = new();
}
