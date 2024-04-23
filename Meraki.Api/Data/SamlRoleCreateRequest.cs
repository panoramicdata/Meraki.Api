namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganizationSamlRole
/// </summary>
[DataContract]
public class SamlRoleCreateRequest
{
	/// <summary>
	/// The role of the SAML administrator
	/// </summary>
	[DataMember(Name = "role")]
	public string Role { get; set; } = string.Empty;

	/// <summary>
	/// The privilege of the SAML administrator on the organization
	/// </summary>
	[DataMember(Name = "orgAccess")]
	public string OrgAccess { get; set; } = string.Empty;

	/// <summary>
	/// The list of tags that the SAML administrator has privileges on
	/// </summary>
	[DataMember(Name = "tags")]
	public List<AdminTag>? Tags { get; set; }

	/// <summary>
	/// The list of networks that the SAML administrator has privileges on
	/// </summary>
	[DataMember(Name = "networks")]
	public List<SamlRoleNetwork>? Networks { get; set; }

	/// <summary>
	/// The list of camera access privileges for SAML administrator
	/// </summary>
	[DataMember(Name = "camera")]
	public List<SamlRoleCamera>? Camera { get; set; }
}
