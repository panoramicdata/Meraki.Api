namespace Meraki.Api.Data;

/// <summary>
/// GPS attributes
/// </summary>
[DataContract]
public class DevicesWirelessRadioAfcPositionGps
{
	/// <summary>
	/// External antenna attributes
	/// </summary>
	[DataMember(Name = "antenna")]
	public DevicesWirelessRadioAfcPositionGpsAntenna? Antenna { get; set; }
}