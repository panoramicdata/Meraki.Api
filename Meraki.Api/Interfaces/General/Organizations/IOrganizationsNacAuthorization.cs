namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Nac Authorization
/// </summary>
public interface IOrganizationsNacAuthorization
{
	/// <summary>
	/// Get all nac authorization policy sets for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationNacAuthorizationPolicysets")]
	[Get("/organizations/{organizationId}/nac/authorization/policysets")]
	Task<List<OrganizationNacAuthorizationPolicySet>> GetOrganizationNacAuthorizationPolicySetsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
