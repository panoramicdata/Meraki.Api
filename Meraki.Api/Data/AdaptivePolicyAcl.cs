namespace Meraki.Api.Data;

/// <summary>
/// Acl
/// </summary>
[DataContract]
public class AdaptivePolicyAcl : NamedItem
{
	/// <summary>
	/// Acl id
	/// </summary>
	[ApiKey]
	[DataMember(Name = "aclId")]
	public string? AclId { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Ip version
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ipVersion")]
	public string? IpVersion { get; set; }

	/// <summary>
	/// Rules
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "rules")]
	public List<AdaptivePolicyAclRules>? Rules { get; set; }

	/// <summary>
	/// Created at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// Updated at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public DateTime? UpdatedAt { get; set; }
}
