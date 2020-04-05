using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Default multicast setting for entire network. IGMP snooping and Flood unknown multicast traffic settings are enabled by default.
	/// </summary>
	[DataContract]
	public partial class DefaultSettings
	{
		/// <summary>
		/// IGMP snooping setting for entire network
		/// </summary>
		/// <value>IGMP snooping setting for entire network</value>
		[DataMember(Name = "igmpSnoopingEnabled", EmitDefaultValue = false)]
		public bool? IgmpSnoopingEnabled { get; set; }
		/// <summary>
		/// Flood unknown multicast traffic setting for entire network
		/// </summary>
		/// <value>Flood unknown multicast traffic setting for entire network</value>
		[DataMember(Name = "floodUnknownMulticastTrafficEnabled", EmitDefaultValue = false)]
		public bool? FloodUnknownMulticastTrafficEnabled { get; set; }
	}
}
