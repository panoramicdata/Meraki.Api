namespace Meraki.Api.Data;

/// <summary>
/// The list of camera access privileges for SAML administrator
/// </summary>
[DataContract]
public class SamlRoleCamera
{
	/// <summary>
	/// Camera access ability
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "access")]
	public string? Access { get; set; }

	/// <summary>
	/// Whether or not SAML administrator has org-wide access
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "orgWide")]
	public bool? OrgWide { get; set; }
}
