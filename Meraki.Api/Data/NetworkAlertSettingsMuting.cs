namespace Meraki.Api.Data;

/// <summary>
/// NetworkAlertSettingsMuting
/// </summary>
[DataContract]
public class NetworkAlertSettingsMuting
{
	/// <summary>
	/// Muting - Undocumented as at 2023-06-23
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "byPortSchedules")]
	public NetworkAlertSettingsMutingByPortSchedules? ByPortSchedules { get; set; }
}
