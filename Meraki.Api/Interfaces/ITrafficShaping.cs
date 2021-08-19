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
	public interface ITrafficShaping
	{
		/// <summary>
		/// Display the traffic shaping settings for a SSID on an MR network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/trafficShaping/rules")]
		Task<SsidTrafficShapingUpdateRequest> GetNetworkWirelessSsidTrafficShapingRulesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Display the traffic shaping settings rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/trafficShaping/rules")]
		Task<TrafficShapingUpdateRequest> GetNetworkApplianceTrafficShapingRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns the application categories for traffic shaping rules.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/trafficShaping/applicationCategories")]
		Task<L7ApplicationCategories> GetNetworkTrafficShapingApplicationCategoriesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns the available DSCP tagging options for your traffic shaping rules.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/trafficShaping/dscpTaggingOptions")]
		Task<List<DscpTaggingValues>> GetNetworkTrafficShapingDscpTaggingOptionsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the traffic shaping settings for an SSID on an MR network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="UpdateNetworkSsidTrafficShaping"></param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/trafficShaping/rules")]
		Task<SsidTrafficShapingUpdateRequest> UpdateNetworkWirelessSsidTrafficShapingRulesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] SsidTrafficShapingUpdateRequest UpdateNetworkSsidTrafficShaping,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the traffic shaping settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkTrafficShaping"></param>
		[Put("/networks/{networkId}/appliance/trafficShaping")]
		Task<TrafficShapingUpdateRequest> UpdateNetworkApplianceTrafficShapingAsync(
			[AliasAs("networkId")] string networkId,
			[Body] TrafficShapingUpdateRequest UpdateNetworkTrafficShaping,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List all custom performance classes for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses")]
		Task<CustomPerformanceClasses> GetNetworkApplianceTrafficShapingCustomPerformanceClassesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Add a custom performance class for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Post("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses")]
		Task<CustomPerformanceClassesRequest> CreateNetworkApplianceTrafficShapingCustomPerformanceClassAsync(
			[AliasAs("networkId")] string networkId,
			[Body] CustomPerformanceClassesRequest CreateNetworkApplianceTrafficShapingCustomPerformanceClass,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a custom performance class for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="customPerformanceClassId">The custom performance class id</param>
		[Get("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses/{customPerformanceClassId}")]
		Task<CustomPerformanceClasses> GetNetworkApplianceTrafficShapingCustomPerformanceClassAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("customPerformanceClassId")] string customPerformanceClassId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a custom performance class for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="customPerformanceClassId">The custom performance class id</param>
		/// <param name="UpdateNetworkApplianceTrafficShapingCustomPerformanceClass"></param>
		[Put("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses/{customPerformanceClassId}")]
		Task<CustomPerformanceClasses> UpdateNetworkApplianceTrafficShapingCustomPerformanceClassAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("customPerformanceClassId")] string customPerformanceClassId,
			[Body] CustomPerformanceClassesRequest UpdateNetworkApplianceTrafficShapingCustomPerformanceClass,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a custom performance class from an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="customPerformanceClassId">The custom performance class id</param>
		[Delete("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses/{customPerformanceClassId}")]
		Task DeleteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("customPerformanceClassId")] string customPerformanceClassId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns the uplink bandwidth settings for your MX network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/trafficShaping/uplinkBandwidth")]
		Task<UplinkBandwidth> GetNetworkApplianceTrafficShapingUplinkBandwidthAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates the uplink bandwidth settings for your MX network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkApplianceTrafficShapingUplinkBandwidth"></param>
		[Put("/networks/{networkId}/appliance/trafficShaping/uplinkBandwidth")]
		Task<UplinkBandwidth> UpdateNetworkApplianceTrafficShapingUplinkBandwidthAsync(
			[AliasAs("networkId")] string networkId,
			[Body] UplinkBandwidth UpdateNetworkApplianceTrafficShapingUplinkBandwidth,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Show uplink selection settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
		Task<UplinkSelection> GetNetworkApplianceTrafficShapingUpinkSelectionAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update uplink selection settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Put("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
		Task<UplinkSelection> UpdateNetworkApplianceTrafficShapingUplinkSelectionAsync(
			[AliasAs("networkId")] string networkId,
			[Body] UplinkSelection UpdateNetworkApplianceTrafficShapingUplinkSelection,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Display the traffic shaping settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/trafficShaping")]
		Task<NetworkApplianceTrafficShaping> GetNetworkApplianceTrafficShapingAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the traffic shaping settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkApplianceTrafficShaping"></param>
		[Get("/networks/{networkId}/appliance/trafficShaping")]
		Task<NetworkApplianceTrafficShaping> UpdateNetworkApplianceTrafficShapingAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkApplianceTrafficShaping UpdateNetworkApplianceTrafficShaping,
			CancellationToken cancellationToken = default
			);
	}
}
