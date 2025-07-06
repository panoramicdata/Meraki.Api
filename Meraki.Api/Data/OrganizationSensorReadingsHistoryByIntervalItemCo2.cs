namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'co2' metric. This will only be present if the 'metric' property equals 'co2'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemCo2
{
	/// <summary>
	/// Aggregated CO2 readings in parts per million.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "concentration")]
	public OrganizationSensorReadingsHistoryByIntervalItemCo2Concentration Concentration { get; set; } = new();
}
