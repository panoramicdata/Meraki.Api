namespace Meraki.Api.Data;

/// <summary>
/// SSID access control settings
/// </summary>
[DataContract]
public class SsidAccessControl
{
	/// <summary>
	/// Encryption settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "encryption")]
	public SsidAccessControlEncryption? Encryption { get; set; }

	/// <summary>
	/// Bandwidth settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "bandwidth")]
	public SsidAccessControlBandwidth? Bandwidth { get; set; }

	/// <summary>
	/// Client IP assignment settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientIpAssignment")]
	public SsidAccessControlClientIpAssignment? ClientIpAssignment { get; set; }

	/// <summary>
	/// Whether clients are blocked from using LAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientsBlockedFromUsingLan")]
	public bool? ClientsBlockedFromUsingLan { get; set; }

	/// <summary>
	/// Whether wired clients are part of the Wi-Fi network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wiredClientsPartOfWifiNetwork")]
	public bool? WiredClientsPartOfWifiNetwork { get; set; }

	/// <summary>
	/// Tunnel settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tunnel")]
	public SsidAccessControlTunnel? Tunnel { get; set; }

	/// <summary>
	/// VLAN settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public SsidAccessControlVlan? Vlan { get; set; }

	/// <summary>
	/// Splash page settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "splashPage")]
	public SsidAccessControlSplashPage? SplashPage { get; set; }
}
