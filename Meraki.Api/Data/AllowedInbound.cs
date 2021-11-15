using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// AllowedInbound
/// </summary>
[DataContract]
public class AllowedInbound
{
	/// <summary>
	/// Gets or Sets Protocol
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocol")]
	public TcpUdpIcmppingAnyProtocol Protocol { get; set; }

	/// <summary>
	/// An array of ports or port ranges that will be forwarded to the host on the LAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destinationPorts")]
	public List<string> DestinationPorts { get; set; } = new();

	/// <summary>
	/// An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges, or &#39;any&#39;
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedIps")]
	public List<string> AllowedIps { get; set; } = new();
}
