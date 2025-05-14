namespace Meraki.Api.Data;

/// <summary>
/// Organization Zigbee Door Lock Detailed
/// </summary>
[DataContract]
public class OrganizationZigbeeDoorLockDetailed
{
	/// <summary>
	/// The Door Lock ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "doorLockId")]
	public string DoorLockId { get; set; } = string.Empty;

	/// <summary>
	/// Date time the door lock was enrolled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enrolledAt")]
	public string EnrolledAt { get; set; } = string.Empty;

	/// <summary>
	/// The Door lock unique identifier per network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "eui64")]
	public string Eui64 { get; set; } = string.Empty;

	/// <summary>
	/// Date time the door lock last send any messages
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastSeenAt")]
	public string LastSeenAt { get; set; } = string.Empty;

	/// <summary>
	/// The Door lock L quality index
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lqi")]
	public string Lqi { get; set; } = string.Empty;

	/// <summary>
	/// The Door lock name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The Door lock received signal strength indicator
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rssi")]
	public string Rssi { get; set; } = string.Empty;

	/// <summary>
	/// The Door lock short ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "shortId")]
	public string ShortId { get; set; } = string.Empty;

	/// <summary>
	/// The Door lock status, either online or offline.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Gateway this door lock is connected to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "gateway")]
	public OrganizationZigbeeDoorLockDetailedGateway Gateway { get; set; } = new();

	/// <summary>
	/// Network this door lock is connected to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationZigbeeDoorLockDetailedNetwork Network { get; set; } = new();
}
