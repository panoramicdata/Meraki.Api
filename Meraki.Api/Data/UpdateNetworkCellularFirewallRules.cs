using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkCellularFirewallRules
	/// </summary>
	[DataContract]
	public partial class MxCellularFirewallRules
	{
		/// <summary>
		/// An ordered array of the firewall rules (not including the default rule)
		/// </summary>
		/// <value>An ordered array of the firewall rules (not including the default rule)</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<MxCellularFirewallRule> Rules { get; set; }
	}
}
