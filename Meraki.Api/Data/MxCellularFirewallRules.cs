using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkCellularFirewallRules
	/// </summary>
	[DataContract]
	public class MxCellularFirewallRules
	{
		/// <summary>
		/// An ordered array of the firewall rules (not including the default rule)
		/// </summary>
		/// <value>An ordered array of the firewall rules (not including the default rule)</value>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "rules")]
		public List<MxCellularFirewallRule> Rules { get; set; } = new();
	}
}
