using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Authorizations
	/// </summary>
	[DataContract]
	public partial class Authorizations
	{
		/// <summary>
		/// SSID number
		/// </summary>
		[DataMember(Name = "ssidNumber")]
		public int SsidNumber { get; set; } = 0;

		/// <summary>
		/// Authorized zone
		/// </summary>
		[DataMember(Name = "authorizedZone")]
		public string AuthorizedZone { get; set; } = string.Empty;

		/// <summary>
		/// Expires at
		/// </summary>
		[DataMember(Name = "expiresAt")]
		public string ExpiresAt { get; set; } = string.Empty;

		/// <summary>
		/// Authorized by name
		/// </summary>
		[DataMember(Name = "authorizedByName")]
		public string AuthorizedByName { get; set; } = string.Empty;

		/// <summary>
		/// Authorized by email
		/// </summary>
		[DataMember(Name = "authorizedByEmail")]
		public string authorizedByEmail { get; set; } = string.Empty;
	}
}
