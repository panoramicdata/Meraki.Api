namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworksNotfinished
	{










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
		/// Return single LAN configuration
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceSingleLan")]
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
		[ApiOperationId("updateNetworkApplianceSingleLan")]
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

		/// <summary>
		/// Returns all supported intrusion settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceSecurityIntrusion")]
		[Get("/networks/{networkId}/appliance/security/intrusion")]
		Task<NetworkSecurityIntrusion> GetSecurityIntrusionAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Set the supported intrusion settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="networkSecurityIntrusion">Body for updating security intrusion settings</param>
		[ApiOperationId("updateNetworkApplianceSecurityIntrusion")]
		[Put("/networks/{networkId}/appliance/security/intrusion")]
		Task<NetworkSecurityIntrusion> UpdateSecurityIntrusionAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkSecurityIntrusion networkSecurityIntrusion,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns all supported malware settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceSecurityMalware")]
		[Get("/networks/{networkId}/appliance/security/malware")]
		Task<NetworkSecurityMalware> GetSecurityMalwareAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Set the supported malware settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="securityMalware">Body for updating malware settings</param>
		[ApiOperationId("updateNetworkApplianceSecurityMalware")]
		[Put("/networks/{networkId}/appliance/security/malware")]
		Task<NetworkSecurityMalware> UpdateSecurityMalwareAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkSecurityMalware securityMalware,
			CancellationToken cancellationToken = default
			);
	}
}
