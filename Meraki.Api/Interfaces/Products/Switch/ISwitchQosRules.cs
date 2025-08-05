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
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchQosRules")]
	[Get("/networks/{networkId}/switch/qosRules")]
	Task<List<QosRule>> GetNetworkSwitchQosRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a quality of service rule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qosRuleId">The quality of service rule id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchQosRule")]
	[Get("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
	Task<QosRule> GetNetworkSwitchQosRuleAsync(
		string networkId,
		string qosRuleId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add a quality of service rule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkSwitchSettingsQosRule"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createNetworkSwitchQosRule")]
	[Post("/networks/{networkId}/switch/qosRules")]
	Task<QosRule> CreateNetworkSwitchQosRuleAsync(
		string networkId,
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
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkSwitchQosRule")]
	[Put("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
	Task<QosRule> UpdateNetworkSwitchQosRuleAsync(
		string networkId,
		string qosRuleId,
		[Body] SwitchSettingsQosRuleUpdateRequest updateNetworkSwitchSettingsQosRule,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a quality of service rule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qosRuleId">The quality of service rule id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteNetworkSwitchQosRule")]
	[Delete("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
	Task DeleteNetworkSwitchQosRuleAsync(
		string networkId,
		string qosRuleId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the quality of service rule IDs by order in which they will be processed by the switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchQosRulesOrder")]
	[Get("/networks/{networkId}/switch/qosRules/order")]
	Task<QosRulesOrder> GetNetworkSwitchQosRulesOrderAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the order in which the rules should be processed by the switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qosRulesOrder"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkSwitchQosRulesOrder")]
	[Put("/networks/{networkId}/switch/qosRules/order")]
	Task<QosRulesOrder> UpdateNetworkSwitchQosRulesOrderAsync(
		string networkId,
		[Body] QosRulesOrder qosRulesOrder,
		CancellationToken cancellationToken = default
		);
}
