namespace Meraki.Api.Data;

/// <summary>
/// Paginated list of network move operations in an organization
/// </summary>
[DataContract]
public class NetworkMovesResponse
	: ItemsResponseWithMeta<NetworkMoveDetailed>
{
	/// <summary>
	/// Network move operations
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<NetworkMoveDetailed> Items { get; set; } = [];
}
