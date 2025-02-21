namespace Meraki.Api.Data;

/// <summary>
/// Failover
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerGroupFailover
{
	/// <summary>
	/// DirectToInternet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "directToInternet")]
	public bool DirectToInternet { get; set; }
}
