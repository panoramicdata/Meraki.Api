namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsApplianceUplinksUsage
{
	/// <summary>
	/// Get the sent and received bytes for each uplink of all MX and Z networks within an organization. If more than one device was active during the specified timespan, then the sent and received bytes will be aggregated by interface.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationApplianceUplinksUsageByNetwork")]
	[Get("/organizations/{organizationId}/appliance/uplinks/usage/byNetwork")]
	Task<List<OrganizationApplianceUplinksUsageByNetworkItem>> GetOrganizationApplianceUplinksUsageByNetworkAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
