namespace Meraki.Api.Data;

/// <summary>
/// Network Move
/// </summary>
[DataContract]
public class NetworkMove
{
	/// <summary>
	/// Generated ID of the created network move operation.
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkMoveId")]
	public string NetworkMoveId { get; set; } = string.Empty;

	/// <summary>
	/// URL to fetch the created network move e.g for polling, etc
	/// </summary>
	[DataMember(Name = "url")]
	[ApiAccess(ApiAccess.Read)]
	public string Url { get; set; } = string.Empty;
}
