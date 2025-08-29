namespace Meraki.Api.Data;

/// <summary>
/// Electronic shelf label mode of the network.
/// </summary>
public enum ElectronicShelfLabelSettingsNetworkMode
{
	/// <summary>
	/// Bluetooth mode.
	/// </summary>
	[EnumMember(Value = "Bluetooth")]
	Bluetooth = 1,

	/// <summary>
	/// High frequency mode.
	/// </summary>
	[EnumMember(Value = "high frequency")]
	HighFrequency
}
