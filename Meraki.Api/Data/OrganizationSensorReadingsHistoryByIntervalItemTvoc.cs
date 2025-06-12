namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'tvoc' metric. This will only be present if the 'metric' property equals 'tvoc'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemTvoc
{
	/// <summary>
	/// Aggregated TVOC readings in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "concentration")]
	public OrganizationSensorReadingsHistoryByIntervalItemTvocConcentration Concentration { get; set; } = new();
}
