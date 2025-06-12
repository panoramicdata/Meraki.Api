namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'indoorAirQuality' metric. This will only be present if the 'metric' property equals 'indoorAirQuality'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemIndoorAirQuality
{
	/// <summary>
	/// Aggregated indoor air quality readings as a score between 0-100.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "score")]
	public OrganizationSensorReadingsHistoryByIntervalItemIndoorAirQualityScore Score { get; set; } = new();
}
