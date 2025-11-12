namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Policies Assignments
/// </summary>
public interface IOrganizationsPoliciesAssignments
{
	/// <summary>
	/// Get policies for all clients with policies
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationPoliciesAssignmentsByClient")]
	[Get("/organizations/{organizationId}/policies/assignments/byClient")]
	Task<List<OrganizationPoliciesAssignmentsByClientItem>> GetOrganizationPoliciesAssignmentsByClientAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
