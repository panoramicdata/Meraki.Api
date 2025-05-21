namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSmApple
{
	/// <summary>
	/// Enqueue a sync job for an ADE account
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSmAppleCloudEnrollmentSyncJob")]
	[Post("/organizations/{organizationId}/sm/apple/cloudEnrollment/syncJobs")]
	Task<OrganizationsCloudEnrollmentSyncJob> CreateOrganizationSmAppleCloudEnrollmentSyncJobAsync(
		string organizationId,
		[Body] OrganizationsCloudEnrollmentSyncJobCreateRequest request,
		CancellationToken cancellationToken = default
	);
}
