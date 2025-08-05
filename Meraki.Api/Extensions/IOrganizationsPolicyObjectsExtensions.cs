namespace Meraki.Api.Extensions;

public static class IOrganizationsPolicyObjectsExtensions
{
	/// <summary>
	/// Lists Policy Objects belonging to the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationsPolicyObjects"></param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	public static Task<List<OrganizationPolicyObject>> GetOrganizationPolicyObjectsAllAsync(
		this IOrganizationsPolicyObjects organizationsPolicyObjects,
		string organizationId,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> organizationsPolicyObjects.GetOrganizationPolicyObjectsApiResponseAsync(
						organizationId,
						startingAfter,
						endingBefore,
						cancellationToken
					),
					cancellationToken
			);
}
