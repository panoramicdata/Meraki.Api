namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'water' metric. This will only be present if the 'metric' property equals 'water'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemWater
{
	/// <summary>
	/// Accumulated counts of water detection readings.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSensorReadingsHistoryByIntervalItemWaterCounts Counts { get; set; } = new();
}
