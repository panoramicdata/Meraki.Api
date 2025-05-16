namespace Meraki.Api.Data;

/// <summary>
/// Schedule of the packet capture
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileSchedule
{
	/// <summary>
	/// The number of frequency units between each occurrence. For example, 1 means 'every [frequency]', 2 means 'every other [frequency]', etc. Used in conjunction with the 'frequency' field.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "recurrence")]
	public int Recurrence { get; set; }

	/// <summary>
	/// End date of the recurring schedule entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Frequency of the recurring schedule entry ex. hour|week|month|day|minute
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "frequency")]
	public string Frequency { get; set; } = string.Empty;

	/// <summary>
	/// Name of the schedule
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The datetime at which next capture will occur
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "nextCaptureTs")]
	public string NextCaptureTs { get; set; } = string.Empty;

	/// <summary>
	/// Start date of the recurring schedule entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// The days of the week for the recurring schedule in string form. Multiple days can be combined.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "weekdays")]
	public List<string> Weekdays { get; set; } = [];
}