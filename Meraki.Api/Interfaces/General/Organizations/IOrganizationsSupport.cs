namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Support
/// </summary>
public interface IOrganizationsSupport
{
	/// <summary>
	/// Returns the organization's sales representatives
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSupportSalesRepresentatives")]
	[Get("/organizations/{organizationId}/support/salesRepresentatives")]
	Task<List<SupportSalesRepresentative>> GetOrganizationSupportSalesRepresentativesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
