namespace Meraki.Api.Data;

/// <summary>
/// Guest VLAN settings. Used to direct traffic to a guest VLAN when none of the RADIUS servers are reachable or a client receives access-reject from the RADIUS server.
/// </summary>
[DataContract]
public class SsidNamedVlansRadiusGuestVlan
{
	/// <summary>
	/// RADIUS guest VLAN name.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Whether or not RADIUS guest named VLAN is enabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
