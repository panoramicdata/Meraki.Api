namespace Meraki.Api.Data;

/// <summary>
/// Upgrade settings for a wireless network
/// </summary>
[DataContract]
public class WirelessSettingsUpgrade
{
	/// <summary>
	/// Predownload settings for wireless upgrades
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "predownload")]
	public WirelessSettingsUpgradePredownload? Predownload { get; set; }
}