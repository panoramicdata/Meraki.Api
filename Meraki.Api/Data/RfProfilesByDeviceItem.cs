namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device Item
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class RfProfilesByDeviceItem
{
	/// <summary>
	/// Model number of the device.
	/// </summary>
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Name of the device.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Unique serial number for device.
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Information regarding the network the device belongs to.
	/// </summary>
	[DataMember(Name = "network")]
	public RfProfilesByDeviceItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Information regarding the RF Profile of the device.
	/// </summary>
	[DataMember(Name = "rfProfile")]
	public RfProfilesByDeviceItemRfProfile RfProfile { get; set; } = new();
}
