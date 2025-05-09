namespace Meraki.Api.Data;

/// <summary>
/// External antenna attributes
/// </summary>
[DataContract]
public class DevicesWirelessRadioAfcPositionGpsAntenna
{
	/// <summary>
	/// Length of the attached cable
	/// </summary>
	[DataMember(Name = "cableLength")]
	public int? CableLength { get; set; }
}