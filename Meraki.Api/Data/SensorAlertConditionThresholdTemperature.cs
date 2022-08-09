namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold Temperature
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdTemperature
{
	/// <summary>
	/// Temperature Threshold Quality
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "quality")]
	public SensorAlertConditionThresholdQuality? Quality { get; set; }

	/// <summary>
	/// Temperature Threshold Celsuis
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "celsius")]
	public float? Celsius { get; set; }

	/// <summary>
	/// Temperature Threshold Farenheit
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "farenheit")]
	public float? Farenheit { get; set; }
}