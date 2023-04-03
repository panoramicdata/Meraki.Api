namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Admins interface
/// </summary>
public interface INetworksMqttBrokers
{
	/// <summary>
	/// List the MQTT brokers for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkMqttBrokers")]
	[Get("/networks/{networkId}/mqttBrokers")]
	Task<List<MqttBroker>> GetNetworkMqttBrokersAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Add an MQTT broker
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkMqttBroker">Body for adding an MQTT broker</param>
	[ApiOperationId("createNetworkMqttBroker")]
	[Post("/networks/{networkId}/mqttBrokers")]
	Task<MqttBroker> CreateNetworkMqttBrokerAsync(
		string networkId,
		[Body] MqttBrokerCreateUpdateRequest createNetworkMqttBroker,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an MQTT broker
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="mqttBrokerId">The MQTT broker id</param>
	[ApiOperationId("getNetworkMqttBroker")]
	[Get("/networks/{networkId}/mqttBrokers/{mqttBrokerId}")]
	Task<MqttBroker> GetNetworkMqttBrokerAsync(
		string networkId,
		string mqttBrokerId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update an MQTT broker
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="mqttBrokerId">The MQTT broker id</param>
	/// <param name="updateNetworkMqttBroker">Body for updating an MQTT broker</param>
	[ApiOperationId("updateNetworkMqttBroker")]
	[Put("/networks/{networkId}/mqttBrokers/{mqttBrokerId}")]
	Task<MqttBroker> UpdateNetworkMqttBrokerAsync(
		string networkId,
		string mqttBrokerId,
		[Body] MqttBrokerCreateUpdateRequest updateNetworkMqttBroker,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete an MQTT broker
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="mqttBrokerId">The MQTT broker id</param>
	[ApiOperationId("deleteNetworkMqttBroker")]
	[Delete("/networks/{networkId}/mqttBrokers/{mqttBrokerId}")]
	Task DeleteNetworkMqttBrokerAsync(
		string networkId,
		string mqttBrokerId,
		CancellationToken cancellationToken = default);
}
