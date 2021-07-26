using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// SAML IdPs
	/// </summary>
	[DataContract]
	public class SamlIdps
	{
		/// <summary>
		/// idpId
		/// </summary>
		[DataMember(Name = "idpId")]
		public string IdpId { get; set; } = string.Empty;

		/// <summary>
		/// Consumer URL
		/// </summary>
		[DataMember(Name = "consumerUrl")]
		public string ConsumerUrl { get; set; } = string.Empty;

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
