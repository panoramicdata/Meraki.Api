namespace Meraki.Api.Data;

/// <summary>
/// DevicesWirelessRadioAfcPositionElevation
/// </summary>
[DataContract]
public class DevicesWirelessRadioAfcPositionElevation
{
	/// <summary>
	/// The accuracy of this device's elevation in meters.
	/// </summary>
	[DataMember(Name = "uncertainty")]
	public int? Uncertainty { get; set; }

	/// <summary>
	/// Heigth from ground in meters
	/// </summary>
	[DataMember(Name = "height")]
	public int? Height { get; set; }
}