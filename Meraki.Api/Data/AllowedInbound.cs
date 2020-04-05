using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// AllowedInbound
	/// </summary>
	[DataContract]
	public partial class AllowedInbound
	{
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public TcpUdpIcmppingAnyProtocol Protocol { get; set; }

		/// <summary>
		/// An array of ports or port ranges that will be forwarded to the host on the LAN
		/// </summary>
		/// <value>An array of ports or port ranges that will be forwarded to the host on the LAN</value>
		[DataMember(Name = "destinationPorts", EmitDefaultValue = false)]
		public List<string> DestinationPorts { get; set; }

		/// <summary>
		/// An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges, or &#39;any&#39;
		/// </summary>
		/// <value>An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges, or &#39;any&#39;</value>
		[DataMember(Name = "allowedIps", EmitDefaultValue = false)]
		public List<string> AllowedIps { get; set; }
	}
}