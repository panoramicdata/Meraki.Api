namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Wireless Opportunistic Pcap
/// </summary>
public interface IOrganizationsWirelessOpportunisticPcap
{
	/// <summary>
	/// List the Opportunistic Pcap settings of an organization by network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessOpportunisticPcapByNetwork")]
	[Get("/organizations/{organizationId}/wireless/opportunisticPcap/byNetwork")]
	Task<List<OrganizationWirelessOpportunisticPcap>> GetOrganizationWirelessOpportunisticPcapByNetworkAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Check the Opportunistic Pcap license status of an organization by network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("byOrganizationWirelessOpportunisticPcapLicenseNetwork")]
	[Get("/organizations/{organizationId}/wireless/opportunisticPcap/license/byNetwork")]
	Task<List<OrganizationWirelessOpportunisticPcapLicense>> GetOrganizationWirelessOpportunisticPcapLicenseByNetworkAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
