using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule9
	/// </summary>
	[DataContract]
	public class PortForwardingRules
	{
		/// <summary>
		/// A descriptive name for the rule
		/// </summary>
		/// <value>A descriptive name for the rule</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN
		/// </summary>
		/// <value>The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN</value>
		[DataMember(Name = "lanIp")]
		public string LanIp { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Uplink
		/// </summary>
		[DataMember(Name = "uplink")]
		public WanUplinkBothPossible Uplink { get; set; }

		/// <summary>
		/// A port or port ranges that will be forwarded to the host on the LAN
		/// </summary>
		/// <value>A port or port ranges that will be forwarded to the host on the LAN</value>
		[DataMember(Name = "publicPort")]
		public string PublicPort { get; set; } = null!;

		/// <summary>
		/// A port or port ranges that will receive the forwarded traffic from the WAN
		/// </summary>
		/// <value>A port or port ranges that will receive the forwarded traffic from the WAN</value>
		[DataMember(Name = "localPort")]
		public string LocalPort { get; set; } = null!;

		/// <summary>
		/// An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges (or any)
		/// </summary>
		/// <value>An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges (or any)</value>
		[DataMember(Name = "allowedIps")]
		public List<string> AllowedIps { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol")]
		public TcpUdpProtocol Protocol { get; set; }
	}
}
