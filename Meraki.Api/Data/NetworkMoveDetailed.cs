namespace Meraki.Api.Data;

/// <summary>
/// Network Move Detailed.
/// </summary>
[DataContract]
public class NetworkMoveDetailed
{
	/// <summary>
	/// Timestamp of when the network move initiated
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp when the network move status last changed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpdatedAt")]
	public string LastUpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// ID of the network move operation
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "moveId")]
	public string MoveId { get; set; } = string.Empty;

	/// <summary>
	/// Current status of the network move operation. No longer in the v1.74.0 spec, which reports it under <see cref="Result"/>; kept for responses that still send it.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// Result of the network move operation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "result")]
	public NetworkMoveResult? Result { get; set; }

	/// <summary>
	/// User who initiated the move
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "initiator")]
	public NetworkMoveInitiator Initiator { get; set; } = new();

	/// <summary>
	/// Network to be moved
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public NetworkMoveNetwork Network { get; set; } = new();

	/// <summary>
	/// Organizations involved in the network move
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizations")]
	public NetworkMoveOrganizations Organizations { get; set; } = new();
}
