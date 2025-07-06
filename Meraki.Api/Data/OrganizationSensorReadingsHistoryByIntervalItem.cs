namespace Meraki.Api.Data;

/// <summary>
/// Organization Sensor Readings History By Interval Item
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItem
{
	/// <summary>
	/// Ending time of the interval, in ISO8601 format.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Type of sensor reading. enum = ["apparentPower", "battery", "button", "co2", "current", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "metric")]
	public string Metric { get; set; } = string.Empty;

	/// <summary>
	/// Model of the sensor that took the reading.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Serial number of the sensor that took the reading.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Starting time of the interval, in ISO8601 format.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Reading information over the interval for the 'apparentPower' metric. This will only be present if the 'metric' property equals 'apparentPower'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "apparentPower")]
	public OrganizationSensorReadingsHistoryByIntervalItemApparentPower ApparentPower { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'battery' metric. This will only be present if the 'metric' property equals 'battery'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "battery")]
	public OrganizationSensorReadingsHistoryByIntervalItemBattery Battery { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'button' metric. This will only be present if the 'metric' property equals 'button'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "button")]
	public OrganizationSensorReadingsHistoryByIntervalItemButton Button { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'co2' metric. This will only be present if the 'metric' property equals 'co2'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "co2")]
	public OrganizationSensorReadingsHistoryByIntervalItemCo2 Co2 { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'current' metric. This will only be present if the 'metric' property equals 'current'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "current")]
	public OrganizationSensorReadingsHistoryByIntervalItemCurrent Current { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'door' metric. This will only be present if the 'metric' property equals 'door'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "door")]
	public OrganizationSensorReadingsHistoryByIntervalItemDoor Door { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'energy' metric. This will only be present if the 'metric' property equals 'energy'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "energy")]
	public OrganizationSensorReadingsHistoryByIntervalItemEnergy Energy { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'frequency' metric. This will only be present if the 'metric' property equals 'frequency'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "frequency")]
	public OrganizationSensorReadingsHistoryByIntervalItemFrequency Frequency { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'humidity' metric. This will only be present if the 'metric' property equals 'humidity'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "humidity")]
	public OrganizationSensorReadingsHistoryByIntervalItemHumidity Humidity { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'indoorAirQuality' metric. This will only be present if the 'metric' property equals 'indoorAirQuality'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "indoorAirQuality")]
	public OrganizationSensorReadingsHistoryByIntervalItemIndoorAirQuality IndoorAirQuality { get; set; } = new();

	/// <summary>
	/// Network to which the sensor belongs.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationSensorReadingsHistoryByIntervalItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'noise' metric. This will only be present if the 'metric' property equals 'noise'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "noise")]
	public OrganizationSensorReadingsHistoryByIntervalItemNoise Noise { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'pm25' metric. This will only be present if the 'metric' property equals 'pm25'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "pm25")]
	public OrganizationSensorReadingsHistoryByIntervalItemPm25 Pm25 { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'powerFactor' metric. This will only be present if the 'metric' property equals 'powerFactor'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "powerFactor")]
	public OrganizationSensorReadingsHistoryByIntervalItemPowerFactor PowerFactor { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'realPower' metric. This will only be present if the 'metric' property equals 'realPower'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "realPower")]
	public OrganizationSensorReadingsHistoryByIntervalItemRealPower RealPower { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'temperature' metric. This will only be present if the 'metric' property equals 'temperature'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "temperature")]
	public OrganizationSensorReadingsHistoryByIntervalItemTemperature Temperature { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'tvoc' metric. This will only be present if the 'metric' property equals 'tvoc'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tvoc")]
	public OrganizationSensorReadingsHistoryByIntervalItemTvoc Tvoc { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'voltage' metric. This will only be present if the 'metric' property equals 'voltage'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "voltage")]
	public OrganizationSensorReadingsHistoryByIntervalItemVoltage Voltage { get; set; } = new();

	/// <summary>
	/// Reading information over the interval for the 'water' metric. This will only be present if the 'metric' property equals 'water'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "water")]
	public OrganizationSensorReadingsHistoryByIntervalItemWater Water { get; set; } = new();
}
