namespace Meraki.Api.Data;

/// <summary>
/// Triggered alert condition for the sensor alert.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileCondition
{
	/// <summary>
	/// Length of time in seconds that the triggering state must persist before an alert is sent. Available options are 0 seconds, 1 minute, 2 minutes, 3 minutes, 4 minutes, 5 minutes, 10 minutes, 15 minutes, 30 minutes, 1 hour, 2 hours, 4 hours, and 8 hours. Default is 0. default = 0, enum = [0, 60, 120, 180, 240, ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "duration")]
	public int Duration { get; set; }

	/// <summary>
	/// If 'above', an alert will be sent when a sensor reads above the threshold. If 'below', an alert will be sent when a sensor reads below the threshold. Only applicable for temperature, humidity, realPower, apparentPower, powerFactor, voltage, current, and frequency thresholds. 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "direction")]
	public ProfileConditionDirection Direction { get; set; }

	/// <summary>
	/// The type of sensor metric that will be monitored for changes. enum = ["apparentPower", "co2", "current", "door", "frequency", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "metric")]
	public string Metric { get; set; } = string.Empty;

	/// <summary>
	/// Threshold for sensor readings that will cause an alert to be sent. This object should contain a single property key matching the condition's 'metric' value.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "threshold")]
	public OrganizationsSensorAlertProfileConditionThreshold Threshold { get; set; } = new();
}
