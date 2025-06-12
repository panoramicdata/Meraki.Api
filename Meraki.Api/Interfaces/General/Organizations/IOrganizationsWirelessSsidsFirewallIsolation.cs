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

	/// <summary>
	/// Create isolation allow list MAC entry for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="ssid"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationWirelessSsidsFirewallIsolationAllowlistEntry")]
	[Post("/organizations/{organizationId}/wireless/ssids/firewall/isolation/allowlist/entries")]
	Task<OrganizationsWirelessSsidsFirewallAllowListEntry> CreateOrganizationWirelessSsidsFirewallIsolationAllowlistEntryAsync(
		string organizationId,
		string ssid,
		[Body] OrganizationsWirelessSsidsFirewallAllowListCreateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update isolation allow list MAC entry info
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="entryId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationWirelessSsidsFirewallIsolationAllowlistEntry")]
	[Put("/organizations/{organizationId}/wireless/ssids/firewall/isolation/allowlist/entries/{entryId}")]
	Task<OrganizationsWirelessSsidsFirewallAllowListEntry> UpdateOrganizationWirelessSsidsFirewallIsolationAllowlistEntryAsync(
		string organizationId,
		string entryId,
		[Body] OrganizationsWirelessSsidsFirewallAllowListUpdateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Destroy isolation allow list MAC entry for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="entryId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationWirelessSsidsFirewallIsolationAllowlistEntry")]
	[Delete("/organizations/{organizationId}/wireless/ssids/firewall/isolation/allowlist/entries/{entryId}")]
	Task DeleteOrganizationWirelessSsidsFirewallIsolationAllowlistEntryAsync(
		string organizationId,
		string entryId,
		CancellationToken cancellationToken = default
	);
}
