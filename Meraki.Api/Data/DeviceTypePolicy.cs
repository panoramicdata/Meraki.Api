namespace Meraki.Api.Data;

/// <summary>
/// Device type policies
/// </summary>
[DataContract]
public class DeviceTypePolicy
{
	/// <summary>
	/// The device type. Can be one of 'Android', 'BlackBerry', 'Chrome OS', 'iPad', 'iPhone', 'iPod', 'Mac OS X', 'Windows', 'Windows Phone', 'B&N Nook' or 'Other OS'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "deviceType")]
	public GroupPolicyDeviceType DeviceType { get; set; }

	/// <summary>
	/// The device policy. Can be one of 'Allowed', 'Blocked' or 'Group policy'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "devicePolicy")]
	public GroupPolicyDevicePolicy DevicePolicy { get; set; }

	/// <summary>
	/// ID of the group policy object.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "groupPolicyId")]
	public int? GroupPolicyId { get; set; }
}
