namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganizationSamlRole
/// </summary>
[DataContract]
public class SamlRole : IdentifiedItem
{
	/// <summary>
	/// The role of the SAML administrator
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "role")]
	public string Role { get; set; } = string.Empty;

	/// <summary>
	/// The privilege of the SAML administrator on the organization
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "orgAccess")]
	public string OrgAccess { get; set; } = string.Empty;

	/// <summary>
	/// The list of tags that the SAML administrator has privileges on
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tags")]
	public List<AdminTag>? Tags { get; set; } = [];

	/// <summary>
	/// The list of networks that the SAML administrator has privileges on
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networks")]
	public List<SamlRoleNetwork>? Networks { get; set; } = [];

	/// <summary>
	/// Camera
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "camera")]
	public List<SamlRoleCamera>? Camera { get; set; }
}
