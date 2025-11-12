namespace Meraki.Api.Data;

/// <summary>
/// Switch Port Schedule
/// </summary>
[DataContract]
public class SwitchPortSchedule : NamedIdentifiedItem
{
	/// <summary>
	/// The Network Id
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The schedule for switch port scheduling. Schedules are applied to days of the week. When it's empty, default schedule with all days of a week are configured. Any unspecified day in the schedule is added as a default schedule configuration of the day.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "portSchedule")]
	public PortSchedule PortSchedule { get; set; } = new();
}
