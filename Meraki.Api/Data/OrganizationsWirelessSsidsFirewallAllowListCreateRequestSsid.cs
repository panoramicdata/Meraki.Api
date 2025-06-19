namespace Meraki.Api.Data;

/// <summary>
/// The SSID that allowlist belongs to
/// </summary>
[DataContract]
public class OrganizationsWirelessSsidsFirewallAllowListCreateRequestSsid
{
	/// <summary>
	/// The number of SSID
	/// </summary>
	[DataMember(Name = "number")]
	public int Number { get; set; }
}