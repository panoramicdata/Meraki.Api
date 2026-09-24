namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Appliance Uplinks Usage
/// </summary>
public interface IOrganizationsApplianceUplinksUsage
{
	/// <summary>
	/// Get the sent and received bytes for each uplink of all MX and Z networks within an organization. If more than one device was active during the specified timespan, then the sent and received bytes will be aggregated by interface.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 30 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 14 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 14 days. The default is 1 day.</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationApplianceUplinksUsageByNetwork")]
	[Get("/organizations/{organizationId}/appliance/uplinks/usage/byNetwork")]
	Task<List<OrganizationApplianceUplinksUsageByNetworkItem>> GetOrganizationApplianceUplinksUsageByNetworkAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		CancellationToken cancellationToken = default
	);
}
