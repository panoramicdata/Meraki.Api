using System.Collections.Generic;
using System.Runtime.Serialization;

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
	/// The privilege of the SAML administrator on the organization
	/// </summary>
	/// <value>The privilege of the SAML administrator on the organization</value>
	[DataMember(Name = "orgAccess")]
	public string OrgAccess { get; set; } = null!;

	/// <summary>
	/// The list of tags that the SAML administrator has privleges on
	/// </summary>
	/// <value>The list of tags that the SAML administrator has privleges on</value>
	[DataMember(Name = "tags")]
	public List<Tag> Tags { get; set; } = null!;

	/// <summary>
	/// The list of networks that the SAML administrator has privileges on
	/// </summary>
	/// <value>The list of networks that the SAML administrator has privileges on</value>
	[DataMember(Name = "networks")]
	public List<SamlRoleNetwork> Networks { get; set; } = null!;
}
