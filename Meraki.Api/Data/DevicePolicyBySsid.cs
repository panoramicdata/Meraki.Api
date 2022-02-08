namespace Meraki.Api.Data;

/// <summary>
/// The number for the SSID
/// </summary>
[DataContract]
public class DevicePolicyBySsid
{
	/// <summary>
	/// Gets or Sets DevicePolicy
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "devicePolicy")]
	public SsidDevicePolicy DevicePolicy { get; set; }

	/// <summary>
	/// The ID of the desired group policy to apply to the client. Required if 'devicePolicy' is set to \&quot;Group policy\&quot;. Otherwise this is ignored.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "groupPolicyId")]
	public string GroupPolicyId { get; set; } = string.Empty;
}
