namespace Meraki.Api.Data;

/// <summary>
/// L2 isolation allowlist item
/// </summary>
[DataContract]
public class OrganizationsWirelessSsidsFirewallAllowListEntry
{
	/// <summary>
	/// Created at timestamp for the adaptive policy group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// The description of mac address
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The id of entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "entryId")]
	public string EntryId { get; set; } = string.Empty;

	/// <summary>
	/// Updated at timestamp for the adaptive policy group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpdatedAt")]
	public string LastUpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// The client of allowlist
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "client")]
	public OrganizationsWirelessSsidsFirewallAllowListEntryClient Client { get; set; } = new();

	/// <summary>
	/// The network that allowlist SSID belongs to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationsWirelessSsidsFirewallAllowListEntryNetwork Network { get; set; } = new();

	/// <summary>
	/// The SSID that allowlist belongs to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ssid")]
	public OrganizationsWirelessSsidsFirewallAllowListEntrySsid Ssid { get; set; } = new();
}
