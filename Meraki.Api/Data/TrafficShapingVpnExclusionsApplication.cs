namespace Meraki.Api.Data;

/// <summary>
/// Application based VPN exclusion rules.
/// </summary>
[DataContract]
public class TrafficShapingVpnExclusionsApplication
{
	/// <summary>
	/// Application's Meraki ID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Application's name.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Protocol. Valid values are 'any', 'dns', 'icmp', 'tcp', 'udp'.
	/// Undocumented, observed in responses only.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public TrafficShapingVpnExclusionsCustomProtocol? Protocol { get; set; }

	/// <summary>
	/// Source for the VPN exclusion rule; same shape as a custom rule's source (e.g. a VLAN and port).
	/// Undocumented, observed in responses only.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public TrafficShapingVpnExclusionsCustomSource? Source { get; set; }
}
