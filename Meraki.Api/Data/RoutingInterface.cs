using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Routing interface
	/// </summary>
	[DataContract]
	public class RoutingInterface
	{
		/// <summary>
		/// Interface Id
		/// </summary>
		[DataMember(Name = "interfaceId")]
		public string InterfaceId { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Subnet
		/// </summary>
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = string.Empty;

		/// <summary>
		/// InterfaceIp
		/// </summary>
		[DataMember(Name = "interfaceIp")]
		public string InterfaceIp { get; set; } = string.Empty;

		/// <summary>
		/// Multicast routing
		/// </summary>
		[DataMember(Name = "multicastRouting")]
		public string MulticastRouting { get; set; } = string.Empty;

		/// <summary>
		/// Vlan id
		/// </summary>
		[DataMember(Name = "vlanId")]
		public int VlanId { get; set; } = 0;

		/// <summary>
		/// Default gateway
		/// </summary>
		[DataMember(Name = "defaultGateway")]
		public string DefaultGateway { get; set; } = string.Empty;

		/// <summary>
		/// OSPF settings
		/// </summary>
		[DataMember(Name = "ospfSettings")]
		public OspfSettings OspfSettings { get; set; } = new();
	}
}
