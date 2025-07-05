namespace Meraki.Api.Data;

/// <summary>
/// Meta data details about result
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureCapturesMetadata
{
	/// <summary>
	/// Counts of the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationDevicesPacketCaptureCapturesMetadataCounts Counts { get; set; } = new();
}
