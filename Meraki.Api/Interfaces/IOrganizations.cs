using Meraki.Api.Data;
using Refit;
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
		/// <param name="orgId"></param>
		[Get("/organizations/{organizationId}")]
		Task<Organization> GetAsync(
			[AliasAs("organizationId")] long organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the networks in an organization
		/// </summary>
		[Get("/organizations/{organizationId}/networks")]
		Task<List<Network>> GetAllNetworksAsync(
			[AliasAs("organizationId")] long organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the devices in an organization
		/// </summary>
		[Get("/organizations/{organizationId}/devices")]
		Task<List<Device>> GetAllDevicesAsync(
			[AliasAs("organizationId")] long organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the devices in an organization
		/// </summary>
		[Get("/organizations/{organizationId}/inventory")]
		Task<List<InventoryItem>> GetAllInventoryAsync(
			[AliasAs("organizationId")] long organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the third party VPN peers in an organization
		/// </summary>
		[Get("/organizations/{organizationId}/thirdPartyVPNPeers")]
		Task<List<Network>> GetAllThirdPartyVpnPeersAsync(
			[AliasAs("organizationId")] long organizationId,
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
			[AliasAs("organizationId")] long organizationId,
			[AliasAs("name")] string name,
			[AliasAs("type")] string type,
			[AliasAs("tags")] string tags,
			[AliasAs("timeZone")] string timeZone,
			[AliasAs("copyFromNetworkId")] string copyFromNetworkId = default!,
			[AliasAs("disableMyMerakiCom")] bool? disableMyMerakiCom = default,
			[AliasAs("disableRemoteStatusPage")] bool? disableRemoteStatusPage = default,
			CancellationToken cancellationToken = default);
	}
}
