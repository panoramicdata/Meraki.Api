namespace Meraki.Api.Data;

/// <summary>
/// Admin who initiated the move
/// </summary>
[DataContract]
public class NetworkMoveInitiatorAdmin
{
	/// <summary>
	/// ID of the Admin
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}