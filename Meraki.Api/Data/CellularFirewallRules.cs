using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkCellularFirewallRules
	/// </summary>
	[DataContract]
	public class CellularFirewallRules
	{
		/// <summary>
		/// An ordered array of the firewall rules (not including the default rule)
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "rules")]
		public List<CellularFirewallRule> Rules { get; set; } = new();
	}
}
