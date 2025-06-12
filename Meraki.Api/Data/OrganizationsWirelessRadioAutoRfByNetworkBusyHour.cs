namespace Meraki.Api.Data;

/// <summary>
/// Busy Hour settings
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfByNetworkBusyHour
{
	/// <summary>
	/// Minimize Changes settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minimizeChanges")]
	public OrganizationsWirelessRadioAutoRfByNetworkBusyHourMinimizeChanges MinimizeChanges { get; set; } = new();

	/// <summary>
	/// Busy hour mode settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "schedule")]
	public OrganizationsWirelessRadioAutoRfByNetworkBusyHourSchedule Schedule { get; set; } = new();
}
