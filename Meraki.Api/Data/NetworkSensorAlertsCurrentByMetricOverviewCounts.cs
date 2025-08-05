namespace Meraki.Api.Data;

/// <summary>
/// Counts of currently alerting sensors, aggregated by alerting metric
/// </summary>
[DataContract]
public class NetworkSensorAlertsCurrentByMetricOverviewCounts
{
	/// <summary>
	/// Number of sensors that are currently alerting due to apparent power readings 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "apparentPower")]
	public int ApparentPower { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to CO2 readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "co2")]
	public int Co2 { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to electrical current readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "current")]
	public int Current { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to an open door
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "door")]
	public int Door { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to frequency readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "frequency")]
	public int Frequency { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to humidity readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "humidity")]
	public int Humidity { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to indoor air quality readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "indoorAirQuality")]
	public int IndoorAirQuality { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to PM2.5 readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "pm25")]
	public int Pm25 { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to power factor readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "powerFactor")]
	public int PowerFactor { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to real power readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "realPower")]
	public int RealPower { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to temperature readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "temperature")]
	public int Temperature { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to TVOC readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tvoc")]
	public int Tvoc { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to an upstream power outage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upstreamPower")]
	public int UpstreamPower { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to voltage readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "voltage")]
	public int Voltage { get; set; }

	/// <summary>
	/// Number of sensors that are currently alerting due to the presence of water
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "water")]
	public int Water { get; set; }

	/// <summary>
	/// Object containing the number of sensors that are currently alerting due to noise readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "noise")]
	public NetworkSensorAlertsCurrentByMetricOverviewCountsNoise Noise { get; set; } = new();
}
