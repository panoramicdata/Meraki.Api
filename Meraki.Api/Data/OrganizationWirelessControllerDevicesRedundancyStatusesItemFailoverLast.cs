namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller last failover information
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyStatusesItemFailoverLast
{
	/// <summary>
	/// Wireless LAN controller last redundancy switchover reason
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reason")]
	public string Reason { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller last redundancy switchover time
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;
}