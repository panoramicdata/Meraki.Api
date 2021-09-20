using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// NetworkApplianceInboundFirewallRules
	/// </summary>
	[DataContract]
	public class NetworkApplianceInboundFirewallRules
	{
		/// <summary>
		/// An ordered array of the firewall rules (not including the default rule)
		/// </summary>
		/// <value>An ordered array of the firewall rules (not including the default rule)</value>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "rules")]
		public List<MxCellularFirewallRule> Rules { get; set; } = new();
		/// <summary>
		/// Log the special default rule (boolean value - enable only if you&#39;ve configured a syslog server) (optional)
		/// </summary>
		/// <value>Log the special default rule (boolean value - enable only if you&#39;ve configured a syslog server) (optional)</value>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "syslogDefaultRule")]
		public bool? SyslogDefaultRule { get; set; }
	}
}
