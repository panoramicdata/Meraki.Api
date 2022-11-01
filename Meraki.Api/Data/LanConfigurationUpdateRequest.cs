namespace Meraki.Api.Data;

/// <summary>
/// LAN configuration
/// </summary>
[DataContract]
public class LanConfigurationUpdateRequest
{
	/// <summary>
	/// Subnet
	/// </summary>
	[DataMember(Name = "subnet")]
	public string? Subnet { get; set; }

	/// <summary>
	/// Appliance ip
	/// </summary>
	[DataMember(Name = "applianceIp")]
	public string? ApplianceIp { get; set; }

	/// <summary>
	/// ipv6
	/// </summary>
	[DataMember(Name = "ipv6")]
	public LanConfigurationIpv6? Ipv6 { get; set; }
}
