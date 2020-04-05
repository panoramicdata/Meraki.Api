using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// PortRule
	/// </summary>
	[DataContract]
	public partial class PortRule
	{
		/// <summary>
		/// A description of the rule
		/// </summary>
		/// <value>A description of the rule</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public TcpUdpProtocol Protocol { get; set; }
		/// <summary>
		/// Destination port of the traffic that is arriving on the WAN
		/// </summary>
		/// <value>Destination port of the traffic that is arriving on the WAN</value>
		[DataMember(Name = "publicPort", EmitDefaultValue = false)]
		public string PublicPort { get; set; }
		/// <summary>
		/// Local IP address to which traffic will be forwarded
		/// </summary>
		/// <value>Local IP address to which traffic will be forwarded</value>
		[DataMember(Name = "localIp", EmitDefaultValue = false)]
		public string LocalIp { get; set; }
		/// <summary>
		/// Destination port of the forwarded traffic that will be sent from the MX to the specified host on the LAN. If you simply wish to forward the traffic without translating the port, this should be the same as the Public port
		/// </summary>
		/// <value>Destination port of the forwarded traffic that will be sent from the MX to the specified host on the LAN. If you simply wish to forward the traffic without translating the port, this should be the same as the Public port</value>
		[DataMember(Name = "localPort", EmitDefaultValue = false)]
		public string LocalPort { get; set; }
		/// <summary>
		/// Remote IP addresses or ranges that are permitted to access the internal resource via this port forwarding rule, or &#39;any&#39;
		/// </summary>
		/// <value>Remote IP addresses or ranges that are permitted to access the internal resource via this port forwarding rule, or &#39;any&#39;</value>
		[DataMember(Name = "allowedIps", EmitDefaultValue = false)]
		public List<string> AllowedIps { get; set; }
	}
}
