namespace Meraki.Api.Data;

/// <summary>
/// Object containing counts
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileCounts
{
	/// <summary>
	/// Object containing packet counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "packets")]
	public OrganizationDevicesPacketCaptureFileCountsPackets Packets { get; set; } = new();
}
