namespace Meraki.Api.Data;

/// <summary>
/// The profile the network is attached to
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentProfile
{
	/// <summary>
	/// ID of the profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}