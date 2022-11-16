namespace Meraki.Api.Data;

/// <summary>
/// Power status for wireless devices
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatus : NamedItem
{
	/// <summary>
	/// The serial number of the AP
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Aggregation details object
	/// </summary>
	[DataMember(Name = "aggregation")]
	public WirelessDeviceEthernetStatusAggregation Aggregation { get; set; } = new();

	/// <summary>
	/// Network details object
	/// </summary>
	[DataMember(Name = "network")]
	public WirelessDeviceEthernetStatusNetwork Network { get; set; } = new();

	/// <summary>
	/// Power details object
	/// </summary>
	[DataMember(Name = "power")]
	public WirelessDeviceEthernetStatusPower Power { get; set; } = new();

	/// <summary>
	/// List of port details
	/// </summary>
	[DataMember(Name = "ports")]
	public List<WirelessDeviceEthernetStatusPort> Ports { get; set; } = new();
}
