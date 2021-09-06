using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// User
	/// </summary>
	[DataContract]
	public class User
	{
		/// <summary>
		/// The username for the SNMP user. Required.
		/// </summary>
		/// <value>The username for the SNMP user. Required.</value>
		[DataMember(Name = "username", EmitDefaultValue = false)]
		public string Username { get; set; } = null!;
		/// <summary>
		/// The passphrase for the SNMP user. Required.
		/// </summary>
		/// <value>The passphrase for the SNMP user. Required.</value>
		[DataMember(Name = "passphrase", EmitDefaultValue = false)]
		public string Passphrase { get; set; } = null!;
	}
}
