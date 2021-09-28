using Meraki.Api.Attributes;
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
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "service")]
		public string Service { get; set; } = string.Empty;

		/// <summary>
		/// Access
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "access")]
		public string Access { get; set; } = string.Empty;

		/// <summary>
		/// Allowed ips
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "allowedIps")]
		public List<string> AllowedIps { get; set; } = new();
	}
}
