namespace Meraki.Api.Data;

/// <summary>
/// SAML IdPs
/// </summary>
[DataContract]
public class SamlIdp
{
	/// <summary>
	/// idpId
	/// </summary>
	[ApiKey]
	[DataMember(Name = "idpId")]
	public string IdpId { get; set; } = string.Empty;

	/// <summary>
	/// Consumer URL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "consumerUrl")]
	public string ConsumerUrl { get; set; } = string.Empty;

	/// <summary>
	/// Fingerprint (SHA1) of the SAML certificate provided by your Identity Provider (IdP). This will be used for encryption / validation.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "x509certSha1Fingerprint")]
	public string X509certSha1Fingerprint { get; set; } = string.Empty;

	/// <summary>
	/// Dashboard will redirect users to this URL when they sign out.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sloLogoutUrl")]
	public string SloLogoutUrl { get; set; } = string.Empty;
}
