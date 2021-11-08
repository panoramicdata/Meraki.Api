using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Routing interface update request
	/// </summary>
	[DataContract]
	public class RoutingInterfaceUpdateRequest : NamedItem
	{
		/// <summary>
		/// The network that this routed interface is on, in CIDR notation (ex. 10.1.1.0/24).
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = string.Empty;

		/// <summary>
		/// The IP address this switch will use for layer 3 routing on this VLAN or subnet. This cannot be the same as the switch's management IP.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "interfaceIp")]
		public string InterfaceIp { get; set; } = string.Empty;

		/// <summary>
		/// Enable multicast support if, multicast routing between VLANs is required. Options are, 'disabled', 'enabled' or 'IGMP snooping querier'.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "multicastRouting")]
		public string MulticastRouting { get; set; } = string.Empty;

		/// <summary>
		/// The VLAN this routed interface is on. VLAN must be between 1 and 4094.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "vlanId")]
		public int VlanId { get; set; }

		/// <summary>
		/// The OSPF routing settings of the interface.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "ospfSettings")]
		public OspfSettings OspfSettings { get; set; } = new();
	}
}