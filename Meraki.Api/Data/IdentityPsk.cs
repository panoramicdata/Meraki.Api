namespace Meraki.Api.Data;

/// <summary>
/// SSID Identity psks
/// </summary>
[DataContract]
public class IdentityPsk : NamedIdentifiedItem
{
	/// <summary>
	/// The passphrase for client authentication. If left blank, one will be auto-generated
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "passphrase")]
	public string? Passphrase { get; set; }

	/// <summary>
	/// The group policy to be applied to clients
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "groupPolicyId")]
	public string? GroupPolicyId { get; set; }

	/// <summary>
	/// Wifi Prsonal Network ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "wifiPersonalNetworkId")]
	public string? WifiPersonalNetworkId { get; set; }

	/// <summary>
	/// Email
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "email")]
	public string? Email { get; set; }
}
