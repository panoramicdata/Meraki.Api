namespace Meraki.Api.Data;

/// <summary>
/// IPV6 Prefix Assignment
/// </summary>
[DataContract]
public class VlanIpv6PrefixAssignment
{
	/// <summary>
	/// Autonomous
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "autonomous")]
	public bool? Autonomous { get; set; }

	/// <summary>
	/// Static Prefix
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "staticPrefix")]
	public string? StaticPrefix { get; set; }

	/// <summary>
	/// Static Appliance Ip6
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "staticApplianceIp6")]
	public string? StaticApplianceIp6 { get; set; }

	/// <summary>
	/// Origin
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "origin")]
	public VlanIpv6PrefixAssignmentOrigin? Origin { get; set; }
}
