namespace Meraki.Api.Data;

/// <summary>
/// NetworkClientPolicyBySsid
/// </summary>
[DataContract]
public class ClientPolicyPolicyBySsid
{
	/// <summary>
	/// The SSID number for the policy rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssidNumber")]
	public int SsidNumber { get; set; }

	/// <summary>
	/// The device policy applied to the client for this SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "devicePolicy")]
	public string DevicePolicy { get; set; } = string.Empty;

	/// <summary>
	/// The group policy identifier for this SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "groupPolicyId")]
	public string groupPolicyId { get; set; } = string.Empty;
}
