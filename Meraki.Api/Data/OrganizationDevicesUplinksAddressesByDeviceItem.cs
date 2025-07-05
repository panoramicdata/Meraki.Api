namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Uplinks Addresses By Device Item
/// </summary>
[DataContract]
public class OrganizationDevicesUplinksAddressesByDeviceItem
{
	/// <summary>
	/// The device MAC address.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The device name.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Device product type. enum = ["appliance", "camera", "cellularGateway", "secureConnect", "sensor", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public string ProductType { get; set; } = string.Empty;

	/// <summary>
	/// The device serial number.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// List of custom tags for the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Network info.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationDevicesUplinksAddressesByDeviceItemNetwork Network { get; set; } = new();

	/// <summary>
	/// List of device uplink addresses information.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uplinks")]
	public List<OrganizationDevicesUplinksAddressesByDeviceItemUplink> Uplinks { get; set; } = [];
}
