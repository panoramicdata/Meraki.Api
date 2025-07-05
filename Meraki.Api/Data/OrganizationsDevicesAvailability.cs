namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Availability
/// </summary>
[DataContract]
public class OrganizationsDevicesAvailability
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
	/// Status of the device. Possible values are: online, alerting, offline, dormant.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public DeviceStatus Status { get; set; }

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
	public OrganizationsDevicesAvailabilityNetwork Network { get; set; } = new();
}
