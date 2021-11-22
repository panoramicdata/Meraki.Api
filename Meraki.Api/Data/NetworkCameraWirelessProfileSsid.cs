namespace Meraki.Api.Data;

/// <summary>
/// The details of the SSID config.
/// </summary>
[DataContract]
public class NetworkCameraWirelessProfileSsid
{
	/// <summary>
	/// The auth mode of the SSID. It can be set to ('psk', '8021x-radius').
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "authMode")]
	public string AuthMode { get; set; } = string.Empty;

	/// <summary>
	/// The encryption mode of the SSID. It can be set to ('wpa', 'wpa-eap'). With 'wpa' mode, the authMode should be 'psk' and with 'wpa-eap' the authMode should be '8021x-radius'
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "encryptionMode")]
	public string EncryptionMode { get; set; } = string.Empty;

	/// <summary>
	/// The name of the SSID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The pre-shared key of the SSID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "psk")]
	public string Psk { get; set; } = string.Empty;
}
