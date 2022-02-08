namespace Meraki.Api.Data;

/// <summary>
/// VPN settings
/// </summary>
[DataContract]
public class VpnSettings
{
	/// <summary>
	///	Failover
	/// </summary>
	[DataMember(Name = "failover")]
	public Failover Failover { get; set; } = new();

	/// <summary>
	/// Split tunnel
	/// </summary>
	[DataMember(Name = "splitTunnel")]
	public SplitTunnel SplitTunnel { get; set; } = new();
}
