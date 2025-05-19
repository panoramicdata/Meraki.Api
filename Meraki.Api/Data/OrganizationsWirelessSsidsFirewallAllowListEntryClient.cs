namespace Meraki.Api.Data;

/// <summary>
/// The client of allowlist
/// </summary>
[DataContract]
public class OrganizationsWirelessSsidsFirewallAllowListEntryClient
{
	/// <summary>
	/// L2 Isolation mac address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;
}