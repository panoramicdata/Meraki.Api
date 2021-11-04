using Meraki.Api.Attributes;
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
		/// Toggle for enabling or disabling active-active AutoVPN
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "activeActiveAutoVpnEnabled")]
		public bool ActiveActiveAutoVpnEnabled { get; set; }

		/// <summary>
		/// The default uplink. Must be one of: 'wan1' or 'wan2'
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "defaultUplink")]
		public Uplink DefaultUplink { get; set; }

		/// <summary>
		/// Toggle for enabling or disabling load balancing
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "loadBalancingEnabled")]
		public bool LoadBalancingEnabled { get; set; }

		/// <summary>
		/// Array of uplink preference rules for WAN traffic
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "wanTrafficUplinkPreferences")]
		public List<TrafficUplinkPreference> WanTrafficUplinkPreferences { get; set; } = new();

		/// <summary>
		/// Array of uplink preference rules for VPN traffic
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "vpnTrafficUplinkPreferences")]
		public List<TrafficUplinkPreference> VpnTrafficUplinkPreferences { get; set; } = new();
	}
}
