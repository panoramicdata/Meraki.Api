namespace Meraki.Api.Data;

/// <summary>
/// Organization Sm Sentry Policies Assignments Request
/// </summary>
[DataContract]
public class OrganizationSmSentryPoliciesAssignmentsUpdateRequest
{
	/// <summary>
	/// Sentry Group Policies for the Organization keyed by Network Id
	/// </summary>
	[DataMember(Name = "items")]
	public List<OrganizationSmSentryPoliciesAssignmentsUpdateRequestPolicyItem> Items { get; set; } = [];
}
