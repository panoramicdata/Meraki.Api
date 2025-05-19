namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessSsidsFirewallIsolation
{
	/// <summary>
	/// List the L2 isolation allow list MAC entry in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="ssid"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessSsidsFirewallIsolationAllowlistEntries")]
	[Get("/organizations/{organizationId}/wireless/ssids/firewall/isolation/allowlist/entries")]
	Task<OrganizationsWirelessSsidsFirewallAllowListEntriesResponse> GetOrganizationsWirelessSsidsFirewallAllowListEntriesResponseAsync(
		string organizationId,
		string ssid,
		CancellationToken cancellationToken = default
	);
}
