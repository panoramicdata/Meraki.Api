namespace Meraki.Api.Data;

/// <summary>
/// Undocumented
/// </summary>
[DataContract]
public class WirelessRfProfileBe
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// 802.11be is enabled for 'all SSIDs' or 'per SSID group'
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }

	/// <summary>
	/// 802.11be settings for SSIDs
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ssids")]
	public WirelessRfProfileBeSsids? Ssids { get; set; }
}
