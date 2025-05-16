namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsDevicesController
{
	/// <summary>
	/// Migrate devices to another controller or management mode
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationDevicesControllerMigration")]
	[Post("/organizations/{organizationId}/devices/controller/migrations")]
	Task<OrganizationsDevicesControllerMigration> CreateOrganizationDevicesControllerMigrationAsync(
		string organizationId,
		[Body] OrganizationsDevicesControllerMigrationCreateRequest request,
		CancellationToken cancellationToken = default
	);
}
