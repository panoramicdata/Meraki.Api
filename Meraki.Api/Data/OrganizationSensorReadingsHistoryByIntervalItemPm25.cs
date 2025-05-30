namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'pm25' metric. This will only be present if the 'metric' property equals 'pm25'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemPm25
{
	/// <summary>
	/// Aggregated PM2.5 readings in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "concentration")]
	public OrganizationSensorReadingsHistoryByIntervalItemPm25Concentration Concentration { get; set; } = new();
}
