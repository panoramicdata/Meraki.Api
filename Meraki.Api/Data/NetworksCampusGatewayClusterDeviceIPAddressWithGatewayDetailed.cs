﻿namespace Meraki.Api.Data;

/// <summary>
/// Address of the interface
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterDeviceIPAddressWithGatewayDetailed
{
	/// <summary>
	/// Gateway of the interface
	/// </summary>
	[DataMember(Name = "gateway")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Gateway { get; set; }

	/// <summary>
	/// Protocol of the interface
	/// </summary>
	[DataMember(Name = "protocol")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworksCampusGatewayClusterProtocol? Protocol { get; set; }

	/// <summary>
	/// Subnet mask of the interface
	/// </summary>
	[DataMember(Name = "subnetMask")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? SubnetMask { get; set; }

}