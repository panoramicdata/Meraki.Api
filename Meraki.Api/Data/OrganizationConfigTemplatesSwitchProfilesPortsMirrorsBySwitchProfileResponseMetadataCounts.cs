namespace Meraki.Api.Data;

/// <summary>
/// Counts of the result
/// </summary>
[DataContract]
public class OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseMetadataCounts
{
	/// <summary>
	/// Meta data of the items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponseMetadataCountsItems Items { get; set; } = new();
}
