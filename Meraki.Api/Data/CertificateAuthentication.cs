using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The current setting for certificate verification.
	/// </summary>
	[DataContract]
	public partial class CertificateAuthentication
	{
		/// <summary>
		/// (Optional) The URL of the OCSP responder to verify client certificate status.
		/// </summary>
		[DataMember(Name = "ocspResponderUrl")]
		public string? OcspResponderUrl { get; set; }

		/// <summary>
		/// Whether or not to use EAP-TLS certificate-based authentication to validate wireless clients.
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Whether or not to verify the certificate with LDAP.
		/// </summary>
		[DataMember(Name = "useLdap")]
		public bool UseLdap { get; set; }

		/// <summary>
		/// Whether or not to verify the certificate with OCSP.
		/// </summary>
		[DataMember(Name = "useOcsp")]
		public bool UseOcsp { get; set; }

		/// <summary>
		/// The Client CA Certificate used to sign the client certificate.
		/// </summary>
		[DataMember(Name = "clientRootCaCertificate")]
		public ServerCaCertificate ClientRootCaCertificate { get; set; } = new();
	}
}
