namespace Meraki.Api.Data;

/// <summary>
/// Organization Zigbee Device Update Request
/// </summary>
[DataContract]
public class OrganizationZigbeeDeviceUpdateRequest
{
	/// <summary>
	/// The new channel for the zigbee device
	/// </summary>
	[DataMember(Name = "channel")]
	public string? Channel { get; set; }

	/// <summary>
	/// Parameter to enroll or unenroll the zigbee devices
	/// </summary>
	[DataMember(Name = "enrolled")]
	public bool Enrolled { get; set; }
}
