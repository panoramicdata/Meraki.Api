namespace Meraki.Api.Data;

/// <summary>
/// Devices wireless radio AFC position put request data
/// </summary>
[DataContract]
public class DevicesWirelessRadioAfcPositionPutRequest
{
	/// <summary>
	/// Elevation attributes
	/// </summary>
	[DataMember(Name = "elevation")]
	public DevicesWirelessRadioAfcPositionElevation? Elevation { get; set; }

	/// <summary>
	/// GPS attributes
	/// </summary>
	[DataMember(Name = "gps")]
	public DevicesWirelessRadioAfcPositionGps? Gps { get; set; }
}
