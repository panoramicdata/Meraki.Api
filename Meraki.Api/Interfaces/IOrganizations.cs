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
		/// Claim a list of devices, licenses, and/or orders into an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="OrganizationClaimRequest">Body for making a claim request</param>
		[Post("/organizations/{organizationId}/claim")]
		Task<OrganizationClaimResponse> ClaimAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] OrganizationClaimRequest OrganizationClaimRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create a new organization by cloning the addressed organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="CloneOrganization">Body for cloning an organization</param>
		[Post("/organizations/{organizationId}/clone")]
		Task<Organization> CloneAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] CloneOrganization CloneOrganization,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create a new organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="CreateOrganization">Body for creating an organization</param>
		[Post("/organizations")]
		Task<Organization> CreateAsync(
			[Body] OrganizationCreateRequest CreateOrganization,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Delete("/organizations/{organizationId}")]
		Task DeleteAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}")]
		Task<Organization> GetAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the devices in an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/devices")]
		Task<List<OrganizationDevice>> GetDevicesAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the status of every Meraki device in the organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/devices/statuses")]
		Task<List<OrganizationDeviceStatus>> GetDeviceStatusesAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the inventory for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="includeLicenseInfo">When this parameter is true, each entity in the response will include the license expiration date of the device (if any). Only applies to organizations that support per-device licensing. Defaults to false. (optional)</param>
		[Get("/organizations/{organizationId}/inventory")]
		Task<List<InventoryItem>> GetInventoryAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("includeLicenseInfo")] bool? includeLicenseInfo = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return an overview of the license state for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("//organizations/{organizationId}/licenses/overview")]
		Task<OrganizationLicenseState> GetLicenseStateAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the third party VPN peers for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/thirdPartyVPNPeers")]
		Task<List<ThirdPartyVpnPeer>> GetThirdPartyVpnPeersAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the uplink loss and latency for every MX in the organization from at latest 2 minutes ago
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 5 minutes after t0. The latest possible time that t1 can be is 2 minutes into the past. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 5 minutes. The default is 5 minutes. (optional)</param>
		/// <param name="uplink">Optional filter for a specific WAN uplink. Valid uplinks are wan1, wan2, cellular. Default will return all uplinks. (optional)</param>
		/// <param name="ip">Optional filter for a specific destination IP. Default will return all destination IPs. (optional)</param>
		[Get("/organizations/{organizationId}/devices/uplinksLossAndLatency")]
		Task<List<UplinksLossAndLatencyResponse>> GetUplinksLossAndLatencyAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("uplink")] string uplink = null!,
			[AliasAs("ip")] string ip = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the organizations that the user has privileges on
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		[Get("/organizations")]
		Task<List<Organization>> GetAllAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="UpdateOrganization">Body for updating an organization</param>
		[Put("/organizations/{organizationId}")]
		Task<Organization> UpdateAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] OrganizationUpdateRequest UpdateOrganization,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the third party VPN peers for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="PeerList">Body for updating a peer list</param>
		[Put("/organizations/{organizationId}/thirdPartyVPNPeers")]
		Task<ThirdPartyVpnPeersUpdateRequest> UpdateThirdPartyVpnPeersAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] ThirdPartyVpnPeersUpdateRequest PeerList,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns the login security settings for an organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/loginSecurity")]
		Task<LoginSecurity> GetOrganizationLoginSecurityAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the login security settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="UpdateOrganizationLoginSecurity">Body for updating login settings</param>
		[Put("/organizations/{organizationId}/loginSecurity")]
		Task<LoginSecurity> UpdateOrganizationLoginSecurityAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body]LoginSecurity UpdateOrganizationLoginSecurity,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List adaptive policy ACLs in a organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/adaptivePolicy/acls")]
		Task<List<Acls>> GetOrganizationAdaptivePolicyAclsAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Creates new adaptive policy ACL
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="Acls">Body for creating an ACL</param>
		[Post("/organizations/{organizationId}/adaptivePolicy/acls")]
		Task<List<Acls>> CreateOrganizationAdaptivePolicyAclAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body]Acls Acls,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns the adaptive policy ACL information
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="id">The ACL id</param>
		[Get("/organizations/{organizationId}/adaptivePolicy/acls/{id}")]
		Task<Acls> GetOrganizationAdaptivePolicyAclAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns the adaptive policy ACL information
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="id">The ACL id</param>
		/// <param name="Acls">Body for returning ACL information</param>
		[Put("/organizations/{organizationId}/adaptivePolicy/acls/{id}")]
		Task<Acls> UpdateOrganizationAdaptivePolicyAclAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("id")] string id,
			[Body]Acls Acls,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Deletes the specified adaptive policy ACL. Note this adaptive policy ACL will also be removed from policies using it.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="id">The ACL id</param>
		[Delete("/organizations/{organizationId}/adaptivePolicy/acls/{id}")]
		Task DeleteOrganizationAdaptivePolicyAclAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns global adaptive policy settings in an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/adaptivePolicy/settings")]
		Task<AdaptivePolicySettings> GetOrganizationAdaptivePolicySettingsAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns global adaptive policy settings in an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Put("/organizations/{organizationId}/adaptivePolicy/settings")]
		Task<AdaptivePolicySettings> UpdateOrganizationAdaptivePolicySettingsAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body]AdaptivePolicySettings AdaptivePolicySettings,
			CancellationToken cancellationToken = default);
	}
}
