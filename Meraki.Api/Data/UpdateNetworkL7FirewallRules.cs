using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkL7FirewallRules
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkL7FirewallRules
	{
		/// <summary>
		/// An ordered array of the MX L7 firewall rules
		/// </summary>
		/// <value>An ordered array of the MX L7 firewall rules</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<Rule6> Rules { get; set; }
	}
}
