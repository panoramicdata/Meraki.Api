namespace Meraki.Api.Data;

/// <summary>
/// Item containing the network ID and Profile ID
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsBulkCreateRequestDataItem
{
	/// <summary>
	/// The network attached to the profile
	/// </summary>
	[DataMember(Name = "network")]
	public OrganizationApplianceDnsLocalProfilesAssignmentsDataItemNetwork? Network { get; set; }

	/// <summary>
	/// The profile the network is attached to
	/// </summary>
	[DataMember(Name = "profile")]
	public OrganizationApplianceDnsLocalProfilesAssignmentsDataItemProfile? Profile { get; set; }
}