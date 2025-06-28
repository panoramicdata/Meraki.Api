namespace Meraki.Api.Data;

/// <summary>
/// Result item
/// </summary>
[DataContract]
public class DeviceLiveToolsDhcpLeaseGetResponseDhcpLease
{
	/// <summary>
	/// Time of the last update of the DHCP lease
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expiresAt")]
	public string ExpiresAt { get; set; } = string.Empty;

	/// <summary>
	/// The IP address of the DHCP lease
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// The MAC address of the DHCP lease
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;
}