namespace Meraki.Api.Data;

/// <summary>
/// Power status for wireless devices
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatus : NamedIdentifiedItem
{
	/// <summary>
	/// Aggregation details object
	/// </summary>
	[DataMember(Name = "aggregation")]
	public WirelessDeviceEthernetStatusAggregation? Aggregation { get; set; }

	/// <summary>
	/// Network details object
	/// </summary>
	[DataMember(Name = "network")]
	public WirelessDeviceEthernetStatusNetwork Network { get; set; } = new();

	/// <summary>
	/// Power details object
	/// </summary>
	[DataMember(Name = "power")]
	public WirelessDeviceEthernetStatusPower? Power { get; set; }

	/// <summary>
	/// List of port details
	/// </summary>
	[DataMember(Name = "port")]
	public List<WirelessDeviceEthernetStatusPort> Ports { get; set; } = new();
}
