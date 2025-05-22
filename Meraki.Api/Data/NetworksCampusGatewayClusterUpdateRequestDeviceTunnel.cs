﻿namespace Meraki.Api.Data;

/// <summary>
/// Tunnel setting of the device when tunnel interface of cluster is specified
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestDeviceTunnel
{
	/// <summary>
	/// Tunnel interface name
	/// </summary>
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Tunnel IP addresses of the device
	/// </summary>
	[DataMember(Name = "addresses")]
	public List<NetworksCampusGatewayClusterUpdateRequestDeviceTunnelAddress>? Addresses { get; set; }
}
