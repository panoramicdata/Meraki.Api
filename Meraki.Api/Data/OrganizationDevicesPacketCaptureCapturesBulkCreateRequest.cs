namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Captures Bulk Create Request
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesBulkCreateRequest
{
	/// <summary>
	/// Duration of the capture in seconds
	/// </summary>
	[DataMember(Name = "duration")]
	public int? Duration { get; set; }

	/// <summary>
	/// Filter expression for the capture
	/// </summary>
	[DataMember(Name = "filterExpression")]
	public string? FilterExpression { get; set; }

	/// <summary>
	/// Name of packet capture file
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Reason for capture
	/// </summary>
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>
	/// Device details (maximum of 20 devices allowed)
	/// </summary>
	[DataMember(Name = "devices")]
	public List<OrganizationDevicesPacketCaptureCapturesBulkCreateDevice> Devices { get; set; } = [];
}
