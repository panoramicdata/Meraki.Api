namespace Meraki.Api.Data;

/// <summary>
/// VPN settings
/// </summary>
[DataContract]
public class VpnSettings
{
	/// <summary>
	///	Secondary VPN concentrator settings. This is only used when two VPN concentrators are configured on the SSID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "failover")]
	public Failover? Failover { get; set; }

	/// <summary>
	/// The VPN split tunnel settings for this SSID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splitTunnel")]
	public SplitTunnel SplitTunnel { get; set; } = new();

	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "concentrator")]
	public WirelessSsidVpnConcentrator? Concentrator { get; set; } = new();
}
