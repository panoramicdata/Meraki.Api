using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationVpnFirewallRules
	/// </summary>
	[DataContract]
	public partial class VpnFirewallRulesUpdateRequest
	{
		/// <summary>
		/// An ordered array of the firewall rules (not including the default rule)
		/// </summary>
		/// <value>An ordered array of the firewall rules (not including the default rule)</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<VpnFirewallRule> Rules { get; set; } = null!;

		/// <summary>
		/// Log the special default rule (boolean value - enable only if you&#39;ve configured a syslog server) (optional)
		/// </summary>
		/// <value>Log the special default rule (boolean value - enable only if you&#39;ve configured a syslog server) (optional)</value>
		[DataMember(Name = "syslogDefaultRule", EmitDefaultValue = false)]
		public bool? SyslogDefaultRule { get; set; }
	}
}
