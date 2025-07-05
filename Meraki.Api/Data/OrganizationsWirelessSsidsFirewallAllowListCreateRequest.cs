namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Ssids Firewall Allow List Create Request
/// </summary>
[DataContract]
public class OrganizationsWirelessSsidsFirewallAllowListCreateRequest
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
	public OrganizationsWirelessSsidsFirewallAllowListCreateRequestClient Client { get; set; } = new();

	/// <summary>
	/// The Network that allowlist belongs to
	/// </summary>
	[DataMember(Name = "network")]
	public OrganizationsWirelessSsidsFirewallAllowListCreateRequestNetwork Network { get; set; } = new();

	/// <summary>
	/// The SSID that allowlist belongs to
	/// </summary>
	[DataMember(Name = "ssid")]
	public OrganizationsWirelessSsidsFirewallAllowListCreateRequestSsid Ssid { get; set; } = new();
}
