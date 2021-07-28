using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// SSID Identity psks
	/// </summary>
	[DataContract]
	public class IdentityPsks
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Passphrase
		/// </summary>
		[DataMember(Name = "passphrase")]
		public string Passphrase { get; set; } = string.Empty;

		/// <summary>
		/// Group policy id
		/// </summary>
		[DataMember(Name = "groupPolicyId")]
		public string GroupPolicyId { get; set; } = string.Empty;
	}
}
