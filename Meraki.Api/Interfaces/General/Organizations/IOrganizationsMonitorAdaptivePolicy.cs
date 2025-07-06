namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationMonitorAdaptivePolicy
{
	/// <summary>
	/// Returns adaptive policy aggregate statistics for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationAdaptivePolicyOverview")]
	[Get("/organizations/{organizationId}/adaptivePolicy/overview")]
	Task<OrganizationAdaptivePolicyOverview> GetOrganizationAdaptivePolicyOverviewAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}