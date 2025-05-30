namespace Meraki.Api.Data;

/// <summary>
/// Accumulated counts of door readings.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemDoorCounts
{
	/// <summary>
	/// Number of times the door was opened.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "open")]
	public int Open { get; set; }
}