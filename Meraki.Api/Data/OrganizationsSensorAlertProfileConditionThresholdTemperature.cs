namespace Meraki.Api.Data;

/// <summary>
/// Temperature threshold. One of 'celsius', 'fahrenheit', or 'quality' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdTemperature
{
	/// <summary>
	/// Alerting threshold as a qualitative temperature level.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "quality")]
	public AlertingQuality Quality { get; set; }

	/// <summary>
	/// Alerting threshold in degrees Celsius.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "celsius")]
	public int Celsius { get; set; }

	/// <summary>
	/// Alerting threshold in degrees Fahrenheit.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fahrenheit")]
	public int Fahrenheit { get; set; }
}