using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkWirelessSettings
	/// </summary>
	[DataContract]
	public partial class WirelessSettingsUpdateDto
	{
		/// <summary>
		/// Toggle for enabling or disabling meshing in a network
		/// </summary>
		/// <value>Toggle for enabling or disabling meshing in a network</value>
		[DataMember(Name = "meshingEnabled", EmitDefaultValue = false)]
		public bool? MeshingEnabled { get; set; }
		/// <summary>
		/// Toggle for enabling or disabling IPv6 bridging in a network (Note: if enabled, SSIDs must also be configured to use bridge mode)
		/// </summary>
		/// <value>Toggle for enabling or disabling IPv6 bridging in a network (Note: if enabled, SSIDs must also be configured to use bridge mode)</value>
		[DataMember(Name = "ipv6BridgeEnabled", EmitDefaultValue = false)]
		public bool? Ipv6BridgeEnabled { get; set; }
		/// <summary>
		/// Toggle for enabling or disabling location analytics for your network
		/// </summary>
		/// <value>Toggle for enabling or disabling location analytics for your network</value>
		[DataMember(Name = "locationAnalyticsEnabled", EmitDefaultValue = false)]
		public bool? LocationAnalyticsEnabled { get; set; }
		/// <summary>
		/// Toggle for enabling or disabling LED lights on all APs in the network (making them run dark)
		/// </summary>
		/// <value>Toggle for enabling or disabling LED lights on all APs in the network (making them run dark)</value>
		[DataMember(Name = "ledLightsOn", EmitDefaultValue = false)]
		public bool? LedLightsOn { get; set; }
	}
}
