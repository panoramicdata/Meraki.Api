namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device Item
/// </summary>
[DataContract]
public class RfProfilesByDeviceItem
{
	/// <summary>
	/// Model number of the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Name of the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;


	/// <summary>
	/// Unique serial number for device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Information regarding the network the device belongs to.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public RfProfilesByDeviceItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Information regarding the RF Profile of the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rfProfile")]
	public RfProfilesByDeviceItemRfProfile RfProfile { get; set; } = new();
}
