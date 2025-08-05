namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Ssids Firewall Allow List Update Request
/// </summary>
[DataContract]
public class OrganizationsWirelessSsidsFirewallAllowListUpdateRequest
{
	/// <summary>
	/// The description of mac address
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// The client of allowlist
	/// </summary>
	[DataMember(Name = "client")]
	public OrganizationsWirelessSsidsFirewallAllowListCreateRequestClient? Client { get; set; }
}
