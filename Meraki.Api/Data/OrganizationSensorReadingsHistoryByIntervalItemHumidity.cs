namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'humidity' metric. This will only be present if the 'metric' property equals 'humidity'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemHumidity
{
	/// <summary>
	/// Aggregated humidity readings in %RH.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "relativePercentage")]
	public OrganizationSensorReadingsHistoryByIntervalItemHumidityRelativePercentage RelativePercentage { get; set; } = new();
}
