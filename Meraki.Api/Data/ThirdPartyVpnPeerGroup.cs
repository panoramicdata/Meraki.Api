namespace Meraki.Api.Data;

/// <summary>
/// Peer Group
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerGroup
{
	/// <summary>
	/// Number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int? Number { get; set; }

	/// <summary>
	/// Failover
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failover")]
	public ThirdPartyVpnPeerGroupFailover? Failover { get; set; }
}
