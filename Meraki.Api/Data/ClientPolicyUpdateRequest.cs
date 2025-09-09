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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The policy to assign. Can be 'Whitelisted' (sic), 'Blocked', 'Normal' or 'Group policy'. Required.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "devicePolicy")]
	public ClientDevicePolicy DevicePolicy { get; set; }

	/// <summary>
	/// [optional] If 'devicePolicy' is set to 'Group policy' this param is used to specify the group policy ID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "groupPolicyId")]
	public string? GroupPolicyId { get; set; }

	/// <summary>
	/// The policies applied to the client by SSID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "policiesBySsid")]
	public ClientPolicyPolicyBySsid PoliciesBySsid { get; set; } = new();
}