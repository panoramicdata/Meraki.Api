namespace Meraki.Api.Data;

/// <summary>
/// Camera role
/// </summary>
[DataContract]
public class CameraRole : NamedIdentifiedItem
{
	/// <summary>
	/// Device tag on which this specified permission is applied.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "appliedOnDevices")]
	public List<CameraRoleAppliedOnDevice>? AppliedOnDevices { get; set; }

	/// <summary>
	/// Network tag on which this specified permission is applied.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "appliedOnNetworks")]
	public List<CameraRoleAppliedOnNetwork>? AppliedOnNetworks { get; set; }

	/// <summary>
	/// Permissions to be applied org wide.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "appliedOrgWide")]
	public List<CameraRoleAppliedOrgWide>? AppliedOrgWide { get; set; }
}
