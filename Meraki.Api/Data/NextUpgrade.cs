namespace Meraki.Api.Data;

/// <summary>
/// Next upgrade
/// </summary>
[DataContract]
public class NextUpgrade
{
	/// <summary>
	/// Time
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "time")]
	public string Time { get; set; } = string.Empty;

	/// <summary>
	/// To version
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "toVersion")]
	public Version ToVersion { get; set; } = new();

	/// <summary>
	/// The strategy that network devices will use to perform the upgrade: 'minimizeClientDowntime' or 'minimizeUpgradeTime'. If unspecified, the scheduled upgrade will use the default strategy for the network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "strategy")]
	public string? Strategy { get; set; }

	/// <summary>
	/// Predownload settings for the firmware upgrade
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "predownload")]
	public NextUpgradePredownload? Predownload { get; set; }
}
