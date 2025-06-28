namespace Meraki.Api.Data;

/// <summary>
/// Meta data of the items
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesMetadataCountsItems
{
	/// <summary>
	/// Remaining number of packet capture files
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// Total number of packet capture files
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}