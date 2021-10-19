using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Admins interface
	/// </summary>
	public interface INetworkMqttBrokers
	{
		/// <summary>
		/// List the MQTT brokers for this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/mqttBrokers")]
		Task<List<MqttBroker>> GetAllAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Add an MQTT broker
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkMqttBroker">Body for adding an MQTT broker</param>
		[Post("/networks/{networkId}/mqttBrokers")]
		Task<MqttBroker> CreateAsync(
			[AliasAs("networkId")] string networkId,
			[Body] MqttBrokerCreateUpdateRequest createNetworkMqttBroker,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return an MQTT broker
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="mqttBrokerId">The MQTT broker id</param>
		[Get("/networks/{networkId}/mqttBrokers/{mqttBrokerId}")]
		Task<MqttBroker> GetAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("mqttBrokerId")] string mqttBrokerId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update an MQTT broker
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="mqttBrokerId">The MQTT broker id</param>
		/// <param name="updateNetworkMqttBroker">Body for updating an MQTT broker</param>
		[Put("/networks/{networkId}/mqttBrokers/{mqttBrokerId}")]
		Task<MqttBroker> UpdateAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("mqttBrokerId")] string mqttBrokerId,
			[Body] MqttBrokerCreateUpdateRequest updateNetworkMqttBroker,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete an MQTT broker
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="mqttBrokerId">The MQTT broker id</param>
		[Delete("/networks/{networkId}/mqttBrokers/{mqttBrokerId}")]
		Task DeleteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("mqttBrokerId")] string mqttBrokerId,
			CancellationToken cancellationToken = default);
	}
}
