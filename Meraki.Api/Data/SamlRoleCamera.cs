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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "access")]
	public string Access { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not SAML administrator has org-wide access
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "orgWide")]
	public string? OrgWide { get; set; } = string.Empty;
}
