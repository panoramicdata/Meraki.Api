namespace Meraki.Api.Data;

/// <summary>
/// Custom VPN exclusion rules. Pass an empty array to clear existing rules.
/// </summary>
[DataContract]
public class TrafficShapingVpnExclusionsCustom
{
	/// <summary>
	/// Destination address; hostname required for DNS, IPv4 otherwise.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destination")]
	public string? Destination { get; set; }

	/// <summary>
	/// Destination port.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "port")]
	public string? Port { get; set; }

	/// <summary>
	/// Protocol. Valid values are 'any', 'dns', 'icmp', 'tcp', 'udp'
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "protocol")]
	public TrafficShapingVpnExclusionsCustomProtocol? Protocol { get; set; }

	/// <summary>
	/// Source for the VPN exclusion rule (an object, e.g. a VLAN and port, not a string)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "source")]
	public TrafficShapingVpnExclusionsCustomSource? Source { get; set; }
}
