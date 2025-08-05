namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Task Create Request
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskCreateRequest
{
	/// <summary>
	/// Optional parameter to validate authorization by network access
	/// </summary>
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// Type of task to enqueue. It can be one of: ["analysis", "chain_of_thought", "summary", "highlighting", "title"]
	/// </summary>
	[DataMember(Name = "task")]
	public TaskType Task { get; set; }
}
