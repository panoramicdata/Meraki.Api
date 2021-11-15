namespace Meraki.Api.Data;

public class StaticRoute : StaticRouteUpdateRequest
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Network id
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Gateway VLan Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "gatewayVlanId")]
	public string? GatewayVlanId { get; set; } = string.Empty;
}
