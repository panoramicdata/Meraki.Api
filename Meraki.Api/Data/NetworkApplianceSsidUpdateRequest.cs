namespace Meraki.Api.Data;

/// <summary>
/// Network Appliance SSID Update Request
/// </summary>
[DataContract]
public class NetworkApplianceSsidUpdateRequest
{
	/// <summary>
	/// Default VLAN Id
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultVlanId")]
	public int? DefaultVlanId { get; set; }

	/// <summary>
	/// The association control method for the SSID ('open', 'psk', '8021x-meraki' or '8021x-radius').
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "authMode")]
	public AuthMode? AuthMode { get; set; }

	/// <summary>
	/// The psk encryption mode for the SSID ('wep' or 'wpa'). This param is only valid if the authMode is 'psk'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "encryptionMode")]
	public EncryptionMode? EncryptionMode { get; set; }

	/// <summary>
	/// The name of the SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The passkey for the SSID. This param is only valid if authMode is 'psk'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "psk")]
	public string? Psk { get; set; }

	/// <summary>
	/// The types of WPA encryption. Valid values are 'WPA1 and WPA2', 'WPA2 only', 'WPA3 Transition Mode', or 'WPA3 only'.
	/// This parameter is only valid if:
	/// (1) the authMode is 'psk' and the encryptionMode is 'wpa',
	/// (2) the authMode is '8021x-meraki', or
	/// (3) the authMode is '8021x-radius'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wpaEncryptionMode")]
	public WpaEncryptionMode? WpaEncryptionMode { get; set; }

	/// <summary>
	/// Whether or not the SSID is enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Boolean indicating whether the MX should advertise or hide this SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "visible")]
	public bool? Visible { get; set; }

	/// <summary>
	/// The RADIUS 802.1x. servers to be used for authentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusServers")]
	public List<NetworkApplianceSsidRadiusServer>? RadiusServers { get; set; }

	/// <summary>
	/// The current setting for Protected Management Frames (802.11w).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dot11w")]
	public NetworkApplianceSsidDot11w? Dot11w { get; set; }
}
