namespace Meraki.Api.Data;

/// <summary>
/// Network2
/// </summary>
[DataContract]
public class SamlRoleNetwork
{
	/// <summary>
	/// The network ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The privilege of the SAML administrator on the network. Can be one of 'full', 'read-only', 'guest-ambassador', 'monitor-only', 'ssid-admin', 'port-tags' or 'custom-role'
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "access")]
	public AccessPrivilege Access { get; set; }
}
