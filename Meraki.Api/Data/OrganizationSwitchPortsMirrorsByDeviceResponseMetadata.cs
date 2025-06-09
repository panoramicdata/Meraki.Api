namespace Meraki.Api.Data;

/// <summary>
/// Meta data details about result
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByDeviceResponseMetadata
{
	/// <summary>
	/// Counts of the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchPortsMirrorsByDeviceResponseMetadataCounts Counts { get; set; } = new();
}
