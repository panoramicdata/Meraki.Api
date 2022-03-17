using System.Diagnostics;

namespace Meraki.Api.Data;

/// <summary>
/// A Device
/// </summary>
[DataContract]
[DebuggerDisplay("{" + nameof(Serial) + "} ({" + nameof(Model) + "} - {" + nameof(Name) + "})")]
public class Device : NamedItem
{
	public const int MaxAddressLength = 255;

	/// <summary>
	/// The latitude of a device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lat")]
	public float Latitude { get; set; }

	/// <summary>
	/// The longitude of a device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lng")]
	public float Longitude { get; set; }

	/// <summary>
	/// The address of a device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

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
	public List<string> Tags { get; set; } = new();

	/// <summary>
	/// ReadOnly: The Network Id of a device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// ReadOnly: The Serial of a device
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// ReadOnly: The model of a device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// ReadOnly: The MAC address of a device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Readonly: The LAN IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lanIp")]
	public string LanIp { get; set; } = string.Empty;

	/// <summary>
	/// Readonly: The beacon ID parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "beaconIdParams")]
	public BeaconIdParams BeaconIdParams { get; set; } = new BeaconIdParams();

	/// <summary>
	/// When the configuration was last updated
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "configurationUpdatedAt")]
	public DateTime ConfigurationUpdatedAt { get; set; }

	/// <summary>
	/// Readonly: The firmware version of a device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "firmware")]
	public string Firmware { get; set; } = string.Empty;

	/// <summary>
	/// The floor plan to associate to this device. null disassociates the device from the floorplan.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[ApiForeignKey(typeof(FloorPlan))]
	[DataMember(Name = "floorPlanId")]
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public string? FloorPlanId { get; set; }

	/// <summary>
	/// The ID of a switch profile to bind to the device (for available switch profiles, see the 'Switch Profiles' endpoint).
	/// Use null to unbind the switch device from the current profile. For a device to be bindable to a switch profile,
	/// it must (1) be a switch, and (2) belong to a network that is bound to a configuration template.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[ApiForeignKey(typeof(SwitchProfile))]
	[DataMember(Name = "switchProfileId")]
	public string? SwitchProfileId { get; set; }

	/// <summary>
	/// Readonly: URL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Readonly: Wireless MAC address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wirelessMac")]
	public string WirelessMac { get; set; } = string.Empty;

	/// <summary>
	/// Readonly: WAN 1 IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wan1Ip")]
	public string? Wan1Ip { get; set; }

	/// <summary>
	/// Readonly: WAN 2 IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wan2Ip")]
	public string? Wan2Ip { get; set; }

	/// <summary>
	/// Whether or not to set the latitude and longitude of a device based on the new address. Only applies when lat and lng are not specified.
	/// Only used when sending updates
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "moveMapMarker")]
	public bool? MoveMapMarker { get; set; }
}
