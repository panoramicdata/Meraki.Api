namespace Meraki.Api.Data;

/// <summary>
/// MulticastForwardingByNetworkItemNetwork
/// </summary>
[DataContract]
public class MulticastForwardingByNetworkItemNetwork
{
	/// <summary>
	/// ID of the network whose multicast forwarding settings are returned.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the network whose multicast forwarding settings are returned.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
