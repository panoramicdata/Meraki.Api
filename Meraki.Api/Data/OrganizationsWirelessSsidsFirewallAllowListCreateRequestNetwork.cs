namespace Meraki.Api.Data;

/// <summary>
/// The Network that allowlist belongs to
/// </summary>
[DataContract]
public class OrganizationsWirelessSsidsFirewallAllowListCreateRequestNetwork
{
	/// <summary>
	/// The ID of network
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}