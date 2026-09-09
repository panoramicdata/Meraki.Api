namespace Meraki.Api.Data;

/// <summary>
/// Response to updating Sentry policy assignments across an organization
/// </summary>
[DataContract]
public class OrganizationSmSentryPoliciesAssignmentsUpdateResponse
{
	/// <summary>
	/// The Sentry policy assignments, one entry per network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationSmSentryPoliciesAssignmentsResponse> Items { get; set; } = [];
}
