namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworkAppliances
	{
		/// <summary>
		/// Return a static route for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="staticRouteId">The static route id</param>
		[ApiOperationId("getNetworkApplianceStaticRoute")]
		[Get("/networks/{networkId}/appliance/staticRoutes/{staticRouteId}")]
		Task<StaticRoute> GetStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the static routes for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceStaticRoutes")]
		[Get("/networks/{networkId}/appliance/staticRoutes")]
		Task<List<StaticRoute>> GetStaticRoutesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Add a static route for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkStaticRoute">Body for adding a static route</param>
		[ApiOperationId("createNetworkApplianceStaticRoute")]
		[Post("/networks/{networkId}/appliance/staticRoutes")]
		Task<StaticRoute> CreateStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[Body] StaticRouteCreationRequest createNetworkStaticRoute,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a static route for an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="staticRouteId">The static route id</param>
		/// <param name="updateNetworkStaticRoute">Body for updating a static route</param>
		[ApiOperationId("updateNetworkApplianceStaticRoute")]
		[Put("/networks/{networkId}/appliance/staticRoutes/{staticRouteId}")]
		Task<StaticRoute> UpdateStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("staticRouteId")] string staticRouteId,
			[Body] StaticRouteUpdateRequest updateNetworkStaticRoute,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete a static route from an MX or teleworker network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="staticRouteId">The static route id</param>
		[ApiOperationId("deleteNetworkApplianceStaticRoute")]
		[Delete("/networks/{networkId}/appliance/staticRoutes/{staticRouteId}")]
		Task DeleteStaticRouteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("staticRouteId")] string staticRouteId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Display the traffic shaping settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceTrafficShaping")]
		[Get("/networks/{networkId}/appliance/trafficShaping")]
		Task<TrafficShaping> GetTrafficShapingAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the traffic shaping settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="trafficShaping"></param>
		[ApiOperationId("updateNetworkApplianceTrafficShaping")]
		[Put("/networks/{networkId}/appliance/trafficShaping")]
		Task<TrafficShaping> UpdateTrafficShapingAsync(
			[AliasAs("networkId")] string networkId,
			[Body] TrafficShaping trafficShaping,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List all custom performance classes for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceTrafficShapingCustomPerformanceClasses")]
		[Get("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses")]
		Task<List<CustomPerformanceClass>> GetTrafficShapingCustomPerformanceClassesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Add a custom performance class for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="trafficShapingCustomPerformanceClass"></param>
		/// <param name="cancellationToken"></param>
		[ApiOperationId("createNetworkApplianceTrafficShapingCustomPerformanceClass")]
		[Post("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses")]
		Task<CustomPerformanceClass> CreateTrafficShapingCustomPerformanceClassAsync(
			[AliasAs("networkId")] string networkId,
			[Body] CustomPerformanceClass trafficShapingCustomPerformanceClass,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a custom performance class for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="customPerformanceClassId">The custom performance class id</param>
		[ApiOperationId("getNetworkApplianceTrafficShapingCustomPerformanceClass")]
		[Get("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses/{customPerformanceClassId}")]
		Task<CustomPerformanceClass> GetTrafficShapingCustomPerformanceClassAsync(
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
		/// <param name="trafficShapingCustomPerformanceClass"></param>
		[ApiOperationId("updateNetworkApplianceTrafficShapingCustomPerformanceClass")]
		[Put("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses/{customPerformanceClassId}")]
		Task<CustomPerformanceClass> UpdateTrafficShapingCustomPerformanceClassAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("customPerformanceClassId")] string customPerformanceClassId,
			[Body] CustomPerformanceClass trafficShapingCustomPerformanceClass,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a custom performance class from an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="customPerformanceClassId">The custom performance class id</param>
		[ApiOperationId("deleteNetworkApplianceTrafficShapingCustomPerformanceClass")]
		[Delete("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses/{customPerformanceClassId}")]
		Task DeleteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("customPerformanceClassId")] string customPerformanceClassId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Display the traffic shaping settings rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceTrafficShapingRules")]
		[Get("/networks/{networkId}/appliance/trafficShaping/rules")]
		Task<NetworkApplianceTrafficShapingRule> GetTrafficShapingRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Display the traffic shaping settings rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="trafficShapingRule"></param>
		[ApiOperationId("getNetworkApplianceTrafficShapingRules")]
		[Put("/networks/{networkId}/appliance/trafficShaping/rules")]
		Task<NetworkApplianceTrafficShapingRule> UpdateTrafficShapingRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkApplianceTrafficShapingRule trafficShapingRule,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns the uplink bandwidth settings for your MX network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/trafficShaping/uplinkBandwidth")]
		Task<UplinkBandwidth> GetTrafficShapingUplinkBandwidthAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates the uplink bandwidth settings for your MX network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateTrafficShapingUplinkBandwidth"></param>
		[Put("/networks/{networkId}/appliance/trafficShaping/uplinkBandwidth")]
		Task<UplinkBandwidth> UpdateTrafficShapingUplinkBandwidthAsync(
			[AliasAs("networkId")] string networkId,
			[Body] UplinkBandwidth updateTrafficShapingUplinkBandwidth,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Show uplink selection settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
		Task<UplinkSelection> GetTrafficShapingUpinkSelectionAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update uplink selection settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateTrafficShapingUplinkSelection"></param>
		/// <param name="cancellationToken"></param>
		[Put("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
		Task<UplinkSelection> UpdateTrafficShapingUplinkSelectionAsync(
			[AliasAs("networkId")] string networkId,
			[Body] UplinkSelection updateTrafficShapingUplinkSelection,
			CancellationToken cancellationToken = default
			);




		/// <summary>
		/// Return MX warm spare settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceWarmSpare")]
		[Get("/networks/{networkId}/appliance/warmSpare")]
		Task<WarmSpare> GetWarmSpareAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update MX warm spare settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateWarmSpare">Body for updating warm spare settings</param>
		[ApiOperationId("updateNetworkApplianceWarmSpare")]
		[Put("/networks/{networkId}/appliance/warmSpare")]
		Task<WarmSpare> UpdateWarmSpareAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WarmSpareUpdateRequest updateWarmSpare,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Swap MX primary and warm spare appliances
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="warmSpare"></param>
		/// <param name="cancellationToken"></param>
		[ApiOperationId("swapNetworkApplianceWarmSpare")]
		[Post("/networks/{networkId}/appliance/warmSpare/swap")]
		Task<WarmSpare> SwapWarmSpareAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WarmSpare warmSpare,
			CancellationToken cancellationToken = default
			);
	}
}
