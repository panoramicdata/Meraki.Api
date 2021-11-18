namespace Meraki.Api.Extensions;

public static class IOrganizationsNetworksExtensions
{
	/// <summary>
	/// Get all networks that the user has privileges on in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="configTemplateId">An optional parameter that is the ID of a config template. Will return all networks bound to that template. (optional)</param>
	/// <param name="tags">An optional parameter to filter networks by tags. The filtering is case-sensitive. If tags are included, 'tagsFilterType' should also be included (see below).</param>
	/// <param name="tagsFilterType">An optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return networks which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
	public static Task<List<Network>> GetOrganizationNetworksAllAsync(
		this IOrganizationsNetworks organizationsNetworks,
		string organizationId,
		string? configTemplateId = null,
		List<string>? tags = null,
		string? tagsFilterType = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> organizationsNetworks.GetNetworksApiResponseAsync(
						organizationId,
						configTemplateId,
						tags,
						tagsFilterType,
						startingAfter,
						cancellationToken
					),
					cancellationToken
			);
}
