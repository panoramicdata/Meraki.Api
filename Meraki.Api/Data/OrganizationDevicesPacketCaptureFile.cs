namespace Meraki.Api.Data;

/// <summary>
/// Packet capture file
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFile
{
	/// <summary>
	/// Duration of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "duration")]
	public int Duration { get; set; }

	/// <summary>
	/// Id of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "captureId")]
	public string CaptureId { get; set; } = string.Empty;

	/// <summary>
	/// Destination of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "destination")]
	public string Destination { get; set; } = string.Empty;

	/// <summary>
	/// Error log of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "errorMessage")]
	public string ErrorMessage { get; set; } = string.Empty;

	/// <summary>
	/// Filter expression for the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "filterExpression")]
	public string FilterExpression { get; set; } = string.Empty;

	/// <summary>
	/// Interface of the packet capture
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Name of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Ports of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public string Ports { get; set; } = string.Empty;

	/// <summary>
	/// Source of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "process")]
	public string Process { get; set; } = string.Empty;

	/// <summary>
	/// Start time of creation of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Status of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Device(s) of the packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "devices")]
	public List<object> Devices { get; set; } = [];

	/// <summary>
	/// Admin who created the packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "admin")]
	public OrganizationDevicesPacketCaptureFileAdmin Admin { get; set; } = new();

	/// <summary>
	/// Client of the packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "client")]
	public OrganizationDevicesPacketCaptureFileClient Client { get; set; } = new();

	/// <summary>
	/// Object containing counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationDevicesPacketCaptureFileCounts Counts { get; set; } = new();

	/// <summary>
	/// One of the device(s) of the packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "device")]
	public OrganizationDevicesPacketCaptureFileDevice Device { get; set; } = new();

	/// <summary>
	/// Object containing information about the file
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "file")]
	public OrganizationDevicesPacketCaptureFileFile File { get; set; } = new();

	/// <summary>
	/// Network of the packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationDevicesPacketCaptureFileNetwork Network { get; set; } = new();

	/// <summary>
	/// Array of device specific details
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "details")]
	public List<OrganizationDevicesPacketCaptureFileDetail> Details { get; set; } = [];
}
