namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkClientPolicy
/// </summary>
[DataContract]
public class ClientPolicyUpdateRequest
{
	/// <summary>
	/// MAC address
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The policy to assign. Can be 'Whitelisted', 'Blocked', 'Normal' or 'Group policy'. Required.
	/// </summary>
	/// <value>The policy to assign. Can be 'Whitelisted', 'Blocked', 'Normal' or 'Group policy'. Required.</value>
	[DataMember(Name = "devicePolicy")]
	public string DevicePolicy { get; set; } = string.Empty;
	/// <summary>
	/// [optional] If 'devicePolicy' is set to 'Group policy' this param is used to specify the group policy ID.
	/// </summary>
	/// <value>[optional] If 'devicePolicy' is set to 'Group policy' this param is used to specify the group policy ID.</value>
	[DataMember(Name = "groupPolicyId")]
	public string GroupPolicyId { get; set; } = string.Empty;
}
