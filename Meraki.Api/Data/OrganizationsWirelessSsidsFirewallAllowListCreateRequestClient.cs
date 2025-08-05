namespace Meraki.Api.Data;

/// <summary>
/// The client of allowlist
/// </summary>
[DataContract]
public class OrganizationsWirelessSsidsFirewallAllowListCreateRequestClient
{
	/// <summary>
	/// L2 Isolation mac address
	/// </summary>
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }
}