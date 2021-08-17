using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Uplink selection
	/// </summary>
	[DataContract]
	public class UplinkSelection
	{
		/// <summary>
		/// activeActiveAutoVpnEnabled
		/// </summary>
		[DataMember(Name = "activeActiveAutoVpnEnabled")]
		public bool ActiveActiveAutoVpnEnabled { get; set; }

		/// <summary>
		/// Default uplink
		/// </summary>
		[DataMember(Name = "defaultUplink")]
		public string DefaultUplink { get; set; } = string.Empty;

		/// <summary>
		/// Load balancing enabled
		/// </summary>
		[DataMember(Name = "loadBalancingEnabled")]
		public bool LoadBalancingEnabled { get; set; }

		/// <summary>
		/// wanTrafficUplinkPreferences
		/// </summary>
		[DataMember(Name = "wanTrafficUplinkPreferences")]
		public List<TrafficUplinkPreferences> WanTrafficUplinkPreferences { get; set; } = new();

		/// <summary>
		/// vpnTrafficUplinkPreferences
		/// </summary>
		[DataMember(Name = "vpnTrafficUplinkPreferences")]
		public List<TrafficUplinkPreferences> VpnTrafficUplinkPreferences { get; set; } = new();
	}
}
