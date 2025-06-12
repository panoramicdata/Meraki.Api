namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Packet Capture Capture Download URL
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCaptureDownloadUrl
{
	/// <summary>
	/// Id of packet capture file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "captureId")]
	public string CaptureId { get; set; } = string.Empty;

	/// <summary>
	/// Download URL of captured packet file -- Depracated
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downloadUrl")]
	public string DownloadUrl { get; set; } = string.Empty;

	/// <summary>
	/// Download URL of captured packet file
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}
