using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// (Optional) The credentials of the user account to be used by the AP to bind to your Active Directory server. The Active Directory account should have permissions on all your Active Directory servers. Only valid if the splashPage is 'Password-protected with Active Directory'.
	/// </summary>
	[DataContract]
	public class ActiveDirectoryCredentials
	{
		/// <summary>
		/// The logon name of the Active Directory account.
		/// </summary>
		[DataMember(Name = "logonName")]
		public string LogonName { get; set; } = string.Empty;

		/// <summary>
		/// The password to the Active Directory user account.
		/// </summary>
		[DataMember(Name = "password")]
		public string Password { get; set; } = string.Empty;
	}
}
