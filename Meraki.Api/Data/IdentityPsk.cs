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
	public string Passphrase { get; set; } = string.Empty;

	/// <summary>
	/// The group policy to be applied to clients
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "groupPolicyId")]
	public string GroupPolicyId { get; set; } = string.Empty;
}
