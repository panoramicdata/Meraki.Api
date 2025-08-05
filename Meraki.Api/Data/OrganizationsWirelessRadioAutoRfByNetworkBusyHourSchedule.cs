namespace Meraki.Api.Data;

/// <summary>
/// Busy hour mode settings
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfByNetworkBusyHourSchedule
{
	/// <summary>
	/// The Busy Hour mode applied to the network when minimizeChanges is enabled. Must be one of 'automatic' or 'manual'. Automatic busy hour is only available on firmware versions >= MR 27.0
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public ScheduleMode Mode { get; set; }

	/// <summary>
	/// Automatic Busy Hour settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "automatic")]
	public OrganizationsWirelessRadioAutoRfByNetworkBusyHourScheduleAutomatic Automatic { get; set; } = new();

	/// <summary>
	/// Manual Busy Hour settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "manual")]
	public OrganizationsWirelessRadioAutoRfByNetworkBusyHourScheduleManual Manual { get; set; } = new();
}
