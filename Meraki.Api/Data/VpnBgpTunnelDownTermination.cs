namespace Meraki.Api.Data;

/// <summary>
/// BGP tunnel down termination settings - Undocumented, observed in responses only
/// </summary>
[DataContract]
public class VpnBgpTunnelDownTermination
{
	/// <summary>
	/// Whether BGP sessions are terminated when the tunnel goes down
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
