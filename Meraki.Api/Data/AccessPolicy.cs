using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Access policy
	/// </summary>
	[DataContract]
	public class AccessPolicy
	{
		/// <summary>
		/// Access policy number
		/// </summary>
		[DataMember(Name = "accessPolicyNumber")]
		public string AccessPolicyNumber { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Radius servers
		/// </summary>
		[DataMember(Name = "radiusServers")]
		public List<RadiusServer> RadiusServers { get; set; } = new();

		/// <summary>
		/// Radius testing enabled
		/// </summary>
		[DataMember(Name = "radiusTestingEnabled")]
		public bool RadiusTestingEnabled { get; set; }

		/// <summary>
		/// Radius coa support enabled
		/// </summary>
		[DataMember(Name = "radiusCoaSupportEnabled")]
		public bool RadiusCoaSupportEnabled { get; set; }

		/// <summary>
		/// Radius accounting enabled
		/// </summary>
		[DataMember(Name = "radiusAccountingEnabled")]
		public bool RadiusAccountingEnabled { get; set; }

		/// <summary>
		/// Radius accounting servers
		/// </summary>
		[DataMember(Name = "radiusAccountingServers")]
		public RadiusAccountingServer RadiusAccountingServers { get; set; } = new();

		/// <summary>
		/// Radius group attribute
		/// </summary>
		[DataMember(Name = "radiusGroupAttribute")]
		public string? RadiusGroupAttribute { get; set; }

		/// <summary>
		/// Host mode
		/// </summary>
		[DataMember(Name = "hostMode")]
		public string HostMode { get; set; } = string.Empty;

		/// <summary>
		/// Access policy type
		/// </summary>
		[DataMember(Name = "accessPolicyType")]
		public string AccessPolicyType { get; set; } = string.Empty;

		/// <summary>
		/// Increase access speed
		/// </summary>
		[DataMember(Name = "increaseAccessSpeed")]
		public bool IncreaseAccessSpeed { get; set; }

		/// <summary>
		/// Guest vlan id
		/// </summary>
		[DataMember(Name = "guestVlanId")]
		public int GuestVlanId { get; set; }

		/// <summary>
		/// Voice vlan clients
		/// </summary>
		[DataMember(Name = "voiceVlanClients")]
		public bool VoiceVlanClients { get; set; }

		/// <summary>
		/// Url redirect walled garden enabled
		/// </summary>
		[DataMember(Name = "urlRedirectWalledGardenEnabled")]
		public bool UrlRedirectWalledGardenEnabled { get; set; }

		/// <summary>
		/// Url redirect walled garden ranges
		/// </summary>
		[DataMember(Name = "urlRedirectWalledGardenRanges")]
		public string UrlRedirectWalledGardenRanges { get; set; } = string.Empty;
	}
}
