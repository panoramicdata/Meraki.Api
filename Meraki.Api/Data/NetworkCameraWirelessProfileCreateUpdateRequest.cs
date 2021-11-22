namespace Meraki.Api.Data;

/// <summary>
/// Network wireless profiles
/// </summary>
[DataContract]
public class NetworkCameraWirelessProfileCreateUpdateRequest
{
	/// <summary>
	/// The name of the camera wireless profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The identity of the wireless profile. Required for creating wireless profiles in 8021x-radius auth mode.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "identity")]
	public NetworkCameraWirelessProfileIdentity Identity { get; set; } = new();

	/// <summary>
	/// The details of the SSID config.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ssid")]
	public NetworkCameraWirelessProfileSsid Ssid { get; set; } = new();
}
