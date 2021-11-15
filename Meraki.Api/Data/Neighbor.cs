using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Neighbors
/// </summary>
[DataContract]
public class Neighbor
{
	/// <summary>
	/// IP address of the neighbor.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Remote ASN of the neighbor. The remote ASN must be an integer between 1 and 4294967295.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "remoteAsNumber")]
	public int RemoteAsNumber { get; set; }

	/// <summary>
	/// The receive limit is the maximum number of routes that can be received from any BGP peer. The receive limit must be an integer between 0 and 4294967295. When absent, it defaults to 0.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "receiveLimit")]
	public int ReceiveLimit { get; set; }

	/// <summary>
	/// When this feature is on, the Meraki device will advertise routes learned from other Autonomous Systems, thereby allowing traffic between Autonomous Systems to transit this AS. When absent, it defaults to false.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowTransit")]
	public bool AllowTransit { get; set; }

	/// <summary>
	/// The EBGP hold timer in seconds for each neighbor. The EBGP hold timer must be an integer between 12 and 240.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ebgpHoldTimer")]
	public int EbgpHoldTimer { get; set; }

	/// <summary>
	/// Configure this if the neighbor is not adjacent. The EBGP multi-hop must be an integer between 1 and 255.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ebgpMultihop")]
	public int EbgpMultihop { get; set; }
}
