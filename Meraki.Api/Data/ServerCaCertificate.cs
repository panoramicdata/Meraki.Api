using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The CA certificate used to sign the LDAP server's key.
	/// </summary>
	[DataContract]
	public partial class ServerCaCertificate
	{
		/// <summary>
		/// The contents of the CA certificate. Must be in PEM or DER format.
		/// </summary>
		[DataMember(Name = "contents")]
		public string Contents { get; set; } = string.Empty;
	}
}
