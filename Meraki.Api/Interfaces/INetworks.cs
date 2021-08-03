using Meraki.Api.Data;
using Microsoft.Extensions.DependencyInjection;
using Refit;
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
		/// bindNetwork
		/// </summary>
		/// <remarks>
		/// Bind a network to a template.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="bindNetwork"></param>
		/// <returns>Task of void</returns>
		[Post("/networks/{networkId}/bind")]
		Task BindConfigurationTemplateAsync(
			[AliasAs("networkId")] string networkId,
			[Body] ConfigurationTemplateBindRequest bindNetwork,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// combineOrganizationNetworks
		/// </summary>
		/// <remarks>
		/// Combine multiple networks into a single network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="combineOrganizationNetworks"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/networks/combine")]
		Task<object> CombineOrganizationNetworksAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] CombineOrganizationNetworksRequest combineOrganizationNetworks,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// createOrganizationNetwork
		/// </summary>
		/// <remarks>
		/// Create a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="createOrganizationNetwork"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/networks")]
		Task<Network> CreateAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] NetworkCreationRequest createOrganizationNetwork,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// deleteNetwork
		/// </summary>
		/// <remarks>
		/// Delete a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}")]
		Task DeleteAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetwork
		/// </summary>
		/// <remarks>
		/// Return a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}")]
		Task<Network> GetAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkSwitchAccessPolicies
		/// </summary>
		/// <remarks>
		/// List the access policies for a switch network. Only returns access policies with 'my RADIUS server' as authentication method
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/accessPolicies")]
		Task<object> GetNetworkAccessPolicies(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// getNetworkAirMarshal
		/// </summary>
		/// <remarks>
		/// List Air Marshal scan results from a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 7 days. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/airMarshal")]
		Task<object> GetNetworkAirMarshal(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("timespan")] double? timespan = null
			);

		/// <summary>
		/// getNetworkSiteToSiteVpn
		/// </summary>
		/// <remarks>
		/// Return the site-to-site VPN settings of a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/vpn/siteToSiteVpn")]
		Task<object> GetNetworkSiteToSiteVpn(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// getNetworkTraffic
		/// </summary>
		/// <remarks>
		/// Return the traffic analysis data for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 30 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 30 days. (optional)</param>
		/// <param name="deviceType">    Filter the data by device type: &#39;combined&#39;, &#39;wireless&#39;, &#39;switch&#39; or &#39;appliance&#39;. Defaults to &#39;combined&#39;.     When using &#39;combined&#39;, for each rule the data will come from the device type with the most usage.  (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/traffic")]
		Task<object> GetNetworkTraffic(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("deviceType")] string deviceType = null!
			);

		/// <summary>
		/// getOrganizationNetworks
		/// </summary>
		/// <remarks>
		/// List the networks that the user has privileges on in an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="configTemplateId">An optional parameter that is the ID of a config template. Will return all networks bound to that template. (optional)</param>
		/// <param name="tags">An optional parameter to filter networks by tags. The filtering is case-sensitive. If tags are included, 'tagsFilterType' should also be included (see below).</param>
		/// <param name="tagsFilterType">An optional parameter of value 'withAnyTags' or 'withAllTags' to indicate whether to return networks which contain ANY or ALL of the included tags. If no type is included, 'withAnyTags' will be selected.</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 100000. Default is 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <returns>Task of Object</returns>
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
		/// splitNetwork
		/// </summary>
		/// <remarks>
		/// Split a combined network into individual networks for each type of device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/split")]
		Task<object> SplitAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// unbindNetwork
		/// </summary>
		/// <remarks>
		/// Unbind a network from a template.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of void</returns>
		[Post("/networks/{networkId}/unbind")]
		Task UnbindConfigurationTemplateAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// updateNetwork
		/// </summary>
		/// <remarks>
		/// Update a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="networkUpdateRequest"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}")]
		Task<object> UpdateNetworkAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkUpdateRequest networkUpdateRequest,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// updateNetworkSiteToSiteVpn
		/// </summary>
		/// <remarks>
		/// Update the site-to-site VPN settings of a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSiteToSiteVpn"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/vpn/siteToSiteVpn")]
		Task<object> UpdateNetworkSiteToSiteVpn(
			[AliasAs("networkId")] string networkId,
			[Body] SiteToSiteVpnUpdateRequest updateNetworkSiteToSiteVpn
			);

		/// <summary>
		/// getNetworkApplianceSettings
		/// </summary>
		/// <remarks>
		/// Return the appliance settings for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/settings")]
		Task<ApplianceSettings> GetNetworkApplianceSettings(
			[AliasAs("networkId")] string networkId
			);
	}
}
