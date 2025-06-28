namespace Meraki.Api.Data;

/// <summary>
/// Counts of the result
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorsByDeviceResponseMetadataCounts
{
	/// <summary>
	/// Meta data of the items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationSwitchPortsMirrorsByDeviceResponseMetadataCountsItems Items { get; set; } = new();
}