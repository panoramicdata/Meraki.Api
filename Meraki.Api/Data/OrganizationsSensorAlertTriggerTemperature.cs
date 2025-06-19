namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'temperature' metric. This will only be present if the 'metric' property equals 'temperature'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerTemperature
{
	/// <summary>
	/// Temperature reading in degrees Celsius. 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "celsius")]
	public int Celsius { get; set; }

	/// <summary>
	/// Temperature reading in degrees Fahrenheit.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fahrenheit")]
	public int Fahrenheit { get; set; }
}