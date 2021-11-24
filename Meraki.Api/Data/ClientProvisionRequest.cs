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
	[DataMember(Name = "devicePolicy")]
	public DevicePolicy DevicePolicy { get; set; }

	/// <summary>
	/// The ID of the desired group policy to apply to the client. Required if 'devicePolicy' is set to \&quot;Group policy\&quot;. Otherwise this is ignored.
	/// </summary>
	/// <value>The ID of the desired group policy to apply to the client. Required if 'devicePolicy' is set to \&quot;Group policy\&quot;. Otherwise this is ignored.</value>
	[DataMember(Name = "groupPolicyId")]
	public string GroupPolicyId { get; set; } = null!;

	/// <summary>
	/// Gets or Sets PoliciesBySecurityAppliance
	/// </summary>
	[DataMember(Name = "policiesBySecurityAppliance")]
	public PoliciesBySecurityAppliance PoliciesBySecurityAppliance { get; set; } = null!;

	/// <summary>
	/// An object, describing the policy-connection associations for each active SSID within the network. Keys should be the number of enabled SSIDs, mapping to an object describing the client's policy
	/// </summary>
	/// <value>An object, describing the policy-connection associations for each active SSID within the network. Keys should be the number of enabled SSIDs, mapping to an object describing the client's policy</value>
	[DataMember(Name = "policiesBySsid")]
	public Dictionary<string, GeneratedObject> PoliciesBySsid { get; set; } = null!;

	/// <summary>
	/// The array of clients to provision
	/// </summary>
	[DataMember(Name = "clients")]
	public List<Clients> Clients { get; set; } = new();
}
