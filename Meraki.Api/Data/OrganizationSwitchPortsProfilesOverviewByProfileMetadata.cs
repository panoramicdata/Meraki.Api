namespace Meraki.Api.Data;

/// <summary>
/// Meta data details about result
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesOverviewByProfileMetadata
{
	/// <summary> 
	/// Counts of the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchPortsProfilesOverviewByProfileMetadataCounts Counts { get; set; } = new();
}
