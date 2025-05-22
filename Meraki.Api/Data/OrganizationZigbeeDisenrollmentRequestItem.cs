namespace Meraki.Api.Data;

/// <summary>
/// Disenrollment request parameters
/// </summary>
[DataContract]
public class OrganizationZigbeeDisenrollmentRequestItem
{
	/// <summary>
	/// Array of door lock Ids
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "doorLockIds")]
	public List<string> DoorLockIds { get; set; } = [];
}