namespace Meraki.Api.Data;

/// <summary>
/// Peer Group
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerGroup
{
	/// <summary>
	/// [optional] Represents the ordering of primary and backup tunnels group.
	/// primary and backup tunnels are grouped by this number.
	/// Peers containing same group number belongs to same group.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "number")]
	public int? Number { get; set; }

	/// <summary>
	/// [optional] Contains the failover configuration for the group.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "failover")]
	public ThirdPartyVpnPeerGroupFailover? Failover { get; set; }

	/// <summary>
	/// Both primary and backup tunnels are active
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "activeActiveTunnel")]
	public bool? ActiveActiveTunnel { get; set; }
}
