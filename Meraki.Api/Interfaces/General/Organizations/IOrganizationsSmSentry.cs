namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Sm Sentry
/// </summary>
public interface IOrganizationsSmSentry
{
	/// <summary>
	/// List the Sentry Policies for an organization ordered in ascending order of priority
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSmSentryPoliciesAssignmentsByNetwork")]
	[Get("/organizations/{organizationId}/sm/sentry/policies/assignments/byNetwork")]
	Task<OrganizationSmSentryPoliciesAssignmentsByNetworkResponse> GetOrganizationSmSentryPoliciesAssignmentsByNetwork(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update an Organizations Sentry Policies using the provided list. Sentry Policies are ordered in descending order of priority (i.e. highest priority at the bottom, this is opposite the Dashboard UI). Policies not present in the request will be deleted.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationSmSentryPoliciesAssignments")]
	[Put("/organizations/{organizationId}/sm/sentry/policies/assignments")]
	Task<OrganizationSmSentryPoliciesAssignmentsResponse> UpdateOrganizationSmSentryPoliciesAssignments(
		string organizationId,
		[Body] OrganizationSmSentryPoliciesAssignmentsUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
