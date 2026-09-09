namespace Meraki.Api.Data;

/// <summary>
/// Predownload settings for a scheduled firmware upgrade
/// </summary>
[DataContract]
public class NextUpgradePredownload
{
	/// <summary>
	/// Whether the firmware is downloaded to the devices ahead of the scheduled upgrade
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
