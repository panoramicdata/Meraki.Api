using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Authentication types
	/// </summary>
	[DataContract]
	public class AuthenticationTypes
	{
		/// <summary>
		/// NonEapInnerAuthentication
		/// </summary>
		[DataMember(Name = "nonEapInnerAuthentication")]
		public List<string> NonEapInnerAuthentication { get; set; } = new();

		/// <summary>
		/// EapInnerAuthentication
		/// </summary>
		[DataMember(Name = "eapInnerAuthentication")]
		public List<string> EapInnerAuthentication { get; set; } = new();

		/// <summary>
		/// Credentials
		/// </summary>
		[DataMember(Name = "credentials")]
		public List<string> Credentials { get; set; } = new();

		/// <summary>
		/// TunneledEapMethodCredentials
		/// </summary>
		[DataMember(Name = "tunneledEapMethodCredentials")]
		public List<string> TunneledEapMethodCredentials { get; set; } = new();
	}
}
