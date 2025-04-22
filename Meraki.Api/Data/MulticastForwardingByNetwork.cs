namespace Meraki.Api.Data;

/// <summary>
/// MulticastForwardingByNetwork
/// </summary>
[DataContract]
public class MulticastForwardingByNetwork
	: ItemsResponseWithMeta<MulticastForwardingByNetworkItem>
{
	/// <summary>
	/// List of networks with multicast static forwarding rules
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "items")]
	public override List<MulticastForwardingByNetworkItem> Items { get; set; } = [];
}
