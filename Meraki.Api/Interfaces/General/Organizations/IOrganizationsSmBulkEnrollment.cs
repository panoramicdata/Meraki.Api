namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSmBulkEnrollment
{
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
	Task<OrganizationSmBulkEnrollmentToken> CreateOrganizationSmBulkEnrollmentTokenAsync(
		string organizationId,
		[Body] OrganizationSmBulkEnrollmentTokenCreateRequest organizationSmBulkEnrollmentToken,
		CancellationToken cancellationToken = default
		);
}
