namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Power Module Status
/// </summary>
[DataContract]
public class OrganizationDevicesPowerModuleStatus
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
	[ApiAccess(ApiAccess.Read)]
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
	public OrganizationDevicesPowerModuleStatusNetwork Network { get; set; } = new();

	/// <summary>
	/// Information for the device's AC power supplies.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "slots")]
	public List<OrganizationDevicesPowerModuleStatusSlot> Slots { get; set; } = [];
}
