namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsAssurance
{
	/// <summary>
	/// Gets relevant product announcements for a user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationAssuranceProductAnnouncements")]
	[Get("/organizations/{organizationId}/assurance/productAnnouncements")]
	Task<OrganizationAssuranceProductAnnouncements> GetOrganizationAssuranceProductAnnouncementsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Return a list of Category Types
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationAssuranceAlertsTaxonomyCategories")]
	[Get("/organizations/{organizationId}/assurance/alerts/taxonomy/categories")]
	Task<List<OrganizationAssuranceAlertsTaxonomyCategory>> GetOrganizationAssuranceAlertsTaxonomyCategoriesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
