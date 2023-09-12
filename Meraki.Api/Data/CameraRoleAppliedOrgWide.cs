namespace Meraki.Api.Data;

/// <summary>
/// ermissions to be applied org wide.
/// </summary>
[DataContract]
public class CameraRoleAppliedOrgWide
{
	/// <summary>
	/// Permission scope id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "permissionScopeId")]
	public string? PermissionScopeId { get; set; }
}
