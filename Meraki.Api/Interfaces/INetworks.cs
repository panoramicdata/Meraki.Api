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
		/// <exception cref="ApiException">Thrown when fails to make API cg</exception>
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
		// Todo - this is a monitoring endpoint, the return type was wrong. A new model needs to be added for Traffic (PA)
		[Get("/networks/{networkId}/traffic")]
		Task<object> GetNetworkTrafficAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("deviceType")] string deviceType = null!,
			CancellationToken cancellationToken = default
			);

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

		/// <summary>
		/// List the devices in a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/devices")]
		Task<List<Device>> GetAllDevicesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the NetFlow traffic reporting settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/netflow")]
		Task<Netflow> GetNetflowAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the NetFlow traffic reporting settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="netflow">Body for updating netflow traffic</param>
		[Put("/networks/{networkId}/netflow")]
		Task<Netflow> UpdateNetflowAsync(
			[AliasAs("networkId")] string networkId,
			[Body] Netflow netflow,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the syslog servers for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/syslogServers")]
		Task<SyslogServers> GetSyslogServersAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the syslog servers for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="syslogServers"></param>
		[Put("/networks/{networkId}/syslogServers")]
		Task<SyslogServers> UpdateSyslogServersAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SyslogServers syslogServers,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the traffic analysis settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/trafficAnalysis")]
		Task<TrafficAnalysis> GetTrafficAnalysisAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the traffic analysis settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="trafficAnalysis"></param>
		[Put("/networks/{networkId}/trafficAnalysis")]
		Task<TrafficAnalysis> UpdateTrafficAnalysisAsync(
			[AliasAs("networkId")] string networkId,
			[Body] TrafficAnalysis trafficAnalysis,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the SNMP settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/snmp")]
		Task<NetworkSnmpSetting> GetSnmpAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the SNMP settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="networkSnmpSetting"></param>
		[Put("/networks/{networkId}/snmp")]
		Task<NetworkSnmpSetting> UpdateSnmpAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkSnmpSetting networkSnmpSetting,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the content filtering settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceContentFiltering")]
		[Get("/networks/{networkId}/appliance/contentFiltering")]
		Task<ContentFilteringResult> GetContentFilteringAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the content filtering settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="networkContentFilteringUpdateRequest">Body for updating content filtering settings</param>
		[ApiOperationId("updateNetworkApplianceContentFiltering")]
		[Put("/networks/{networkId}/appliance/contentFiltering")]
		Task<ContentFilteringResult> UpdateContentFilteringAsync(
			[AliasAs("networkId")] string networkId,
			[Body] ContentFilteringUpdateRequest networkContentFilteringUpdateRequest,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List all available content filtering categories for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceContentFilteringCategories")]
		[Get("/networks/{networkId}/appliance/contentFiltering/categories")]
		Task<ContentFilteringCategories> GetContentFilteringCategoriesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return single LAN configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/singleLan")]
		Task<LanConfiguration> GetApplianceSingleLanAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update single LAN configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkApplianceSingleLan">Body for updating a single LAN config</param>
		[Put("/networks/{networkId}/appliance/singleLan")]
		Task<LanConfiguration> UpdateApplianceSingleLanAsync(
			[AliasAs("networkId")] string networkId,
			[Body] LanConfigurationUpdateRequest updateNetworkApplianceSingleLan,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return per-port VLAN settings for a single MX port.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="appliancePortId">The appliance port id</param>
		[ApiOperationId("getNetworkAppliancePort")]
		[Get("/networks/{networkId}/appliance/ports/{portId}")]
		Task<AppliancePort> GetAppliancePortAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("portId")] string appliancePortId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List per-port VLAN settings for all ports of a MX.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</experception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkAppliancePorts")]
		[Get("/networks/{networkId}/appliance/ports")]
		Task<List<AppliancePort>> GetAppliancePortsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the per-port VLAN settings for a single MX port.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="portId">The appliance port id</param>
		/// <param name="appliancePort">Body for updating the per-port VLAN settings</param>
		[ApiOperationId("updateNetworkAppliancePorts")]
		[Put("/networks/{networkId}/appliance/ports/{portId}")]
		Task<AppliancePort> UpdateAppliancePortAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("portId")] string portId,
			[Body] AppliancePort appliancePort,
			CancellationToken cancellationToken = default
			);
	}
}
