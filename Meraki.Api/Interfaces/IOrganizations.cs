using Meraki.Api.Attributes;
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
		/// <param name="organizationClaimRequest">Body for making a claim request</param>
		[Post("/organizations/{organizationId}/claim")]
		Task<OrganizationClaimResponse> ClaimAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] OrganizationClaimRequest organizationClaimRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create a new organization by cloning the addressed organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="cloneOrganization">Body for cloning an organization</param>
		[Post("/organizations/{organizationId}/clone")]
		Task<Organization> CloneAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] CloneOrganization cloneOrganization,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create a new organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="createOrganization">Body for creating an organization</param>
		[Post("/organizations")]
		Task<Organization> CreateAsync(
			[Body] OrganizationCreateRequest createOrganization,
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
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="configurationUpdatedAfter">Filter results by whether or not the device&#39;s configuration has been updated after the given timestamp (optional)</param>
		[Get("/organizations/{organizationId}/devices")]
		Task<List<OrganizationDevice>> GetDevicesPagedAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = 1000,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!,
			[AliasAs("configurationUpdatedAfter")] string configurationUpdatedAfter = null!,
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
		/// Return the device inventory for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="usedState">Filter results by used or unused inventory. Accepted values are "used" or "unused".</param>
		/// <param name="search">Search for devices in inventory based on serial number, mac address, or model.</param>
		[Get("/organizations/{organizationId}/inventoryDevices")]
		Task<List<InventoryDevice>> GetInventoryDevicesAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = 1000,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			[AliasAs("usedState")] string? usedState = null,
			[AliasAs("search")] string? search = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the device inventory for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="serial">The serial number</param>
		[Get("/organizations/{organizationId}/inventoryDevices/{serial}")]
		Task<InventoryDevice> GetInventoryDeviceAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("serial")] string serial,
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
		[ApiOperationId("getOrganizationApplianceVpnThirdPartyVPNPeers")]
		[Get("/organizations/{organizationId}/appliance/vpn/thirdPartyVPNPeers")]
		Task<ThirdPartyVpnPeers> GetThirdPartyVpnPeersAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the third party VPN peers for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[ApiOperationId("getOrganizationApplianceVpnThirdPartyVPNPeers")]
		[Put("/organizations/{organizationId}/appliance/vpn/thirdPartyVPNPeers")]
		Task<ThirdPartyVpnPeers> UpdateThirdPartyVpnPeersAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] ThirdPartyVpnPeers peerList,
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
		/// <param name="updateOrganization">Body for updating an organization</param>
		[Put("/organizations/{organizationId}")]
		Task<Organization> UpdateAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] OrganizationUpdateRequest updateOrganization,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns the login security settings for an organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/loginSecurity")]
		Task<LoginSecurity> GetLoginSecurityAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the login security settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="updateOrganizationLoginSecurity">Body for updating login settings</param>
		[Put("/organizations/{organizationId}/loginSecurity")]
		Task<LoginSecurity> UpdateLoginSecurityAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] LoginSecurity updateOrganizationLoginSecurity,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List adaptive policy ACLs in a organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/adaptivePolicy/acls")]
		Task<List<AdaptivePolicyAcl>> GetAdaptivePolicyAclsAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Creates new adaptive policy ACL
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="acls">Body for creating an ACL</param>
		[Post("/organizations/{organizationId}/adaptivePolicy/acls")]
		Task<List<AdaptivePolicyAcl>> CreateAdaptivePolicyAclAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] AdaptivePolicyAcl acls,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns the adaptive policy ACL information
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="id">The ACL id</param>
		[Get("/organizations/{organizationId}/adaptivePolicy/acls/{id}")]
		Task<AdaptivePolicyAcl> GetAdaptivePolicyAclAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns the adaptive policy ACL information
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="id">The ACL id</param>
		/// <param name="acls">Body for returning ACL information</param>
		[Put("/organizations/{organizationId}/adaptivePolicy/acls/{id}")]
		Task<AdaptivePolicyAcl> UpdateAdaptivePolicyAclAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("id")] string id,
			[Body] AdaptivePolicyAcl acls,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Deletes the specified adaptive policy ACL. Note this adaptive policy ACL will also be removed from policies using it.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="id">The ACL id</param>
		[Delete("/organizations/{organizationId}/adaptivePolicy/acls/{id}")]
		Task DeleteAdaptivePolicyAclAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns global adaptive policy settings in an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/adaptivePolicy/settings")]
		Task<AdaptivePolicySettings> GetAdaptivePolicySettingsAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns global adaptive policy settings in an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Put("/organizations/{organizationId}/adaptivePolicy/settings")]
		Task<AdaptivePolicySettings> UpdateAdaptivePolicySettingsAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] AdaptivePolicySettings adaptivePolicySettings,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get paged networks that the user has privileges on in an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">An optional parameter that is the ID of a config template. Will return all networks bound to that template. (optional)</param>
		/// <param name="tags">An optional parameter to filter networks by tags. The filtering is case-sensitive. If tags are included, 'tagsFilterType' should also be included (see below).</param>
		/// <param name="tagsFilterType">An optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return networks which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 100000. Default is 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		[Get("/organizations/{organizationId}/networks")]
		Task<List<Network>> GetNetworksPagedAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string? configTemplateId = null,
			[AliasAs("tags")] List<string>? tags = null,
			[AliasAs("tagsFilterType")] string? tagsFilterType = null,
			[AliasAs("perPage")] int? perPage = 100000,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			CancellationToken cancellationToken = default);

		[Get("/organizations/{organizationId}/networks")]
		internal Task<ApiResponse<List<Network>>> GetNetworksApiResponseAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string? configTemplateId = null,
			[AliasAs("tags")] List<string>? tags = null,
			[AliasAs("tagsFilterType")] string? tagsFilterType = null,
			[AliasAs("startingAfter")] string? startingAfter = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get all networks that the user has privileges on in an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">An optional parameter that is the ID of a config template. Will return all networks bound to that template. (optional)</param>
		/// <param name="tags">An optional parameter to filter networks by tags. The filtering is case-sensitive. If tags are included, 'tagsFilterType' should also be included (see below).</param>
		/// <param name="tagsFilterType">An optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return networks which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
		Task<List<Network>> GetAllNetworksAsync(
			string organizationId,
			string? configTemplateId = null,
			List<string>? tags = null,
			string? tagsFilterType = null,
			CancellationToken cancellationToken = default)
			=> MerakiClient.GetAllAsync(
					(startingAfter, cancellationToken)
					=> GetNetworksApiResponseAsync(
							organizationId,
							configTemplateId,
							tags,
							tagsFilterType,
							startingAfter,
							cancellationToken
						),
						cancellationToken
				);

		/// <summary>
		/// Returns the SAML SSO enabled settings for an organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/saml")]
		Task<Saml> GetSamlAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates the SAML SSO enabled settings for an organization.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="updateOrganizationSaml">Body for updating SAML SSO enabled settings</param>
		[Put("/organizations/{organizationId}/saml")]
		Task<Saml> UpdateSamlAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] Saml updateOrganizationSaml,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the SNMP settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/snmp")]
		Task<OrganizationSnmp> GetSnmpAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the SNMP settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="updateOrganizationSnmp"></param>
		[Put("/organizations/{organizationId}/snmp")]
		Task<OrganizationSnmpUpdateRequest> UpdateSnmpAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] OrganizationSnmpUpdateRequest updateOrganizationSnmp,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns all supported intrusion settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/appliance/security/intrusion")]
		Task<OrganizationSecurityIntrusion> GetSecurityIntrusionAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Sets supported intrusion settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="securityIntrusion">Body for updating security intrusion settings</param>
		[Put("/organizations/{organizationId}/appliance/security/intrusion")]
		Task<OrganizationSecurityIntrusion> UpdateSecurityIntrusionAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] OrganizationSecurityIntrusion securityIntrusion,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the firewall rules for an organization's site-to-site VPN
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[ApiOperationId("getOrganizationApplianceVpnVpnFirewallRules")]
		[Get("/organizations/{organizationId}/appliance/vpn/vpnFirewallRules")]
		Task<VpnFirewallRulesUpdateRequest> GetVpnFirewallRulesAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the firewall rules of an organization's site-to-site VPN
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="vpnFirewallRules">Body for updating firewall rules</param>
		[ApiOperationId("updateOrganizationApplianceVpnVpnFirewallRules")]
		[Put("/organizations/{organizationId}/appliance/vpn/vpnFirewallRules")]
		Task<VpnFirewallRulesUpdateRequest> UpdateVpnFirewallRulesAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] VpnFirewallRulesUpdateRequest vpnFirewallRules,
			CancellationToken cancellationToken = default
			);
	}
}
