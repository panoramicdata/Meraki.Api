namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'battery' metric. This will only be present if the 'metric' property equals 'battery'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemBattery
{
	/// <summary>
	/// Aggregated battery life readings as a percentage.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public OrganizationSensorReadingsHistoryByIntervalItemBatteryPercentage Percentage { get; set; } = new();
}
