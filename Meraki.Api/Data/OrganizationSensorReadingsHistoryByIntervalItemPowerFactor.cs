namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'powerFactor' metric. This will only be present if the 'metric' property equals 'powerFactor'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemPowerFactor
{
	/// <summary>
	/// Aggregated power factor readings as a percentage.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public OrganizationSensorReadingsHistoryByIntervalItemPowerFactorPercentage Percentage { get; set; } = new();
}
