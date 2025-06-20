namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectNetworkDevice
/// </summary>
[DataContract]
public class SecureConnectNetworkDevice
{
	/// <summary>
	/// The ID of the organization.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationId")]
	public int organizationId { get; set; }

	/// <summary>
	/// The unique global identifier for this traffic source (origin). Use the origin ID to manage the device.The origin ID is not used by the device.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "originId")]
	public int OriginId { get; set; }

	/// <summary>
	/// The time when the device was created. Specify an ISO 8601-formatted timestamp.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// The unique identifier for the specific network device. Insert the identifier into the EDNS packets.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceId")]
	public string DeviceId { get; set; } = string.Empty;

	/// <summary>
	/// A descriptive unique identifier for the device. Not used by the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceKey")]
	public string DeviceKey { get; set; } = string.Empty;

	/// <summary>
	/// The name of the device.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The serial number of the device.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "serialNumber")]
	public string SerialNumber { get; set; } = string.Empty;
}
