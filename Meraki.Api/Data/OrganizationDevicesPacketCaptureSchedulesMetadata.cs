namespace Meraki.Api.Data;

/// <summary>
/// Meta data details about result
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureSchedulesMetadata
{
	/// <summary>
	/// Counts of the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationDevicesPacketCaptureSchedulesMetadataCounts Counts { get; set; } = new();
}
