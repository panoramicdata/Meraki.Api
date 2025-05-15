namespace Meraki.Api.Data;

/// <summary>
/// The network attached to the profile
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentNetwork
{
	/// <summary>
	/// ID of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}