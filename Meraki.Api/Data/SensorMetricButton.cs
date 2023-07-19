namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric button
/// </summary>
[DataContract]
public class SensorMetricButton
{
	[DataMember(Name = "pressType")]
	public string PressType { get; set; } = string.Empty;
}