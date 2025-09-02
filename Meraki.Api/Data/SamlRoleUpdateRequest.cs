namespace Meraki.Api.Data;

/// <summary>
/// UpdateOrganizationSamlRole
/// </summary>
[DataContract]
public class SamlRoleUpdateRequest
{
	/// <summary>
	/// The role of the SAML administrator
	/// </summary>
	/// <value>The role of the SAML administrator</value>
	[DataMember(Name = "role")]
	public string Role { get; set; } = null!;

	/// <summary>
	/// The privilege of the SAML administrator on the organization. Can be one of 'none', 'read-only', 'full' or 'enterprise' or a custom role in the format custom-role:ID:NAME.
	/// </summary>
	[DataMember(Name = "orgAccess")]
	public string OrgAccess { get; set; } = null!;

	/// <summary>
	/// The list of tags that the SAML administrator has privileges on
	/// </summary>
	/// <value>The list of tags that the SAML administrator has privileges on</value>
	[DataMember(Name = "tags")]
	public List<AdminTag> Tags { get; set; } = null!;

	/// <summary>
	/// The list of networks that the SAML administrator has privileges on
	/// </summary>
	/// <value>The list of networks that the SAML administrator has privileges on</value>
	[DataMember(Name = "networks")]
	public List<SamlRoleNetwork> Networks { get; set; } = null!;
}
