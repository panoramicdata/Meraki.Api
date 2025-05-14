namespace Meraki.Api.Data;

/// <summary>
/// Organization Zigbee Disenrollment Request
/// </summary>
[DataContract]
public class OrganizationZigbeeDisenrollmentRequest
{
	/// <summary>
	/// A list of Meraki doorlock ids to disenroll from the device
	/// </summary>
	[DataMember(Name = "doorLockIds")]
	public List<string>? DoorLockIds { get; set; }
}
