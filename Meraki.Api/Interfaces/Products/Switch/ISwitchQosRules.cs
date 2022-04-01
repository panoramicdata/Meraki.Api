namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchQosRules
{
	/// <summary>
	/// List quality of service rules
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchQosRules")]
	[Get("/networks/{networkId}/switch/qosRules")]
	Task<List<QosRule>> GetNetworkSwitchQosRulesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a quality of service rule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qosRuleId">The quality of service rule id</param>
	[ApiOperationId("getNetworkSwitchQosRule")]
	[Get("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
	Task<QosRule> GetNetworkSwitchQosRuleAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("qosRuleId")] string qosRuleId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add a quality of service rule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkSwitchSettingsQosRule"></param>
	[ApiOperationId("createNetworkSwitchQosRule")]
	[Post("/networks/{networkId}/switch/qosRules")]
	Task<QosRule> CreateNetworkSwitchQosRuleAsync(
		[AliasAs("networkId")] string networkId,
		[Body] SwitchSettingsQosRuleCreationRequest createNetworkSwitchSettingsQosRule,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a quality of service rule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qosRuleId"></param>
	/// <param name="updateNetworkSwitchSettingsQosRule"></param>
	[ApiOperationId("updateNetworkSwitchQosRule")]
	[Put("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
	Task<QosRule> UpdateNetworkSwitchQosRuleAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("qosRuleId")] string qosRuleId,
		[Body] SwitchSettingsQosRuleUpdateRequest updateNetworkSwitchSettingsQosRule,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a quality of service rule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qosRuleId">The quality of service rule id</param>
	[ApiOperationId("deleteNetworkSwitchQosRule")]
	[Delete("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
	Task DeleteNetworkSwitchQosRuleAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("qosRuleId")] string qosRuleId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the quality of service rule IDs by order in which they will be processed by the switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchQosRulesOrder")]
	[Get("/networks/{networkId}/switch/qosRules/order")]
	Task<QosRulesOrder> GetNetworkSwitchQosRulesOrderAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the order in which the rules should be processed by the switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qosRulesOrder"></param>
	[ApiOperationId("updateNetworkSwitchQosRulesOrder")]
	[Put("/networks/{networkId}/switch/qosRules/order")]
	Task<QosRulesOrder> UpdateNetworkSwitchQosRulesOrderAsync(
		[AliasAs("networkId")] string networkId,
		[Body] QosRulesOrder qosRulesOrder,
		CancellationToken cancellationToken = default
		);
}
