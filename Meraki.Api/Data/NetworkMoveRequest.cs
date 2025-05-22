namespace Meraki.Api.Data;

/// <summary>
/// Network Move Request
/// </summary>
[DataContract]
public class NetworkMoveRequest
{
	/// <summary>
	/// Network ID of the network to move
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// ID of the organization to which the network is moving
	/// </summary>
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;
}
