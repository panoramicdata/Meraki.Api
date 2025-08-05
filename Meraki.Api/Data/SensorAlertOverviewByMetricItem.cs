namespace Meraki.Api.Data;

/// <summary>
/// Sensor Alert Overview By Metric Item
/// </summary>
[DataContract]
public class SensorAlertOverviewByMetricItem
{
	/// <summary>
	/// End of the timespan over which sensor alerts are counted
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Start of the timespan over which sensor alerts are counted
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Counts of sensor alerts over the timespan, by reading metric
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public SensorAlertOverviewByMetricItemCounts Counts { get; set; } = new();
}
