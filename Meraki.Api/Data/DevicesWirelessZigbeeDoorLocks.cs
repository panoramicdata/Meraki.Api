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
	[ApiAccess(ApiAccess.Read)]
	public string? DoorLockId { get; set; }

	/// <summary>
	/// Date time the door lock was enrolled
	/// </summary>
	[DataMember(Name = "enrolledAt")]
	[ApiAccess(ApiAccess.Read)]
	public string? EnrolledAt { get; set; }

	/// <summary>
	/// The Door lock unique identifier per network
	/// </summary>
	[DataMember(Name = "eui64")]
	[ApiAccess(ApiAccess.Read)]
	public string? Eui64 { get; set; }

	/// <summary>
	/// Date time the door lock last send any messages
	/// </summary>
	[DataMember(Name = "lastSeenAt")]
	[ApiAccess(ApiAccess.Read)]
	public string? LastSeenAt { get; set; }

	/// <summary>
	/// The Door lock L quality index
	/// </summary>
	[DataMember(Name = "lqi")]
	[ApiAccess(ApiAccess.Read)]
	public string? Lqi { get; set; }

	/// <summary>
	/// The Door lock name
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Name { get; set; }

	/// <summary>
	/// The Door lock received signal strength indicator
	/// </summary>
	[DataMember(Name = "rssi")]
	[ApiAccess(ApiAccess.Read)]
	public string? Rssi { get; set; }

	/// <summary>
	/// The Door lock short ID
	/// </summary>
	[DataMember(Name = "shortId")]
	[ApiAccess(ApiAccess.Read)]
	public string? ShortId { get; set; }

	/// <summary>
	/// The Door lock status
	/// </summary>
	[DataMember(Name = "status")]
	[ApiAccess(ApiAccess.Read)]
	public DevicesWirelessZigbeeDoorLocksStatus? Status { get; set; }

	/// <summary>
	/// Gateway this door lock is connected to
	/// </summary>
	[DataMember(Name = "gateway")]
	[ApiAccess(ApiAccess.Read)]
	public DevicesWirelessZigbeeGateway? Gateway { get; set; }

	/// <summary>
	/// Network this door lock is connected to
	/// </summary>
	[DataMember(Name = "network")]
	[ApiAccess(ApiAccess.Read)]
	public DevicesWirelessZigbeeNetwork? Network { get; set; }
}