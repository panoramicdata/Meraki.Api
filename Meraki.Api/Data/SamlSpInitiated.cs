namespace Meraki.Api.Data;

/// <summary>
/// SAML SP-initiated SSO configuration
/// </summary>
[DataContract]
public class SamlSpInitiated
{
	/// <summary>
	/// The subdomain for SP-initiated SSO
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "subdomain")]
	public string? Subdomain { get; set; }

	/// <summary>
	/// The identity provider identifier for SP-initiated SSO
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "idpId")]
	public string? IdpId { get; set; }
}
