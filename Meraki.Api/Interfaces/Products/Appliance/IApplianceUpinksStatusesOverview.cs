namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceUplinksStatusesOverview
{
	/// <summary>
	/// Returns an overview of uplink statuses
	/// </summary>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationApplianceUplinksStatusesOverview")]
	[Get("/organizations/{organizationId}/appliance/uplinks/statuses/overview")]
	Task<ApplianceUplinksStatusesOverview> GetOrganizationApplianceUplinksStatusesOverviewAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
