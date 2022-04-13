namespace Meraki.Api.Data;

/// <summary>
/// CreateNetworkStaticRoute
/// </summary>
[DataContract]
public class StaticRouteCreationRequest : NamedItem
{
	/// <summary>
	/// The subnet of the static route
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// The gateway IP (next hop) of the static route
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "gatewayIp")]
	public string GatewayIp { get; set; } = string.Empty;


	/// <summary>
	/// The gateway IP (next hop) VLAN ID of the static route
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "gatewayVlanId")]
	public string? GatewayVlanId { get; set; } = string.Empty;
}
