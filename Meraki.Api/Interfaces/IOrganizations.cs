using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IOrganizations
	{
		/// <summary>
		/// claimIntoOrganization
		/// </summary>
		/// <remarks>
		/// Claim a list of devices, licenses, and/or orders into an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="organizationClaimRequest"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/claim")]
		Task<OrganizationClaimResponse> ClaimAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] OrganizationClaimRequest organizationClaimRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// cloneOrganization
		/// </summary>
		/// <remarks>
		/// Create a new organization by cloning the addressed organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="cloneOrganization"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/clone")]
		Task<Organization> CloneAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] CloneOrganization cloneOrganization,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// createOrganization
		/// </summary>
		/// <remarks>
		/// Create a new organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="createOrganization"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations")]
		Task<Organization> CreateAsync(
			[Body] OrganizationCreateRequest createOrganization,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// deleteOrganization
		/// </summary>
		/// <remarks>
		/// Delete an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}")]
		Task DeleteAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// getOrganization
		/// </summary>
		/// <remarks>
		/// Return an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}")]
		Task<Organization> GetAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationDevices
		/// </summary>
		/// <remarks>
		/// List the devices in an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/devices")]
		Task<List<OrganizationDevice>> GetDevicesAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationDeviceStatuses
		/// </summary>
		/// <remarks>
		/// List the status of every Meraki device in the organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/devices/statuses")]
		Task<List<OrganizationDeviceStatus>> GetDeviceStatusesAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationInventory
		/// </summary>
		/// <remarks>
		/// Return the inventory for an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="includeLicenseInfo">When this parameter is true, each entity in the response will include the license expiration date of the device (if any). Only applies to organizations that support per-device licensing. Defaults to false. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/inventory")]
		Task<List<InventoryItem>> GetInventoryAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("includeLicenseInfo")] bool? includeLicenseInfo = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationLicenseState
		/// </summary>
		/// <remarks>
		/// Return an overview of the license state for an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of Object</returns>
		[Get("//organizations/{organizationId}/licenses/overview")]
		Task<OrganizationLicenseState> GetLicenseStateAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationThirdPartyVPNPeers
		/// </summary>
		/// <remarks>
		/// Return the third party VPN peers for an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/thirdPartyVPNPeers")]
		Task<List<ThirdPartyVpnPeer>> GetThirdPartyVpnPeersAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationUplinksLossAndLatency
		/// </summary>
		/// <remarks>
		/// Return the uplink loss and latency for every MX in the organization from at latest 2 minutes ago
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 5 minutes after t0. The latest possible time that t1 can be is 2 minutes into the past. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 5 minutes. The default is 5 minutes. (optional)</param>
		/// <param name="uplink">Optional filter for a specific WAN uplink. Valid uplinks are wan1, wan2, cellular. Default will return all uplinks. (optional)</param>
		/// <param name="ip">Optional filter for a specific destination IP. Default will return all destination IPs. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/devices/uplinksLossAndLatency")]
		Task<object> GetUplinksLossAndLatencyAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("uplink")] string uplink = null!,
			[AliasAs("ip")] string ip = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizations
		/// </summary>
		/// <remarks>
		/// List the organizations that the user has privileges on
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of Object</returns>
		[Get("/organizations")]
		Task<List<Organization>> GetAllAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateOrganization
		/// </summary>
		/// <remarks>
		/// Update an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="updateOrganization"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}")]
		Task<Organization> UpdateAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] OrganizationUpdateRequest updateOrganization,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateOrganizationThirdPartyVPNPeers
		/// </summary>
		/// <remarks>
		/// Update the third party VPN peers for an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="peerList"></param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/thirdPartyVPNPeers")]
		Task<object> UpdateThirdPartyVpnPeersAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] ThirdPartyVpnPeersUpdateRequest peerList,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationLoginSecurity
		/// </summary>
		/// <remarks>
		/// Returns the login security settings for an organization.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/loginSecurity")]
		Task<LoginSecurity> GetOrganizationLoginSecurity(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateOrganizationLoginSecurity
		/// </summary>
		/// <remarks>
		/// Update the login security settings for an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="updateOrganizationLoginSecurity"></param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/loginSecurity")]
		Task<LoginSecurity> UpdateOrganizationLoginSecurity(
			[AliasAs("organizationId")] string organizationId,
			[Body]LoginSecurity updateOrganizationLoginSecurity,
			CancellationToken cancellationToken = default);
	}
}
