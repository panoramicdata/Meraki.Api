namespace Meraki.Api.Data;

/// <summary>
/// Network tag on which this specified permission is applied.
/// </summary>
[DataContract]
public class CameraRoleAppliedOnNetwork
{
	/// <summary>
	/// Network id.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Permission scope id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "permissionScopeId")]
	public string? PermissionScopeId { get; set; }

	/// <summary>
	/// Device tag.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tag")]
	public string? Tag { get; set; }
}
