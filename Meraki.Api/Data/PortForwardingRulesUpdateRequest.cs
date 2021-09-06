using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkPortForwardingRules
	/// </summary>
	[DataContract]
	public class PortForwardingRulesUpdateRequest
	{
		/// <summary>
		/// An array of port forwarding params
		/// </summary>
		/// <value>An array of port forwarding params</value>
		[DataMember(Name = "rules")]
		public List<PortForwardingRules> Rules { get; set; } = new();
	}
}
