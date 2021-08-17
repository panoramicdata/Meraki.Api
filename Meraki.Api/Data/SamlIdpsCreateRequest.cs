using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// SAML IdPs
	/// </summary>
	[DataContract]
	public class SamlIdpsCreateRequest
	{
		/// <summary>
		/// idpId
		/// </summary>
		[DataMember(Name = "idpId")]
		public string IdpId { get; set; } = string.Empty;

		/// <summary>
		/// x509certSha1Fingerprint
		/// </summary>
		[DataMember(Name = "x509certSha1Fingerprint")]
		public string X509certSha1Fingerprint { get; set; } = string.Empty;

		/// <summary>
		/// sloLogoutUrl
		/// </summary>
		[DataMember(Name = "sloLogoutUrl")]
		public string SloLogoutUrl { get; set; } = string.Empty;
	}
}
