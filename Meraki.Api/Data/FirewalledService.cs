using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Firewalled service
	/// </summary>
	[DataContract]
	public class FirewalledService
	{
		/// <summary>
		/// Service
		/// </summary>
		[DataMember(Name = "service")]
		public string Service { get; set; } = string.Empty;

		/// <summary>
		/// Access
		/// </summary>
		[DataMember(Name = "access")]
		public string Access { get; set; } = string.Empty;

		/// <summary>
		/// Allowed ips
		/// </summary>
		[DataMember(Name = "allowedIps")]
		public List<string> AllowedIps { get; set; } = new();
	}
}
