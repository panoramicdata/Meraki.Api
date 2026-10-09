namespace Meraki.Api.Data;

/// <summary>
/// Source of a custom VPN exclusion rule. Not in the Meraki OpenAPI spec; shape taken from the live API.
/// </summary>
[DataContract]
public class TrafficShapingVpnExclusionsCustomSource
{
	/// <summary>
	/// Source VLAN ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanId")]
	public string? VlanId { get; set; }

	/// <summary>
	/// Source port
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "port")]
	public string? Port { get; set; }
}
