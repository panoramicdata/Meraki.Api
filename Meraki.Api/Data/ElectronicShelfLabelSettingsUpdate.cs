namespace Meraki.Api.Data;

/// <summary>
/// Electronic Shelf Label Settings of a device update request
/// </summary>
public class ElectronicShelfLabelSettingsUpdate
{
	/// <summary>
	/// Desired ESL channel for the device, or 'Auto' (case insensitive) to use the recommended channel
	/// </summary>
	[DataMember(Name = "channel")]
	public string Channel { get; internal set; } = string.Empty;

	/// <summary>
	/// Turn ESL features on and off for this device
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; internal set; }
}
