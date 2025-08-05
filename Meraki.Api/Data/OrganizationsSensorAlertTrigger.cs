namespace Meraki.Api.Data;

/// <summary>
/// The sensor reading that triggered the alert.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTrigger
{
	/// <summary>
	/// Type of sensor reading. enum = ["apparentPower", "co2", "current", "door", "frequency", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "metric")]
	public string Metric { get; set; } = string.Empty;

	/// <summary>
	/// Time at which the reading occurred, in ISO8601 format.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Reading for the 'apparentPower' metric. This will only be present if the 'metric' property equals 'apparentPower'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "apparentPower")]
	public OrganizationsSensorAlertTriggerApparentPower ApparentPower { get; set; } = new();

	/// <summary>
	/// Reading for the 'co2' metric. This will only be present if the 'metric' property equals 'co2'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "co2")]
	public OrganizationsSensorAlertTriggerCo2 Co2 { get; set; } = new();

	/// <summary>
	/// Reading for the 'current' metric. This will only be present if the 'metric' property equals 'current'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "current")]
	public OrganizationsSensorAlertTriggerCurrent Current { get; set; } = new();

	/// <summary>
	/// Reading for the 'door' metric. This will only be present if the 'metric' property equals 'door'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "door")]
	public OrganizationsSensorAlertTriggerDoor Door { get; set; } = new();

	/// <summary>
	/// Reading for the 'frequency' metric. This will only be present if the 'metric' property equals 'frequency'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "frequency")]
	public OrganizationsSensorAlertTriggerFrequency Frequency { get; set; } = new();

	/// <summary>
	/// Reading for the 'humidity' metric. This will only be present if the 'metric' property equals 'humidity'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "humidity")]
	public OrganizationsSensorAlertTriggerHumidity Humidity { get; set; } = new();

	/// <summary>
	/// Reading for the 'indoorAirQuality' metric. This will only be present if the 'metric' property equals 'indoorAirQuality'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "indoorAirQuality")]
	public OrganizationsSensorAlertTriggerIndoorAirQuality IndoorAirQuality { get; set; } = new();

	/// <summary>
	/// Reading for the 'noise' metric. This will only be present if the 'metric' property equals 'noise'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "noise")]
	public OrganizationsSensorAlertTriggerNoise Noise { get; set; } = new();

	/// <summary>
	/// Reading for the 'pm25' metric. This will only be present if the 'metric' property equals 'pm25'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "pm25")]
	public OrganizationsSensorAlertTriggerPm25 Pm25 { get; set; } = new();

	/// <summary>
	/// Reading for the 'powerFactor' metric. This will only be present if the 'metric' property equals 'powerFactor'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "powerFactor")]
	public OrganizationsSensorAlertTriggerPowerFactor PowerFactor { get; set; } = new();

	/// <summary>
	/// Reading for the 'realPower' metric. This will only be present if the 'metric' property equals 'realPower'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "realPower")]
	public OrganizationsSensorAlertTriggerRealPower RealPower { get; set; } = new();

	/// <summary>
	/// Reading for the 'temperature' metric. This will only be present if the 'metric' property equals 'temperature'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "temperature")]
	public OrganizationsSensorAlertTriggerTemperature Temperature { get; set; } = new();

	/// <summary>
	/// Reading for the 'tvoc' metric. This will only be present if the 'metric' property equals 'tvoc'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tvoc")]
	public OrganizationsSensorAlertTriggerTvoc Tvoc { get; set; } = new();

	/// <summary>
	/// Reading for the 'upstreamPower' metric. This will only be present if the 'metric' property equals 'upstreamPower'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upstreamPower")]
	public OrganizationsSensorAlertTriggerUpstreamPower UpstreamPower { get; set; } = new();

	/// <summary>
	/// Reading for the 'voltage' metric. This will only be present if the 'metric' property equals 'voltage'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "voltage")]
	public OrganizationsSensorAlertTriggerVoltage Voltage { get; set; } = new();

	/// <summary>
	/// Reading for the 'water' metric. This will only be present if the 'metric' property equals 'water'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "water")]
	public OrganizationsSensorAlertTriggerWater Water { get; set; } = new();
}
