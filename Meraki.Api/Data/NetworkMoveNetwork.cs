namespace Meraki.Api.Data;

/// <summary>
/// Network to be moved
/// </summary>
[DataContract]
public class NetworkMoveNetwork
{
	/// <summary>
	/// ID of the network being moved
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}