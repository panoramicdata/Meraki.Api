namespace Meraki.Api.Data;

/// <summary>
/// Busy Hour settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateRequestBusyHour
{
	/// <summary>
	/// Minimize Changes settings
	/// </summary>
	[DataMember(Name = "minimizeChanges")]
	public NetworkWirelessRadioAutoRfUpdateRequestBusyHourMinimizeChanges? MinimizeChanges { get; set; }

	/// <summary>
	/// Busy hour mode settings
	/// </summary>
	[DataMember(Name = "schedule")]
	public NetworkWirelessRadioAutoRfUpdateRequestBusyHourSchedule? Schedule { get; set; }
}
