using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The identity of the wireless profile. Required for creating wireless profiles in 8021x-radius auth mode.
	/// </summary>
	[DataContract]
	public class WirelessProfilesIdentity
	{
		/// <summary>
		/// The password of the identity.
		/// </summary>
		[DataMember(Name = "password")]
		public string Password { get; set; } = string.Empty;

		/// <summary>
		/// The username of the identity.
		/// </summary>
		[DataMember(Name = "username")]
		public string Username { get; set; } = string.Empty;
	}
}
