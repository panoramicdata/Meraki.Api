namespace Meraki.Api.Data;

/// <summary>
/// Door Locks Stats
/// </summary>
[DataContract]
public class OrganizationZigbeeDoorLocks
{
	/// <summary>
	/// Status Stats
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byStatus")]
	public OrganizationZigbeeByStatus ByStatus { get; set; } = new();
}
