namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'voltage' metric. This will only be present if the 'metric' property equals 'voltage'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemVoltage
{
	/// <summary>
	/// Aggregated voltage readings in volts.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public OrganizationSensorReadingsHistoryByIntervalItemVoltageLevel Level { get; set; } = new();
}
