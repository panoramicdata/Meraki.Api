namespace Meraki.Api.Data;

/// <summary>
/// Static Delegated Prefix for a network
/// </summary>
[DataContract]
public class NetworkAppliancePrefixesDelegatedStatic
{
	/// <summary>
	/// Static Delegated Prefix Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "staticDelegatedPrefixId")]
	public string StaticDelegatedPrefixId { get; set; } = string.Empty;

	/// <summary>
	/// IPv6 prefix/prefix length.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "prefix")]
	public string? Prefix { get; set; }

	/// <summary>
	/// WAN1/WAN2/Independent prefix.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "origin")]
	public NetworkAppliancePrefixesDelegatedStaticOrigin? Origin { get; set; }

	/// <summary>
	/// Identifying description for the prefix.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Prefix creation time.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Prefix Updated time.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "updatedAt")]
	public DateTime UpdatedAt { get; set; }
}
