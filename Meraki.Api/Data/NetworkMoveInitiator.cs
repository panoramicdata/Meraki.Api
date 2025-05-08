namespace Meraki.Api.Data;

/// <summary>
/// User who initiated the move
/// </summary>
[DataContract]
public class NetworkMoveInitiator
{
	/// <summary>
	/// Admin who initated the move
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "admin")]
	public NetworkMoveInitiatorAdmin Admin { get; set; } = new();
}
