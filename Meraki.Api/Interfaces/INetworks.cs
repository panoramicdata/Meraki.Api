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
		Task BindAsync(
			[AliasAs("networkId")]string networkId,
			[Body]BindNetwork bindNetwork,
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
		Task<object> CombineOrganizationNetworks(
			[AliasAs("organizationId")]string organizationId,
			[Body]CombineOrganizationNetworks combineOrganizationNetworks
			);

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
			[AliasAs("organizationId")]string organizationId,
			[Body]NetworkCreationDto createOrganizationNetwork,
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
			[AliasAs("networkId")]string networkId,
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
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkAccessPolicies
		/// </summary>
		/// <remarks>
		/// List the access policies for this network. Only valid for MS networks.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/accessPolicies")]
		Task<object> GetNetworkAccessPolicies(
			[AliasAs("networkId")]string networkId
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
		[Get("/networks/{networkId}/airMarshal")]
		Task<object> GetNetworkAirMarshal(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("timespan")]double? timespan = null
			);

		/// <summary>
		/// getNetworkSiteToSiteVpn
		/// </summary>
		/// <remarks>
		/// Return the site-to-site VPN settings of a network. Only valid for MX networks.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/siteToSiteVpn")]
		Task<object> GetNetworkSiteToSiteVpn(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkTraffic
		/// </summary>
		/// <remarks>
		///     The traffic analysis data for this network.     &lt;a href&#x3D;\&quot;https://documentation.meraki.com/MR/Monitoring_and_Reporting/Hostname_Visibility\&quot;&gt;Traffic Analysis with Hostname Visibility&lt;/a&gt; must be enabled on the network.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 30 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 30 days. (optional)</param>
		/// <param name="deviceType">    Filter the data by device type: &#39;combined&#39;, &#39;wireless&#39;, &#39;switch&#39; or &#39;appliance&#39;. Defaults to &#39;combined&#39;.     When using &#39;combined&#39;, for each rule the data will come from the device type with the most usage.  (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/traffic")]
		Task<object> GetNetworkTraffic(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("deviceType")]string deviceType = null!
			);

		/// <summary>
		/// getOrganizationNetworks
		/// </summary>
		/// <remarks>
		/// List the networks in an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="configTemplateId">An optional parameter that is the ID of a config template. Will return all networks bound to that template. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/networks")]
		Task<List<Network>> GetAllAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("configTemplateId")]string configTemplateId = null!,
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
			[AliasAs("networkId")]string networkId,
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
		Task UnbindAsync(
			[AliasAs("networkId")]string networkId,
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
		/// <param name="updateNetwork"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}")]
		Task<object> UpdateNetwork(
			[AliasAs("networkId")]string networkId,
			[Body]UpdateNetwork updateNetwork = null!
			);

		/// <summary>
		/// updateNetworkSiteToSiteVpn
		/// </summary>
		/// <remarks>
		/// Update the site-to-site VPN settings of a network. Only valid for MX networks in NAT mode.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSiteToSiteVpn"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/siteToSiteVpn")]
		Task<object> UpdateNetworkSiteToSiteVpn(
			[AliasAs("networkId")]string networkId,
			[Body]UpdateNetworkSiteToSiteVpn updateNetworkSiteToSiteVpn
			);
	}
}
