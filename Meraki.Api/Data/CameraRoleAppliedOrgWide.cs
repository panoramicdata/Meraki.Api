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

	/// <summary>
	/// Permission level
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "permissionLevel")]
	public string? PermissionLevel { get; set; }

	/// <summary>
	/// Permission scope name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "permissionScope")]
	public string? PermissionScope { get; set; }

	/// <summary>
	/// Organization tag
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tag")]
	public string? Tag { get; set; }
}
