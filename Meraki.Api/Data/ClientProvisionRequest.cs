namespace Meraki.Api.Data;

/// <summary>
/// ProvisionNetworkClients
/// </summary>
[DataContract]
public class ClientProvisionRequest
{
	/// <summary>
	/// Gets or Sets DevicePolicy
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "devicePolicy")]
	public DevicePolicy DevicePolicy { get; set; }

	/// <summary>
	/// The ID of the desired group policy to apply to the client. Required if 'devicePolicy' is set to \&quot;Group policy\&quot;. Otherwise this is ignored.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "groupPolicyId")]
	public string? GroupPolicyId { get; set; }

	/// <summary>
	/// Gets or Sets PoliciesBySecurityAppliance
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "policiesBySecurityAppliance")]
	public PoliciesBySecurityAppliance PoliciesBySecurityAppliance { get; set; } = new();

	/// <summary>
	/// An object, describing the policy-connection associations for each active SSID within the network. Keys should be the number of enabled SSIDs, mapping to an object describing the client's policy
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "policiesBySsid")]
	public Dictionary<string, DevicePolicyBySsid> PoliciesBySsid { get; set; } = new();

	/// <summary>
	/// The array of clients to provision
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "clients")]
	public List<ClientProvision> Clients { get; set; } = new();
}
