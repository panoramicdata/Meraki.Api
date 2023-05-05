namespace Meraki.Api.Data;

[DataContract]
public class DeviceProvisioningStatus
{
	/// <summary>
	/// The device MAC address.
	/// </summary>
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// The device name.
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Device product type.
	/// </summary>
	[DataMember(Name = "productType")]
	public string? ProductType { get; set; }

	/// <summary>
	/// The device serial number.
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// The device provisioning status. Possible statuses: unprovisioned, incomplete, complete.
	/// </summary>
	[DataMember(Name = "status")]
	public DeviceProvisioningStatusStatus? Status { get; set; }

	/// <summary>
	/// List of custom tags for the device.
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// Network info
	/// </summary>
	[DataMember(Name = "network")]
	public DeviceProvisioningStatusNetwork? Network { get; set; }
}
