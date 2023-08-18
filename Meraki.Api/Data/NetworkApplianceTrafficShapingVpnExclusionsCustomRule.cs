namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceTrafficShapingVpnExclusionsCustomRule
/// </summary>
[DataContract]
public class NetworkApplianceTrafficShapingVpnExclusionsCustomRule
{
	/// <summary>
	/// Destination address; hostname required for DNS, IPv4 otherwise.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destination")]
	public string Destination { get; set; } = string.Empty;

	/// <summary>
	/// Destination port.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;

	/// <summary>
	/// Protocol. Valid values are 'any', 'dns', 'icmp', 'tcp', 'udp'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;
}
