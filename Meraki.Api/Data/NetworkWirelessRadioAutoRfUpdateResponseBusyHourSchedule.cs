namespace Meraki.Api.Data;

/// <summary>
/// Busy hour mode settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateResponseBusyHourSchedule
{
	/// <summary>
	/// The Busy Hour mode applied to the network when minimizeChanges is enabled. Must be one of 'automatic' or 'manual'. Automatic busy hour is only available on firmware versions >= MR 27.0
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public BusyHourMode Mode { get; set; }

	/// <summary>
	/// Automatic Busy Hour settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "automatic")]
	public NetworkWirelessRadioAutoRfUpdateResponseBusyHourScheduleAutomatic Automatic { get; set; } = new();

	/// <summary>
	/// Manual Busy Hour settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "manual")]
	public NetworkWirelessRadioAutoRfUpdateResponseBusyHourScheduleManual Manual { get; set; } = new();
}
