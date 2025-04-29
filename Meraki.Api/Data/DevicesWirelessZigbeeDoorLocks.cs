namespace Meraki.Api.Data;

/// <summary>
/// Door Locks
/// </summary>
[DataContract]
public class DevicesWirelessZigbeeDoorLocks
{
	/// <summary>
	/// The Door Lock ID
	/// </summary>
	[DataMember(Name = "doorLockId")]
	public string? DoorLockId { get; set; }

	/// <summary>
	/// Date time the door lock was enrolled
	/// </summary>
	[DataMember(Name = "enrolledAt")]
	public string? EnrolledAt { get; set; }

	/// <summary>
	/// The Door lock unique identifier per network
	/// </summary>
	[DataMember(Name = "eui64")]
	public string? Eui64 { get; set; }

	/// <summary>
	/// Date time the door lock last send any messages
	/// </summary>
	[DataMember(Name = "lastSeenAt")]
	public string? LastSeenAt { get; set; }

	/// <summary>
	/// The Door lock L quality index
	/// </summary>
	[DataMember(Name = "lqi")]
	public string? Lqi { get; set; }

	/// <summary>
	/// The Door lock name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The Door lock received signal strength indicator
	/// </summary>
	[DataMember(Name = "rssi")]
	public string? Rssi { get; set; }

	/// <summary>
	/// The Door lock short ID
	/// </summary>
	[DataMember(Name = "shortId")]
	public string? ShortId { get; set; }

	/// <summary>
	/// The Door lock status
	/// </summary>
	[DataMember(Name = "status")]
	public DeviceWirelessZigbeeDoorLocksStatus? Status { get; set; }

	/// <summary>
	/// Gateway this door lock is connected to
	/// </summary>
	[DataMember(Name = "gateway")]
	public DevicesWirelessZigbeeGateway? Gateway { get; set; }

	/// <summary>
	/// Network this door lock is connected to
	/// </summary>
	[DataMember(Name = "network")]
	public DevicesWirelessZigbeeNetwork? Network { get; set; }
}