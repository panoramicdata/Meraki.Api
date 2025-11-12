namespace Meraki.Api.Data;

/// <summary>
/// Static Route
/// </summary>
[DataContract]
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
	/// Gets the gateway
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "gateway")]
	public StaticRouteGateway? Gateway { get; set; }
}
