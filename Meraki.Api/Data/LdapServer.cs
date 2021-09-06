using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The LDAP servers to be used for authentication.
	/// </summary>
	[DataContract]
	public class LdapServer
	{
		/// <summary>
		/// UDP port the LDAP server listens on.
		/// </summary>
		[DataMember(Name = "port")]
		public int Port { get; set; }

		/// <summary>
		/// IP address of your LDAP server.
		/// </summary>
		[DataMember(Name = "host")]
		public string Host { get; set; } = string.Empty;
	}
}
