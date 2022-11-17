namespace Meraki.Api.Data;

/// <summary>
/// Vlanm IPV6 Prefix Assignment Origin
/// </summary>
[DataContract]
public class VlanIpv6PrefixAssignmentOrigin
{
	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Static Prefix
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "interfaces")]
	public List<string>? Interfaces { get; set; }
}