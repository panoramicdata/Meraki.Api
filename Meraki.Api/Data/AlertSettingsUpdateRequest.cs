using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkAlertSettings
	/// </summary>
	[DataContract]
	public class AlertSettingsUpdateRequest
	{
		/// <summary>
		/// Gets or Sets DefaultDestinations
		/// </summary>
		[DataMember(Name = "defaultDestinations")]
		public DefaultDestinations? DefaultDestinations { get; set; }

		/// <summary>
		/// Alert-specific configuration for each type. Only alerts that pertain to the network can be updated.
		/// </summary>
		/// <value>Alert-specific configuration for each type. Only alerts that pertain to the network can be updated.</value>
		[DataMember(Name = "alerts")]
		public List<Alert>? Alerts { get; set; }
	}
}
