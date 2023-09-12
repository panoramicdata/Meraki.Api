namespace Meraki.Api.Data;

/// <summary>
/// Camera role Applied On Device
/// </summary>
[DataContract]
public class CameraRoleAppliedOnDevice
{
	/// <summary>
	/// Device id.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Network id scope
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "inNetworksWithId")]
	public string? InNetworksWithId { get; set; }

	/// <summary>
	/// Network tag scope
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "inNetworksWithTag")]
	public string? InNetworksWithTag { get; set; }

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
