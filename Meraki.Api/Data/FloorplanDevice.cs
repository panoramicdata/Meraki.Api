namespace Meraki.Api.Data;

/// <summary>
/// A Device on a floorplan
/// </summary>
[DataContract]
[ApiAccessReadOnlyClass]
public class FloorplanDevice : NamedItem
{
	public static int MaxAddressLength = 255;

	/// <summary>
	/// The latitude of a device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lat")]
	public double? Latitude { get; set; }

	/// <summary>
	/// The longitude of a device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lng")]
	public double? Longitude { get; set; }

	/// <summary>
	/// The address of a device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "address")]
	public string? Address { get; set; }

	/// <summary>
	/// The notes for the device. String. Limited to 255 characters.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>
	/// The list of tags of a device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// ReadOnly: The Network Id of a device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// ReadOnly: The Serial of a device
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// ReadOnly: The model of a device
	/// </summary>
	[ApiForeignKey(typeof(Device))] // Not strictly true, but it's the closest we have and we want to record the Model as useful information
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string? Model { get; set; }

	/// <summary>
	/// ReadOnly: The MAC address of a device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// Readonly: The LAN IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lanIp")]
	public string? LanIp { get; set; }

	/// <summary>
	/// Readonly: The firmware version of a device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "firmware")]
	public string? Firmware { get; set; }

	/// <summary>
	/// productType
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "productType")]
	public string? ProductType { get; set; }
}
