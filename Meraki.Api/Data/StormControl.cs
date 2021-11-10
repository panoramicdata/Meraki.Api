using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsStormControl
	/// </summary>
	[DataContract]
	public class StormControl
	{
		/// <summary>
		/// Percentage (1 to 99) of total available port bandwidth for broadcast traffic type. Default value 100 percent rate is to clear the configuration.
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "broadcastThreshold")]
		public int BroadcastThreshold { get; set; }

		/// <summary>
		/// Percentage (1 to 99) of total available port bandwidth for multicast traffic type. Default value 100 percent rate is to clear the configuration.
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "multicastThreshold")]
		public int MulticastThreshold { get; set; }

		/// <summary>
		/// Percentage (1 to 99) of total available port bandwidth for unknown unicast (dlf-destination lookup failure) traffic type. Default value 100 percent rate is to clear the configuration.
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "unknownUnicastThreshold")]
		public int UnknownUnicastThreshold { get; set; }
	}
}
