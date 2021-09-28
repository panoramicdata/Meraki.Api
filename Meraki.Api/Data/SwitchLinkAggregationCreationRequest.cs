using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkSwitchLinkAggregation
	/// </summary>
	[DataContract]
	public class SwitchLinkAggregationCreationRequest
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string? Id { get; set; }

		/// <summary>
		/// Array of switch or stack ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.
		/// </summary>
		/// <value>Array of switch or stack ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.</value>
		[DataMember(Name = "switchPorts")]
		public List<SwitchPort> SwitchPorts { get; set; } = null!;

		/// <summary>
		/// Array of switch profile ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.
		/// </summary>
		/// <value>Array of switch profile ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.</value>
		[DataMember(Name = "switchProfilePorts")]
		public List<SwitchProfilePort> SwitchProfilePorts { get; set; } = null!;
	}
}
