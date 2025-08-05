namespace Meraki.Api.Data;

/// <summary>
/// A Sentry Group Policy for the Organization keyed by Network Id
/// </summary>
[DataContract]
public class OrganizationSmSentryPoliciesAssignmentsUpdateRequestPolicyItem
{
	/// <summary>
	/// The Id of the Network
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Array of Sentry Group Policies for the Network
	/// </summary>
	[DataMember(Name = "policies")]
	public List<OrganizationSmSentryPoliciesAssignmentsUpdateRequestPolicy> Policies { get; set; } = [];
}
