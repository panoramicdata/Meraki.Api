using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Ldap
	/// </summary>
	[DataContract]
	public partial class Ldap
	{
		/// <summary>
		/// The base distinguished name of users on the LDAP server.
		/// </summary>
		[DataMember(Name = "baseDistinguishedName")]
		public string BaseDistinguishedName { get; set; } = string.Empty;

		/// <summary>
		/// (Optional) The credentials of the user account to be used by the AP to bind to your LDAP server. The LDAP account should have permissions on all your LDAP servers.
		/// </summary>
		[DataMember(Name = "credentials")]
		public Credentials? Credentials { get; set; }

		/// <summary>
		/// The CA certificate used to sign the LDAP server's key.
		/// </summary>
		[DataMember(Name = "serverCaCertificate")]
		public ServerCaCertificate ServerCaCertificate { get; set; } = new();

		/// <summary>
		/// The LDAP servers to be used for authentication.
		/// </summary>
		[DataMember(Name = "servers")]
		public List<LdapServer> Servers { get; set; } = new();
	}
}
