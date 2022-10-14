namespace Meraki.Api.Data;

/// <summary>
/// Static Delegated Prefix for a network
/// </summary>
[DataContract]
public class NetworkAppliancePrefixesDelegatedStaticOrigin
{
	/// <summary>
	/// Origin type
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Uplink provided or independent
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "interfaces")]
	public List<string>? Interfaces { get; set; }
}
