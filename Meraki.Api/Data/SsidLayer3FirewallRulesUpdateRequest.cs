using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSsidL3FirewallRules
	/// </summary>
	[DataContract]
	public class SsidLayer3FirewallRulesUpdateRequest
	{
		/// <summary>
		/// An ordered array of the firewall rules for this SSID (not including the local LAN access rule or the default rule)
		/// </summary>
		/// <value>An ordered array of the firewall rules for this SSID (not including the local LAN access rule or the default rule)</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<SsidLayer3FirewallRule> Rules { get; set; } = null!;

		/// <summary>
		/// Allow wireless client access to local LAN (boolean value - true allows access and false denies access) (optional)
		/// </summary>
		/// <value>Allow wireless client access to local LAN (boolean value - true allows access and false denies access) (optional)</value>
		[DataMember(Name = "allowLanAccess", EmitDefaultValue = false)]
		public bool? AllowLanAccess { get; set; }
	}
}
