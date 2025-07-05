namespace Meraki.Api.Data;

/// <summary>
/// Ambient noise reading.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemNoiseAmbient
{
	/// <summary>
	/// Aggregated ambient noise readings in adjusted decibels.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public OrganizationSensorReadingsHistoryByIntervalItemNoiseAmbientLevel Level { get; set; } = new();
}
