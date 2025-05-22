namespace Meraki.Api.Data;

/// <summary>
/// Stats
/// </summary>
[DataContract]
public class OrganizationZigbeeCounts
{
	/// <summary>
	/// Door Locks Stats 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "doorLocks")]
	public OrganizationZigbeeDoorLocks DoorLocks { get; set; } = new();
}
