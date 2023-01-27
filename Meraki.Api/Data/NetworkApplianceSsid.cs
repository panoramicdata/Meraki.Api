namespace Meraki.Api.Data;

/// <summary>
/// Network Appliance SSID
/// </summary>
[DataContract]
public class NetworkApplianceSsid
{
	/// <summary>
	/// Default VLAN Id
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultVlanId")]
	public int? DefaultVlanId { get; set; }

	/// <summary>
	/// The number of the SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// Auth Mode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "authMode")]
	public AuthMode? AuthMode { get; set; }

	/// <summary>
	/// The PSK Encryption mode for the SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "encryptionMode")]
	public EncryptionMode? EncryptionMode { get; set; }

	/// <summary>
	/// The passkey for the SSID. This param is only valid if the authMode is 'psk'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "psk")]
	public string? Psk { get; set; }

	/// <summary>
	/// The name of the SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// WPA Encryption Mode for the SSID
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
	public List<RadiusServer>? RadiusServers { get; set; }
}
