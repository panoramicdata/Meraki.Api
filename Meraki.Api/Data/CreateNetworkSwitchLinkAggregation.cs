using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkSwitchLinkAggregation
	/// </summary>
	[DataContract]
	public partial class CreateNetworkSwitchLinkAggregation
	{
		/// <summary>
		/// Array of switch or stack ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.
		/// </summary>
		/// <value>Array of switch or stack ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.</value>
		[DataMember(Name = "switchPorts", EmitDefaultValue = false)]
		public List<SwitchPort> SwitchPorts { get; set; }
		/// <summary>
		/// Array of switch profile ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.
		/// </summary>
		/// <value>Array of switch profile ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.</value>
		[DataMember(Name = "switchProfilePorts", EmitDefaultValue = false)]
		public List<SwitchProfilePort> SwitchProfilePorts { get; set; }
	}
}
