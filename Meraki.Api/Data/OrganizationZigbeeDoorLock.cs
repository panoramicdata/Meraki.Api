namespace Meraki.Api.Data;

/// <summary>
/// Door Lock
/// </summary>
[DataContract]
public class OrganizationZigbeeDoorLock
{
	/// <summary>
	/// Meraki Doorlock Identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "doorLockId")]
	public string DoorLockId { get; set; } = string.Empty;

	/// <summary>
	/// Disenrollment Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}