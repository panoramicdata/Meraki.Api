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
	public interface ISwitchSettings
	{
		/// <summary>
		/// Add a quality of service rule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkSwitchSettingsQosRule"></param>
		[Post("/networks/{networkId}/switch/qosRules")]
		Task<SwitchSettingsQosRule> CreateNetworkSwitchQosRuleAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsQosRuleCreationRequest CreateNetworkSwitchSettingsQosRule,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a quality of service rule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qosRuleId">The quality of service rule id</param>
		[Delete("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
		Task DeleteNetworkSwitchQosRuleAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("qosRuleId")] string qosRuleId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns the switch network settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/settings")]
		Task<SwitchSettingsUpdateRequest> GetNetworkSwitchSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the DHCP server policy
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/dhcpServerPolicy")]
		Task<SwitchSettingsDhcpServerPolicyUpdateRequest> GetNetworkSwitchDhcpServerPolicyAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the DSCP to CoS mappings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/dscpToCosMappings")]
		Task<SwitchSettingsDscpToCosMappingsUpdateRequest> GetNetworkSwitchDscpToCosMappingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the MTU configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/mtu")]
		Task<SwitchSettingsMtuUpdateRequest> GetNetworkSwitchMtuAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return multicast settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchRoutingMulticast")]
		[Get("/networks/{networkId}/switch/routing/multicast")]
		Task<Multicast> GetNetworkSwitchRoutingMulticastAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update multicast settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="multicast"></param>
		[ApiOperationId("updateNetworkSwitchRoutingMulticast")]
		[Put("/networks/{networkId}/switch/routing/multicast")]
		Task<Multicast> UpdateNetworkSwitchRoutingMulticastAsync(
			[AliasAs("networkId")] string networkId,
			[Body] Multicast multicast,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a quality of service rule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qosRuleId">The quality of service rule id</param>
		[Get("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
		Task<SwitchSettingsQosRule> GetNetworkSwitchQosRuleAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("qosRuleId")] string qosRuleId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List quality of service rules
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/qosRules")]
		Task<List<SwitchSettingsQosRule>> GetNetworkSwitchQosRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the quality of service rule IDs by order in which they will be processed by the switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/qosRules/order")]
		Task<SwitchSettingsQosRulesOrderUpdateRequest> GetNetworkSwitchQosRulesOrderAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the storm control configuration for a switch network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/stormControl")]
		Task<SwitchSettingsStormControlUpdateRequest> GetNetworkSwitchStormControlAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns STP settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/stp")]
		Task<SwitchSettingsStpUpdateRequest> GetNetworkSwitchStpAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update switch network settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSwitchSettings"></param>
		[Put("/networks/{networkId}/switch/settings")]
		Task<SwitchSettingsUpdateRequest> UpdateNetworkSwitchSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsUpdateRequest UpdateNetworkSwitchSettings,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the DHCP server policy
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSwitchSettingsDhcpServerPolicy"></param>
		[Put("/networks/{networkId}/switch/dhcpServerPolicy")]
		Task<SwitchSettingsDhcpServerPolicyUpdateRequest> UpdateNetworkSwitchDhcpServerPolicyAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsDhcpServerPolicyUpdateRequest UpdateNetworkSwitchSettingsDhcpServerPolicy,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the DSCP to CoS mappings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSwitchSettingsDscpToCosMappings"></param>
		[Put("/networks/{networkId}/switch/dscpToCosMappings")]
		Task<SwitchSettingsDscpToCosMappingsUpdateRequest> UpdateNetworkSwitchDscpToCosMappingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsDscpToCosMappingsUpdateRequest UpdateNetworkSwitchSettingsDscpToCosMappings,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the MTU configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSwitchSettingsMtu"></param>
		[Put("/networks/{networkId}/switch/mtu")]
		Task<SwitchSettingsMtuUpdateRequest> UpdateNetworkSwitchMtuAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsMtuUpdateRequest UpdateNetworkSwitchSettingsMtu,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a quality of service rule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qosRuleId"></param>
		/// <param name="UpdateNetworkSwitchSettingsQosRule"></param>
		[Put("/networks/{networkId}/switch/qosRules/{qosRuleId}")]
		Task<SwitchSettingsQosRuleUpdateRequest> UpdateNetworkSwitchQosRuleAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("qosRuleId")] string qosRuleId,
			[Body] SwitchSettingsQosRuleUpdateRequest UpdateNetworkSwitchSettingsQosRule,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the order in which the rules should be processed by the switch
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSwitchSettingsQosRulesOrder"></param>
		[Put("/networks/{networkId}/switch/qosRules/order")]
		Task<SwitchSettingsQosRulesOrderUpdateRequest> UpdateNetworkSwitchQosRulesOrderAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsQosRulesOrderUpdateRequest UpdateNetworkSwitchSettingsQosRulesOrder,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the storm control configuration for a switch network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSwitchSettingsStormControl"></param>
		[Put("/networks/{networkId}/switch/stormControl")]
		Task<SwitchSettingsStormControlUpdateRequest> UpdateNetworkSwitchStormControl(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsStormControlUpdateRequest UpdateNetworkSwitchSettingsStormControl,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates STP settings
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSwitchSettingsStp"></param>
		[Put("/networks/{networkId}/switch/stp")]
		Task<SwitchSettingsStpUpdateRequest> UpdateNetworkSwitchStpAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchSettingsStpUpdateRequest UpdateNetworkSwitchSettingsStp,
			CancellationToken cancellationToken = default
			);
	}
}
