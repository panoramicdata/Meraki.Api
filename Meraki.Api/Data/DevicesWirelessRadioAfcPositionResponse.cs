namespace Meraki.Api.Data;

/// <summary>
/// Devices wireless radio AFC position response
/// </summary>
[DataContract]
public class DevicesWirelessRadioAfcPositionResponse
{
	/// <summary>
	/// Name of device
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Serial of device
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Height attributes
	/// </summary>
	[DataMember(Name = "elevation")]
	public DevicesWirelessRadioAfcPositionElevation? Elevation { get; set; }

	/// <summary>
	/// GPS attributes
	/// </summary>
	[DataMember(Name = "gps")]
	public DevicesWirelessRadioAfcPositionGps? Gps { get; set; }

	/// <summary>
	/// Network of device
	/// </summary>
	[DataMember(Name = "network")]
	public DevicesWirelessRadioAfcPositionNetwork? Network { get; set; }
}
