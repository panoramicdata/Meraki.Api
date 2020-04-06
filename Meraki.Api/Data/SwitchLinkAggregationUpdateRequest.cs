using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchLinkAggregation
	/// </summary>
	[DataContract]
	public partial class SwitchLinkAggregationUpdateRequest
	{
		/// <summary>
		/// Array of switch or stack ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported.
		/// </summary>
		/// <value>Array of switch or stack ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported.</value>
		[DataMember(Name = "switchPorts", EmitDefaultValue = false)]
		public List<SwitchPort> SwitchPorts { get; set; }
		/// <summary>
		/// Array of switch profile ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported.
		/// </summary>
		/// <value>Array of switch profile ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported.</value>
		[DataMember(Name = "switchProfilePorts", EmitDefaultValue = false)]
		public List<SwitchProfilePort> SwitchProfilePorts { get; set; }
	}
}
