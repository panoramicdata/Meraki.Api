using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Organizations interface
	/// </summary>
	public interface IOrganizations
	{
		/// <summary>
		/// List the organizations that the user has privileges on
		/// </summary>
		[Get("/organizations")]
		Task<List<Organization>> GetAllAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return an organization
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		[Get("/organizations/{organizationId}")]
		Task<Organization> GetAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Lists all the networks in an organization
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		[Obsolete("Use GetNetworksAsync() instead", false)]
		[Get("/organizations/{organizationId}/networks")]
		Task<List<Network>> GetAllNetworksAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List networks in an organization
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		/// <param name="configTemplateId">An optional parameter that is the ID of a config template. Will return all networks bound to that template.</param>
		[Get("/organizations/{organizationId}/networks")]
		Task<List<Network>> GetNetworksAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId = default!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the devices in an organization
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		[Get("/organizations/{organizationId}/devices")]
		Task<List<Device>> GetAllDevicesAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the devices in an organization
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		[Get("/organizations/{organizationId}/inventory")]
		Task<List<InventoryItem>> GetAllInventoryAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the third party VPN peers in an organization
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		[Get("/organizations/{organizationId}/thirdPartyVPNPeers")]
		Task<List<Network>> GetAllThirdPartyVpnPeersAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create a network
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		/// <param name="name">The name of the new network</param>
		/// <param name="type">The type of the new network. Valid types are wireless, appliance, switch, systemsManager, camera, or a space-separated list of those for a combined network.</param>
		/// <param name="tags">A space-separated list of tags to be applied to the network</param>
		/// <param name="timeZone">The timezone of the network. For a list of allowed timezones, please see the 'TZ' column in the table in this article: https://en.wikipedia.org/wiki/List_of_tz_database_time_zones.</param>
		/// <param name="copyFromNetworkId">The ID of the network to copy configuration from. Other provided parameters will override the copied configuration, except type which must match this network's type exactly.</param>
		/// <param name="disableMyMerakiCom">Disables the local device status pages (my.meraki.com, ap.meraki.com, switch.meraki.com, wired.meraki.com). Optional (defaults to false)</param>
		/// <param name="disableRemoteStatusPage">Disables access to the device status page (http://[device's LAN IP]). Optional. Can only be set if disableMyMerakiCom is set to false</param>
		[Post("/organizations/{organizationId}/networks")]
		Task<Network> CreateNetworkAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("name")] string name,
			[AliasAs("type")] string type,
			[AliasAs("tags")] string tags,
			[AliasAs("timeZone")] string timeZone,
			[AliasAs("copyFromNetworkId")] string copyFromNetworkId = default!,
			[AliasAs("disableMyMerakiCom")] bool? disableMyMerakiCom = default,
			[AliasAs("disableRemoteStatusPage")] bool? disableRemoteStatusPage = default,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the configuration templates for this organization
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		[Get("/organizations/{organizationId}/configTemplates")]
		Task<List<ConfigurationTemplate>> GetAllConfigurationTemplatesAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Remove a configuration template
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		/// <param name="configTemplateId">The configTemplate Id</param>
		[Delete("/organizations/{organizationId}/configTemplates/{configTemplateId}")]
		Task<List<ConfigurationTemplate>> RemoveConfigurationTemplateAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] long configTemplateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Claim a list of devices, licenses, and/or orders into an organization. When claiming by order, all devices and licenses in the order will be claimed; licenses will be added to the organization and devices will be placed in the organization's inventory.
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		/// <param name="organizationBulkClaim">The organization bulk claim</param>
		[Post("/organizations/{organizationId}/claim")]
		Task<OrganizationBulkClaim> BulkClaimAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] OrganizationBulkClaim organizationBulkClaim = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the switch profiles for your switch template configuration
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		/// <param name="configTemplateId">The ConfigTemplate Id</param>
		[Get("/organizations/{organizationId}/configTemplates/{configTemplateId}/switchProfiles")]
		Task<List<SwitchProfile>> GetSwitchProfilesAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string configTemplateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Retrieve the Change Log for your organization
		/// </summary>
		/// <param name="organizationId">The organization Id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today.</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 365 days after t0.</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 365 days. The default is 365 days.</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 5000. Default is 5000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="networkId">Filters on the given network</param>
		/// <param name="cancellationToken"></param>
		[Get("/organizations/{organizationId}/configurationChanges")]
		Task<List<ChangeLogEntry>> GetChangeLogEntriesAsync(
			[AliasAs("organizationId")] string organizationId,
			[Query("t0")] DateTime? t0 = default,
			[Query("t1")] DateTime? t1 = default,
			[Query("timespan")] string timespan = default!,
			[Query("perPage")] string perPage = default!,
			[Query("startingAfter")] string startingAfter = default!,
			[Query("endingBefore")] string endingBefore = default!,
			[Query("networkId")] string networkId = default!,
			[Query("adminId")] string adminId = default!,
			CancellationToken cancellationToken = default);
	}
}
