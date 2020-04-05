using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkConnectivityMonitoringDestinations
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkConnectivityMonitoringDestinations
	{
		/// <summary>
		/// The list of connectivity monitoring destinations
		/// </summary>
		/// <value>The list of connectivity monitoring destinations</value>
		[DataMember(Name = "destinations", EmitDefaultValue = false)]
		public List<Destination> Destinations { get; set; }
	}
}
