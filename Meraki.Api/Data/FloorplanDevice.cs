namespace Meraki.Api.Data;

/// <summary>
/// A Device on a floorplan
/// </summary>
[DataContract]
[ApiAccessReadOnlyClass]
public class FloorplanDevice : NamedItem
{
	/// <summary>
	/// The maximum length of a device address
	/// </summary>
	public const int MaxAddressLength = 255;

	/// <summary>
	/// The latitude of a device
	/// </summary>
	[DataMember(Name = "lat")]
	public double? Latitude { get; set; }

	/// <summary>
	/// The longitude of a device
	/// </summary>
	[DataMember(Name = "lng")]
	public double? Longitude { get; set; }

	/// <summary>
	/// The address of a device
	/// </summary>
	[DataMember(Name = "address")]
	public string? Address { get; set; }

	/// <summary>
	/// The notes for the device. String. Limited to 255 characters.
	/// </summary>
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>
	/// The list of tags of a device
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// ReadOnly: The Network Id of a device
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// ReadOnly: The Serial of a device
	/// </summary>
	[ApiKey]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// ReadOnly: The model of a device
	/// </summary>
	[ApiForeignKey(typeof(Device))] // Not strictly true, but it's the closest we have and we want to record the Model as useful information
	[DataMember(Name = "model")]
	public string? Model { get; set; }

	/// <summary>
	/// ReadOnly: switchProfileId
	/// </summary>
	[DataMember(Name = "switchProfileId")]
	public string? SwitchProfileId { get; set; }

	/// <summary>
	/// ReadOnly: The MAC address of a device
	/// </summary>
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// Readonly: The WAN1 IP address
	/// </summary>
	[DataMember(Name = "wan1Ip")]
	public string? Wan1Ip { get; set; }

	/// <summary>
	/// Readonly: The WAN2 IP address
	/// </summary>
	[DataMember(Name = "wan2Ip")]
	public string? Wan2Ip { get; set; }

	/// <summary>
	/// Readonly: The LAN IP address
	/// </summary>
	[DataMember(Name = "lanIp")]
	public string? LanIp { get; set; }

	/// <summary>
	/// Readonly: The url to the device managment interface
	/// </summary>
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// Readonly: beaconIdParams - Undocumented
	/// </summary>
	[DataMember(Name = "beaconIdParams")]
	public FloorplanDeviceBeaconIdParams? BeaconIdParams { get; set; }

	/// <summary>
	/// Readonly: bleParams - Undocumented
	/// </summary>
	[DataMember(Name = "bleParams")]
	public FloorplanDeviceBleParams? BleParams { get; set; }

	/// <summary>
	/// Readonly: The firmware version of a device
	/// </summary>
	[DataMember(Name = "firmware")]
	public string? Firmware { get; set; }

	/// <summary>
	/// productType
	/// </summary>
	[DataMember(Name = "productType")]
	public string? ProductType { get; set; }

	/// <summary>
	/// ReadOnly: The ID of the Floorplan on which this device is placed
	/// </summary>
	[ApiForeignKey(typeof(FloorPlan))]
	[DataMember(Name = "floorplanId")]
	public string? FloorplanId { get; set; }

	/// <summary>
	/// wirelessMac
	/// </summary>
	[DataMember(Name = "wirelessMac")]
	public string? WirelessMac { get; set; }

	/// <summary>
	/// Device details
	/// </summary>
	[DataMember(Name = "details")]
	public List<DeviceDetail>? Details { get; set; }

	/// <summary>
	/// Imei
	/// </summary>
	[DataMember(Name = "imei")]
	public string? Imei { get; set; }

	/// <summary>
	/// Height information for the device
	/// </summary>
	[DataMember(Name = "height")]
	public FloorplanDeviceHeight? Height { get; set; }
}
