namespace Meraki.Api.Data;

/// <summary>
/// Organization Sm Sentry Policies Assignments Response
/// </summary>
[DataContract]
public class OrganizationSmSentryPoliciesAssignmentsResponse
{
	/// <summary>
	/// The Id of the Network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Array of Sentry Group Policies for the Network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "policies")]
	public List<OrganizationSmSentryPoliciesAssignmentsByNetworkPolicy> Policies { get; set; } = [];
}
