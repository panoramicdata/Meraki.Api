using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Wireless settings
	/// </summary>
	[DataContract]
	public class WirelessSettings
	{
		/// <summary>
		/// Toggle for enabling or disabling meshing in a network
		/// </summary>
		[DataMember(Name = "meshingEnabled")]
		public bool MeshingEnabled { get; set; }

		/// <summary>
		/// Toggle for enabling or disabling IPv6 bridging in a network (Note: if enabled, SSIDs must also be configured to use bridge mode)
		/// </summary>
		[DataMember(Name = "ipv6BridgeEnabled")]
		public bool Ipv6BridgeEnabled { get; set; }

		/// <summary>
		/// Toggle for enabling or disabling location analytics for your network
		/// </summary>
		[DataMember(Name = "locationAnalyticsEnabled")]
		public bool LocationAnalyticsEnabled { get; set; }
	}
}