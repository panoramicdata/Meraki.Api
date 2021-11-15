namespace Meraki.Api.Data;

/// <summary>
/// The schedule for the group policy. Schedules are applied to days of the week.
/// </summary>
[DataContract]
public class Scheduling
{
	/// <summary>
	/// Whether scheduling is enabled (true) or disabled (false). Defaults to false. If true, the schedule objects for each day of the week (monday - sunday) are parsed.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Gets or Sets Monday
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "monday")]
	public DaySchedule Monday { get; set; } = new();

	/// <summary>
	/// Gets or Sets Tuesday
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tuesday")]
	public DaySchedule Tuesday { get; set; } = new();

	/// <summary>
	/// Gets or Sets Wednesday
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "wednesday")]
	public DaySchedule Wednesday { get; set; } = new();

	/// <summary>
	/// Gets or Sets Thursday
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "thursday")]
	public DaySchedule Thursday { get; set; } = new();

	/// <summary>
	/// Gets or Sets Friday
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "friday")]
	public DaySchedule Friday { get; set; } = new()!;

	/// <summary>
	/// Gets or Sets Saturday
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "saturday")]
	public DaySchedule Saturday { get; set; } = new();

	/// <summary>
	/// Gets or Sets Sunday
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sunday")]
	public DaySchedule Sunday { get; set; } = new();
}
