namespace Meraki.Api.Data;

/// <summary>
/// DevicesWirelessRadioAfcPositionElevation
/// </summary>
public class DevicesWirelessRadioAfcPositionElevation
{
	/// <summary>
	/// The accuracy of this device's elevation in meters.
	/// </summary>
	public int? Uncertainty { get; set; }

	/// <summary>
	/// Heigth from ground in meters
	/// </summary>
	public int? Height { get; set; }
}