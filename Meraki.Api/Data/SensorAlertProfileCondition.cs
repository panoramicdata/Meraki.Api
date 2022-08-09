namespace Meraki.Api.Data;

/// <summary>
/// Sensor Alert Profile Condition
/// </summary>
[DataContract]
public class SensorAlertProfileCondition
{
	/// <summary>
	/// Metric for the alert
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "metric")]
	public SensorAlertConditionMetric? Metric { get; set; }

	/// <summary>
	/// Threshold for the alert
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "threshold")]
	public SensorAlertConditionThreshold? Threshold { get; set; }

	/// <summary>
	/// Direction for the threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "direction")]
	public string? Direction { get; set; }

	/// <summary>
	/// Duration
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "duration")]
	public int? Duration { get; set; }
}