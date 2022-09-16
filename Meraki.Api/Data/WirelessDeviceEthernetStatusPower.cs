namespace Meraki.Api.Data;

/// <summary>
/// Power Details Object
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatusPower
{
	/// <summary>
	/// The PoE Power mode for the AP. Can be 'full' or 'low'
	/// </summary>
	[DataMember(Name = "mode")]
	public WirelessDeviceEthernetStatusPowerMode Mode { get; set; }

	/// <summary>
	/// AC power details object
	/// </summary>
	[DataMember(Name = "ac")]
	public WirelessDeviceEthernetStatusPowerAc Ac { get; set; } = new();

	/// <summary>
	/// PoE power details object
	/// </summary>
	[DataMember(Name = "poe")]
	public WirelessDeviceEthernetStatusPowerPoe Poe { get; set; } = new();
}
