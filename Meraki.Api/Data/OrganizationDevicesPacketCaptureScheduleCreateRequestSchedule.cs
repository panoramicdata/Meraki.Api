namespace Meraki.Api.Data;

/// <summary>
/// Schedule detail
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureScheduleCreateRequestSchedule
{
	/// <summary>
	/// Cardinality of the schedule frequency, ex. 1 = every day, 2 = every other day (when frequency = day)
	/// </summary>
	[DataMember(Name = "recurrence")]
	public int? Recurrence { get; set; }

	/// <summary>
	/// End date and time of the recurring schedule entry
	/// </summary>
	[DataMember(Name = "endTs")]
	public string? EndTs { get; set; }

	/// <summary>
	/// Frequency of the recurring schedule entry (hour, week, month, day, minute)
	/// </summary>
	[DataMember(Name = "frequency")]
	public string? Frequency { get; set; }

	/// <summary>
	/// Name of the schedule
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Start date and time of the recurring schedule entry
	/// </summary>
	[DataMember(Name = "startTs")]
	public string? StartTs { get; set; }

	/// <summary>
	/// Weekdays for the schedule: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
	/// </summary>
	[DataMember(Name = "weekdays")]
	public List<string>? Weekdays { get; set; }
}