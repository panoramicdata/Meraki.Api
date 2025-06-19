namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Local Profiles Assignments Response
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationApplianceDnsLocalProfilesAssignmentsResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of local DNS profile assignment
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationApplianceDnsLocalProfilesAssignmentsDataItem> Items { get; set; } = [];
}
