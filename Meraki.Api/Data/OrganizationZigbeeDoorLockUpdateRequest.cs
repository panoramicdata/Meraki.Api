namespace Meraki.Api.Data;

/// <summary>
/// Organization Zigbee Door Lock Update Request
/// </summary>
[DataContract]
public class OrganizationZigbeeDoorLockUpdateRequest
{
	/// <summary>
	/// Door lock name to update
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
