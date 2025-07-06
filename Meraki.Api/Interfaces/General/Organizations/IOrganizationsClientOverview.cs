namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsClientOverview
{
	/// <summary>
	/// Return summary information around client data usage (in kb) across the given organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationClientsOverview")]
	[Get("/organizations/{organizationId}/clients/overview")]
	Task<ClientOverview> GetOrganizationClientsOverviewAsync(
		string organizationId,
		string t0,
		string t1,
		int timespan = 1,
		CancellationToken cancellationToken = default);
}
