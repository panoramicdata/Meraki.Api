namespace Meraki.Api.Data;

/// <summary>
/// Device from the packet capture analysis result
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureTaskDetailedSummaryDevice
{
	/// <summary>
	/// Device names
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Meraki Dashboard url for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}