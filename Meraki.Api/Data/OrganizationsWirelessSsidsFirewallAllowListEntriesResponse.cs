namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Ssids Firewall Allow List Entries Response
/// </summary>
[DataContract]
public class OrganizationsWirelessSsidsFirewallAllowListEntriesResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationsWirelessSsidsFirewallAllowListEntriesResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// L2 isolation allowlist items
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationsWirelessSsidsFirewallAllowListEntry> Items { get; set; } = [];
}
