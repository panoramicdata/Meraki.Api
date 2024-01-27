namespace Meraki.Api.Data;

/// <summary>
/// NetworkAlertSettingsMutingByPortSchedules
/// </summary>
[DataContract]
public class NetworkAlertSettingsMutingByPortSchedules
{
	/// <summary>
	/// NetworkAlertSettingsMutingByPortSchedules Enabled - Undocumented as at 2023-06-23
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
