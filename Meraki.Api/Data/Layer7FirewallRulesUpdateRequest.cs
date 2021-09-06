using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkL7FirewallRules
	/// </summary>
	[DataContract]
	public class Layer7FirewallRulesUpdateRequest
	{
		/// <summary>
		/// An ordered array of the MX L7 firewall rules
		/// </summary>
		/// <value>An ordered array of the MX L7 firewall rules</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<Layer7FirewallRule> Rules { get; set; } = null!;
	}
}
