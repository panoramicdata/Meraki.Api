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
	/// Source address for the VPN exclusion rule.
	/// Undocumented, observed in responses only and always as null so far.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public string? Source { get; set; }
}
