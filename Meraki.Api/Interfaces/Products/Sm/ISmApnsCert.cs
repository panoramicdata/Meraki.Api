namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISmApnsCert
{
	/// <summary>
	/// Get the organization's APNS certificate
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/sm/apnsCert")]
	Task<ApnsCert> GetOrganizationSmApnsCertAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
