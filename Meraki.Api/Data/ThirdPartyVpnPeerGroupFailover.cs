namespace Meraki.Api.Data;

/// <summary>
/// Contains the failover configuration for the group.
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerGroupFailover
{
	/// <summary>
	/// [optional] When both primary and backup tunnels are down, direct traffic to the internet. Traffic will be routed via the WAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "directToInternet")]
	public bool? DirectToInternet { get; set; }
}
