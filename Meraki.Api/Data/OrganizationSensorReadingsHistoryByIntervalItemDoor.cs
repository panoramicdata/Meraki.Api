namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'door' metric. This will only be present if the 'metric' property equals 'door'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemDoor
{
	/// <summary>
	/// Accumulated counts of door readings.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSensorReadingsHistoryByIntervalItemDoorCounts Counts { get; set; } = new();
}
