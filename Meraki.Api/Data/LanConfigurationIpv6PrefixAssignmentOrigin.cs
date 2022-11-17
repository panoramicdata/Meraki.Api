namespace Meraki.Api.Data;

/// <summary>
/// LAN configuration
/// </summary>
[DataContract]
public class LanConfigurationIpv6PrefixAssignmentOrigin
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