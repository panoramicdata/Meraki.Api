namespace Meraki.Api.Data;

/// <summary>
/// Item containing the network and profile IDs
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentBulkCreateRequestItem
{
	/// <summary>
	/// The network attached to the profile
	/// </summary>
	[DataMember(Name = "network")]
	public OrganizationApplianceDnsSplitProfilesAssignmentNetwork? Network { get; set; }

	/// <summary>
	/// The profile the network is attached to
	/// </summary>
	[DataMember(Name = "profile")]
	public OrganizationApplianceDnsSplitProfilesAssignmentProfile? Profile { get; set; }
}