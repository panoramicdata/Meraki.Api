namespace Meraki.Api.Data;

/// <summary>
/// Object containing packet counts
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileCountsPackets
{
	/// <summary>
	/// Number of packets in the packet capture. NOTE: For MS Switches, packetCount is not populated with valid data.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}