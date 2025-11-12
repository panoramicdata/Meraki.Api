namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Sm Bulk Enrollment
/// </summary>
public interface IOrganizationsSmBulkEnrollment
{
	/// <summary>
	/// List all BulkEnrollmentTokens for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSmBulkEnrollmentTokens")]
	[Get("/organizations/{organizationId}/sm/bulkEnrollment/tokens")]
	Task<List<OrganizationSmBulkEnrollmentToken>> GetOrganizationSmBulkEnrollmentTokensAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a PccBulkEnrollmentToken
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="organizationSmBulkEnrollmentToken"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSmBulkEnrollmentToken")]
	[Post("/organizations/{organizationId}/sm/bulkEnrollment/token")]
	Task<OrganizationSmBulkEnrollmentTokenDetailed> CreateOrganizationSmBulkEnrollmentTokenAsync(
		string organizationId,
		[Body] OrganizationSmBulkEnrollmentTokenCreateRequest organizationSmBulkEnrollmentToken,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a BulkEnrollmentToken
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="tokenId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSmBulkEnrollmentToken")]
	[Get("/organizations/{organizationId}/sm/bulkEnrollment/token/{tokenId}")]
	Task<OrganizationSmBulkEnrollmentToken> GetOrganizationSmBulkEnrollmentTokenAsync(
		string organizationId,
		string tokenId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a PccBulkEnrollmentToken
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="tokenId"></param>
	/// <param name="organizationSmBulkEnrollmentToken"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationSmBulkEnrollmentToken")]
	[Put("/organizations/{organizationId}/sm/bulkEnrollment/token/{tokenId}")]
	Task<OrganizationSmBulkEnrollmentToken> UpdateOrganizationSmBulkEnrollmentTokenAsync(
		string organizationId,
		string tokenId,
		[Body] OrganizationSmBulkEnrollmentTokenUpdateRequest organizationSmBulkEnrollmentToken,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a PccBulkEnrollmentToken
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="tokenId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationSmBulkEnrollmentToken")]
	[Delete("/organizations/{organizationId}/sm/bulkEnrollment/token/{tokenId}")]
	Task DeleteOrganizationSmBulkEnrollmentTokenAsync(
		string organizationId,
		string tokenId,
		CancellationToken cancellationToken = default
		);
}
