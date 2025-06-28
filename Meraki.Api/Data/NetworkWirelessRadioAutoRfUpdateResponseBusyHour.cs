namespace Meraki.Api.Data;

/// <summary>
/// Busy Hour settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateResponseBusyHour
{
	/// <summary>
	/// Minimize Changes settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimizeChanges")]
	public NetworkWirelessRadioAutoRfUpdateResponseBusyHourMinimizeChanges MinimizeChanges { get; set; } = new();

	/// <summary>
	/// Busy hour mode settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "schedule")]
	public NetworkWirelessRadioAutoRfUpdateResponseBusyHourSchedule Schedule { get; set; } = new();
}
