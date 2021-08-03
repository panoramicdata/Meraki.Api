using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Routing interface update request
	/// </summary>
	[DataContract]
	public class RoutingInterfaceUpdateRequest
	{
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
		/// Interface ip
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
		public string VlanId { get; set; } = string.Empty;

		/// <summary>
		/// OSPF settings
		/// </summary>
		[DataMember(Name = "ospfSettings")]
		public OspfSettings OspfSettings { get; set; } = new();
	}
}