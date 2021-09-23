using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworks
	{
		/// <summary>
		/// Bind a network to a template.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="bindNetwork">Body for binding a network</param>
		[Post("/networks/{networkId}/bind")]
		Task BindConfigurationTemplateAsync(
			[AliasAs("networkId")] string networkId,
			[Body] ConfigurationTemplateBindRequest bindNetwork,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Combine multiple networks into a single network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="combineOrganizationNetworks">Body for combining networks</param>
		[Post("/organizations/{organizationId}/networks/combine")]
		Task<CombineNetworkResponse> CombineOrganizationNetworksAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] CombineOrganizationNetworksRequest combineOrganizationNetworks,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="createOrganizationNetwork">Body for creating a network</param>
		[Post("/organizations/{organizationId}/networks")]
		Task<Network> CreateAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] NetworkCreationRequest createOrganizationNetwork,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Delete("/networks/{networkId}")]
		Task DeleteAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}")]
		Task<Network> GetAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the access policies for a switch network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/accessPolicies")]
		Task<List<AccessPolicy>> GetNetworkAccessPoliciesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List Air Marshal scan results from a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 7 days. (optional)</param>
		[Get("/networks/{networkId}/wireless/airMarshal")]
		Task<List<AirMarshal>> GetNetworkAirMarshalAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("timespan")] double? timespan = null,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the site-to-site VPN settings of a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/vpn/siteToSiteVpn")]
		Task<SiteToSiteVpnUpdateRequest> GetNetworkSiteToSiteVpnAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the traffic analysis data for this network
		/// </summary>
		/// <param name="networkId">The network id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 30 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 30 days. (optional)</param>
		/// <param name="deviceType">Filter the data by device type: &#39;combined&#39;, &#39;wireless&#39;, &#39;switch&#39; or &#39;appliance&#39;. Defaults to &#39;combined&#39;.     When using &#39;combined&#39;, for each rule the data will come from the device type with the most usage.  (optional)</param>
		[Get("/networks/{networkId}/traffic")]
		Task<TrafficAnalysisSettingsUpdateRequest> GetNetworkTrafficAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("deviceType")] string deviceType = null!,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the networks that the user has privileges on in an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="configTemplateId">An optional parameter that is the ID of a config template. Will return all networks bound to that template. (optional)</param>
		/// <param name="tags">An optional parameter to filter networks by tags. The filtering is case-sensitive. If tags are included, 'tagsFilterType' should also be included (see below).</param>
		/// <param name="tagsFilterType">An optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return networks which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 100000. Default is 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		[Obsolete("Use Organizations.GetNetworksAsync", true)]
		[Get("/organizations/{organizationId}/networks")]
		Task<List<Network>> GetAllAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("configTemplateId")] string? configTemplateId = null,
			[AliasAs("tags")] List<string>? tags = null,
			[AliasAs("tagsFilterType")] string? tagsFilterType = null,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Split a combined network into individual networks for each type of device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Post("/networks/{networkId}/split")]
		Task<CombineNetworkResponse> SplitAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Unbind a network from a template.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Post("/networks/{networkId}/unbind")]
		Task UnbindConfigurationTemplateAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="networkUpdateRequest">Body for updating a network</param>
		[Put("/networks/{networkId}")]
		Task<Network> UpdateNetworkAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkUpdateRequest networkUpdateRequest,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the site-to-site VPN settings of a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSiteToSiteVpn">Body for updating VPN settings</param>
		[Put("/networks/{networkId}/appliance/vpn/siteToSiteVpn")]
		Task<SiteToSiteVpnUpdateRequest> UpdateNetworkSiteToSiteVpnAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SiteToSiteVpnUpdateRequest updateNetworkSiteToSiteVpn,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the appliance settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/settings")]
		Task<ApplianceSettings> GetNetworkApplianceSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/settings")]
		Task<NetworkSettings> GetSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSettings">Body for updating network settings</param>
		[Put("/networks/{networkId}/settings")]
		Task<NetworkSettings> UpdateSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkSettings updateNetworkSettings,
			CancellationToken cancellationToken = default
			);
	}
}
