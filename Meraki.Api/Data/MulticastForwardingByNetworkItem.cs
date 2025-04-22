namespace Meraki.Api.Data;

/// <summary>
/// MulticastForwardingByNetworkItem
/// </summary>
[DataContract]
public class MulticastForwardingByNetworkItem
{
	/// <summary>
	/// Network details
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "network")]
	public MulticastForwardingByNetworkItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Static multicast forwarding rules.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<MulticastForwardingByNetworkItemRule> Rules { get; set; } = [];
}
