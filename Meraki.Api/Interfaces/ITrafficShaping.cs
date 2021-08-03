using Meraki.Api.Data;
using Refit;
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
		/// getNetworkSsidTrafficShaping
		/// </summary>
		/// <remarks>
		/// Display the traffic shaping settings for a SSID on an MR network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/ssids/{number}/trafficShaping")]
		Task<object> GetNetworkSsidTrafficShaping(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number
			);

		/// <summary>
		/// getNetworkTrafficShaping
		/// </summary>
		/// <remarks>
		/// Display the traffic shaping settings rules for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/trafficShaping")]
		Task<object> GetNetworkTrafficShaping(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkTrafficShapingApplicationCategories
		/// </summary>
		/// <remarks>
		/// Returns the application categories for traffic shaping rules.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/trafficShaping/applicationCategories")]
		Task<object> GetNetworkTrafficShapingApplicationCategories(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkTrafficShapingDscpTaggingOptions
		/// </summary>
		/// <remarks>
		/// Returns the available DSCP tagging options for your traffic shaping rules.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/trafficShaping/dscpTaggingOptions")]
		Task<object> GetNetworkTrafficShapingDscpTaggingOptions(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkSsidTrafficShaping
		/// </summary>
		/// <remarks>
		/// Update the traffic shaping settings for an SSID on an MR network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkSsidTrafficShaping"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/ssids/{number}/trafficShaping")]
		Task<object> UpdateNetworkSsidTrafficShaping(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			[Body]SsidTrafficShapingUpdateRequest updateNetworkSsidTrafficShaping
			);

		/// <summary>
		/// updateNetworkTrafficShaping
		/// </summary>
		/// <remarks>
		/// Update the traffic shaping settings rules for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkTrafficShaping"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/trafficShaping")]
		Task<object> UpdateNetworkTrafficShaping(
			[AliasAs("networkId")]string networkId,
			[Body]TrafficShapingUpdateRequest updateNetworkTrafficShaping
			);

		/// <summary>
		/// getNetworkApplianceTrafficShapingCustomPerformanceClasses
		/// </summary>
		/// <remarks>
		/// List all custom performance classes for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses")]
		Task<CustomPerformanceClasses> GetNetworkApplianceTrafficShapingCustomPerformanceClasses(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// createNetworkApplianceTrafficShapingCustomPerformanceClass
		/// </summary>
		/// <remarks>
		/// Add a custom performance class for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses")]
		Task<CustomPerformanceClassesRequest> CreateNetworkApplianceTrafficShapingCustomPerformanceClass(
			[AliasAs("networkId")] string networkId,
			[Body]CustomPerformanceClassesRequest createNetworkApplianceTrafficShapingCustomPerformanceClass	
			);

		/// <summary>
		/// getNetworkApplianceTrafficShapingCustomPerformanceClass
		/// </summary>
		/// <remarks>
		/// Return a custom performance class for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="customPerformanceClassId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses/{customPerformanceClassId}")]
		Task<CustomPerformanceClasses> GetNetworkApplianceTrafficShapingCustomPerformanceClass(
			[AliasAs("networkId")] string networkId,
			[AliasAs("customPerformanceClassId")] string customPerformanceClassId
			);

		/// <summary>
		/// updateNetworkApplianceTrafficShapingCustomPerformanceClass
		/// </summary>
		/// <remarks>
		/// Update a custom performance class for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="customPerformanceClassId"></param>
		/// <param name="updateNetworkApplianceTrafficShapingCustomPerformanceClass"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses/{customPerformanceClassId}")]
		Task<CustomPerformanceClasses> UpdateNetworkApplianceTrafficShapingCustomPerformanceClass(
			[AliasAs("networkId")] string networkId,
			[AliasAs("customPerformanceClassId")] string customPerformanceClassId,
			[Body]CustomPerformanceClassesRequest updateNetworkApplianceTrafficShapingCustomPerformanceClass
			);

		/// <summary>
		/// deleteNetworkApplianceTrafficShapingCustomPerformanceClass
		/// </summary>
		/// <remarks>
		/// Delete a custom performance class from an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="customPerformanceClassId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses/{customPerformanceClassId}")]
		Task DeleteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("customPerformanceClassId")] string customPerformanceClassId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkApplianceTrafficShapingUplinkBandwidth
		/// </summary>
		/// <remarks>
		/// Returns the uplink bandwidth settings for your MX network.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/trafficShaping/uplinkBandwidth")]
		Task<UplinkBandwidth> GetNetworkApplianceTrafficShapingUplinkBandwidth(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// updateNetworkApplianceTrafficShapingUplinkBandwidth
		/// </summary>
		/// <remarks>
		/// Updates the uplink bandwidth settings for your MX network.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkApplianceTrafficShapingUplinkBandwidth"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/trafficShaping/uplinkBandwidth")]
		Task<UplinkBandwidth> UpdateNetworkApplianceTrafficShapingUplinkBandwidth(
			[AliasAs("networkId")] string networkId,
			[Body]UplinkBandwidth updateNetworkApplianceTrafficShapingUplinkBandwidth
			);

		/// <summary>
		/// getNetworkApplianceTrafficShapingUplinkSelection
		/// </summary>
		/// <remarks>
		/// Show uplink selection settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
		Task<UplinkSelection> GetNetworkApplianceTrafficShapingUpinkSelection(
			[AliasAs("networkId")] string networkIld
			);

		/// <summary>
		/// updateNetworkApplianceTrafficShapingUplinkSelection
		/// </summary>
		/// <remarks>
		/// Update uplink selection settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
		Task<UplinkSelection> UpdateNetworkApplianceTrafficShapingUplinkSelection(
			[AliasAs("networkId")] string networkId,
			[Body]UplinkSelection updateNetworkApplianceTrafficShapingUplinkSelection
			);

		/// <summary>
		/// getNetworkApplianceTrafficShaping
		/// </summary>
		/// <remarks>
		/// Display the traffic shaping settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/trafficShaping")]
		Task<NetworkApplianceTrafficShaping> GetNetworkApplianceTrafficShaping(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// updateNetworkApplianceTrafficShaping
		/// </summary>
		/// <remarks>
		/// Update the traffic shaping settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkApplianceTrafficShaping"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/trafficShaping")]
		Task<object> UpdateNetworkApplianceTrafficShaping(
			[AliasAs("networkId")] string networkId,
			[Body]NetworkApplianceTrafficShaping updateNetworkApplianceTrafficShaping
			);
	}
}
