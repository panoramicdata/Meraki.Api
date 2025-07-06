namespace Meraki.Api.Extensions;

public static class IOrganizationsPolicyObjectsGroupsExtensions
{
	/// <summary>
	/// Lists Policy Objects Groups belonging to the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationsPolicyObjectsGroups"></param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	public static Task<List<OrganizationPolicyObjectsGroup>> GetOrganizationPolicyObjectsGroupsAllAsync(
		this IOrganizationsPolicyObjectsGroups organizationsPolicyObjectsGroups,
		string organizationId,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> organizationsPolicyObjectsGroups.GetOrganizationPolicyObjectsGroupsApiResponseAsync(
						organizationId,
						startingAfter,
						endingBefore,
						cancellationToken
					),
					cancellationToken
			);
}
