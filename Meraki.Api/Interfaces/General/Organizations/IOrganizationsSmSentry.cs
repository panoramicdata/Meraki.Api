namespace Meraki.Api.Interfaces.General.Organizations;

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
}
