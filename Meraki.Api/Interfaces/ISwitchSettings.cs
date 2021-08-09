using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISwitchSettings
	{
		/// <summary>
		/// createNetworkSwitchSettingsQosRule
		/// </summary>
		/// <remarks>
		/// Add a quality of service rule
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkSwitchSettingsQosRule"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switch/settings/qosRules")]
		Task<object> CreateNetworkSwitchSettingsQosRule(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchSettingsQosRuleCreationRequest createNetworkSwitchSettingsQosRule
			);

		/// <summary>
		/// deleteNetworkSwitchSettingsQosRule
		/// </summary>
		/// <remarks>
		/// Delete a quality of service rule
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="qosRuleId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/switch/settings/qosRules/{qosRuleId}")]
		Task DeleteNetworkSwitchSettingsQosRule(
			[AliasAs("networkId")]string networkId,
			[AliasAs("qosRuleId")]string qosRuleId
			);

		/// <summary>
		/// getNetworkSwitchSettings
		/// </summary>
		/// <remarks>
		/// Returns the switch network settings
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings")]
		Task<object> GetNetworkSwitchSettings(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkSwitchSettingsDhcpServerPolicy
		/// </summary>
		/// <remarks>
		/// Return the DHCP server policy
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings/dhcpServerPolicy")]
		Task<object> GetNetworkSwitchSettingsDhcpServerPolicy(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkSwitchSettingsDscpToCosMappings
		/// </summary>
		/// <remarks>
		/// Return the DSCP to CoS mappings
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings/dscpToCosMappings")]
		Task<object> GetNetworkSwitchSettingsDscpToCosMappings(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkSwitchSettingsMtu
		/// </summary>
		/// <remarks>
		/// Return the MTU configuration
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings/mtu")]
		Task<object> GetNetworkSwitchSettingsMtu(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkSwitchSettingsMulticast
		/// </summary>
		/// <remarks>
		/// Return multicast settings for a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings/multicast")]
		Task<object> GetNetworkSwitchSettingsMulticast(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkSwitchSettingsQosRule
		/// </summary>
		/// <remarks>
		/// Return a quality of service rule
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="qosRuleId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings/qosRules/{qosRuleId}")]
		Task<object> GetNetworkSwitchSettingsQosRule(
			[AliasAs("networkId")]string networkId,
			[AliasAs("qosRuleId")]string qosRuleId
			);

		/// <summary>
		/// getNetworkSwitchSettingsQosRules
		/// </summary>
		/// <remarks>
		/// List quality of service rules
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings/qosRules")]
		Task<object> GetNetworkSwitchSettingsQosRules(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkSwitchSettingsQosRulesOrder
		/// </summary>
		/// <remarks>
		/// Return the quality of service rule IDs by order in which they will be processed by the switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings/qosRules/order")]
		Task<object> GetNetworkSwitchSettingsQosRulesOrder(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// getNetworkSwitchSettingsStormControl
		/// </summary>
		/// <remarks>
		/// Return the storm control configuration for a switch network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings/stormControl")]
		Task<object> GetNetworkSwitchSettingsStormControl(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkSwitchSettingsStp
		/// </summary>
		/// <remarks>
		/// Returns STP settings
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/settings/stp")]
		Task<object> GetNetworkSwitchSettingsStp(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkSwitchSettings
		/// </summary>
		/// <remarks>
		/// Update switch network settings
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSwitchSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/settings")]
		Task<object> UpdateNetworkSwitchSettings(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchSettingsUpdateRequest updateNetworkSwitchSettings
			);

		/// <summary>
		/// updateNetworkSwitchSettingsDhcpServerPolicy
		/// </summary>
		/// <remarks>
		/// Update the DHCP server policy
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSwitchSettingsDhcpServerPolicy"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/settings/dhcpServerPolicy")]
		Task<object> UpdateNetworkSwitchSettingsDhcpServerPolicy(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchSettingsDhcpServerPolicyUpdateRequest updateNetworkSwitchSettingsDhcpServerPolicy
			);

		/// <summary>
		/// updateNetworkSwitchSettingsDscpToCosMappings
		/// </summary>
		/// <remarks>
		/// Update the DSCP to CoS mappings
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSwitchSettingsDscpToCosMappings"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/settings/dscpToCosMappings")]
		Task<object> UpdateNetworkSwitchSettingsDscpToCosMappings(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchSettingsDscpToCosMappingsUpdateRequest updateNetworkSwitchSettingsDscpToCosMappings
			);

		/// <summary>
		/// updateNetworkSwitchSettingsMtu
		/// </summary>
		/// <remarks>
		/// Update the MTU configuration
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSwitchSettingsMtu"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/settings/mtu")]
		Task<object> UpdateNetworkSwitchSettingsMtu(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchSettingsMtuUpdateRequest updateNetworkSwitchSettingsMtu
			);

		/// <summary>
		/// updateNetworkSwitchSettingsMulticast
		/// </summary>
		/// <remarks>
		/// Update multicast settings for a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSwitchSettingsMulticast"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/settings/multicast")]
		Task<object> UpdateNetworkSwitchSettingsMulticast(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchSettingsMulticastUpdateRequest updateNetworkSwitchSettingsMulticast
			);

		/// <summary>
		/// updateNetworkSwitchSettingsQosRule
		/// </summary>
		/// <remarks>
		/// Update a quality of service rule
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="qosRuleId"></param>
		/// <param name="updateNetworkSwitchSettingsQosRule"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/settings/qosRules/{qosRuleId}")]
		Task<object> UpdateNetworkSwitchSettingsQosRule(
			[AliasAs("networkId")]string networkId,
			[AliasAs("qosRuleId")]string qosRuleId,
			[Body]SwitchSettingsQosRuleUpdateRequest updateNetworkSwitchSettingsQosRule
			);

		/// <summary>
		/// updateNetworkSwitchSettingsQosRulesOrder
		/// </summary>
		/// <remarks>
		/// Update the order in which the rules should be processed by the switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSwitchSettingsQosRulesOrder"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/settings/qosRules/order")]
		Task<object> UpdateNetworkSwitchSettingsQosRulesOrder(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchSettingsQosRulesOrderUpdateRequest updateNetworkSwitchSettingsQosRulesOrder
			);

		/// <summary>
		/// updateNetworkSwitchSettingsStormControl
		/// </summary>
		/// <remarks>
		/// Update the storm control configuration for a switch network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSwitchSettingsStormControl"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/settings/stormControl")]
		Task<object> UpdateNetworkSwitchSettingsStormControl(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchSettingsStormControlUpdateRequest updateNetworkSwitchSettingsStormControl
			);

		/// <summary>
		/// updateNetworkSwitchSettingsStp
		/// </summary>
		/// <remarks>
		/// Updates STP settings
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSwitchSettingsStp"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/settings/stp")]
		Task<object> UpdateNetworkSwitchSettingsStp(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchSettingsStpUpdateRequest updateNetworkSwitchSettingsStp
			);
	}
}
