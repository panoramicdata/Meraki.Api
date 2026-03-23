namespace Meraki.Api.Data;

/// <summary>
/// Predownload settings for wireless upgrades
/// </summary>
[DataContract]
public class WirelessSettingsUpgradePredownload
{
	/// <summary>
	/// Whether upgrade predownload is enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}