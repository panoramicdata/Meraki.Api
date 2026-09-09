namespace Meraki.Api.Data;

/// <summary>
/// 802.11be settings for one SSID group
/// </summary>
[DataContract]
public class WirelessRfProfileBeSsidGroup
{
	/// <summary>
	/// Whether 802.11be is enabled for the SSID group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
