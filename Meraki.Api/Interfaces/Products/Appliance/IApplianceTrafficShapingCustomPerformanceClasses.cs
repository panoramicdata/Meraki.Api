namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceTrafficShapingCustomPerformanceClasses
{
	/// <summary>
	/// List all custom performance classes for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceTrafficShapingCustomPerformanceClasses")]
	[Get("/networks/{networkId}/appliance/trafficShaping/customPerformanceClasses")]
	Task<List<CustomPerformanceClass>> GetNetworkApplianceTrafficShapingCustomPerformanceClassesAsync(
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
	Task<CustomPerformanceClass> CreateNetworkApplianceTrafficShapingCustomPerformanceClassAsync(
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
	Task<CustomPerformanceClass> GetNetworkApplianceTrafficShapingCustomPerformanceClassAsync(
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
	Task<CustomPerformanceClass> UpdateNetworkApplianceTrafficShapingCustomPerformanceClassAsync(
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
	Task DeleteNetworkApplianceTrafficShapingCustomPerformanceClassAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("customPerformanceClassId")] string customPerformanceClassId,
		CancellationToken cancellationToken = default);
}
