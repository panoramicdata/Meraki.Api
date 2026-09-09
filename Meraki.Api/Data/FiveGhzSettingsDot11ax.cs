namespace Meraki.Api.Data;

/// <summary>
/// IEEE 802.11ax (Wi-Fi 6) settings for the 5Ghz band
/// </summary>
[DataContract]
public class FiveGhzSettingsDot11ax
{
	/// <summary>
	/// Determines whether IEEE 802.11ax (Wi-Fi 6) on the 5 GHz band is enabled. Can be either true or false. If false, we highly recommend disabling band steering. If omitted, the existing 5 GHz IEEE 802.11ax setting is preserved.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
