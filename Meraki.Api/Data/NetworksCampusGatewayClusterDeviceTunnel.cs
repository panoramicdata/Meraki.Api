﻿namespace Meraki.Api.Data;

/// <summary>
/// Tunnel setting of a device when tunnel interface of cluster is specified
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterDeviceTunnel
{
	/// <summary>
	/// Tunnel interface name
	/// </summary>
	[DataMember(Name = "interface")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Tunnel IP addresses of the device
	/// </summary>
	[DataMember(Name = "addresses")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksCampusGatewayClusterDeviceIPAddress> Addresses { get; set; } = [];
}
