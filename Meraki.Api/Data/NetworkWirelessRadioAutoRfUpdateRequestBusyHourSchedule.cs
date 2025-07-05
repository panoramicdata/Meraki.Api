namespace Meraki.Api.Data;

/// <summary>
/// Busy hour mode settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateRequestBusyHourSchedule
{
	/// <summary>
	/// The Busy Hour mode applied to the network when minimizeChanges is enabled. Must be one of 'automatic' or 'manual'. Automatic busy hour is only available on firmware versions >= MR 27.0
	/// </summary>
	[DataMember(Name = "mode")]
	public BusyHourMode? Mode { get; set; }

	/// <summary>
	/// Manual Busy Hour settings
	/// </summary>
	[DataMember(Name = "manual")]
	public NetworkWirelessRadioAutoRfUpdateRequestBusyHourScheduleManual? Manual { get; set; }
}
