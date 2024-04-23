namespace Meraki.Api.Extensions;

public static class IOrganizationsExtensions
{
	/// <summary>
	/// List the organizations that the user has privileges on
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	public static Task<List<Organization>> GetOrganizationsAllAsync(
		this IOrganizations organization,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				organization.GetOrganizationsApiResponseAsync,
					cancellationToken
			);
}
