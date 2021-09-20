using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// NetworkAlertSettings
	/// </summary>
	[DataContract]
	public class NetworkAlertSettings
	{
		/// <summary>
		/// Gets or Sets DefaultDestinations
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "defaultDestinations")]
		public DefaultDestinations? DefaultDestinations { get; set; }

		/// <summary>
		/// Alert-specific configuration for each type. Only alerts that pertain to the network can be updated.
		/// </summary>
		/// <value>Alert-specific configuration for each type. Only alerts that pertain to the network can be updated.</value>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "alerts")]
		public List<Alert>? Alerts { get; set; }
	}
}
