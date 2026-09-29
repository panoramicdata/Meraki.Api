namespace Meraki.Api.Data;

/// <summary>
/// 802.11be settings for SSIDs
/// </summary>
[DataContract]
public class WirelessRfProfileBeSsids
{
	/// <summary>
	/// 802.11be settings for SSID groups, keyed by group number: '1' is SSIDs 0-3, '2' is 4-7, '3' is 8-11, '4' is 12-14
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "groups")]
	public Dictionary<string, WirelessRfProfileBeSsidGroup> Groups { get; set; } = [];
}
