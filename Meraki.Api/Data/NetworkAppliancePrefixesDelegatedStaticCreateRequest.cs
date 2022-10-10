namespace Meraki.Api.Data;

/// <summary>
/// Static Delegated Prefix for a network
/// </summary>
[DataContract]
public class NetworkAppliancePrefixesDelegatedStaticCreateRequest
{
	/// <summary>
	/// IPv6 prefix/prefix length.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "prefix")]
	public string Prefix { get; set; } = string.Empty;

	/// <summary>
	/// WAN1/WAN2/Independent prefix.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "origin")]
	public NetworkAppliancePrefixesDelegatedStaticOrigin? Origin { get; set; }

	/// <summary>
	/// Identifying description for the prefix.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }
}
