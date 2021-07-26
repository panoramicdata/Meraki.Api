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
	public interface IMqttBrokers
	{
		/// <summary>
		/// getNetworkMqttBrokers
		/// </summary>
		/// <remarks>
		/// List the MQTT brokers for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/mqttBrokers")]
		Task<List<NetworkMqttBroker>> GetNetworkMqttBrokersAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// createNetworkMqttBroker
		/// </summary>
		/// <remarks>
		/// Add an MQTT broker
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="createNetworkMqttBroker"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/mqttBrokers")]
		Task<NetworkMqttBroker> CreateNetworkMqttBrokerAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkMqttBroker createNetworkMqttBroker,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkMqttBroker
		/// </summary>
		/// <remarks>
		/// Return an MQTT broker
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="mqttBrokerId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/mqttBrokers/{mqttBrokerId}")]
		Task<NetworkMqttBroker> GetNetworkMqttBrokerAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("mqttBrokerId")] string mqttBrokerId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkMqttBroker
		/// </summary>
		/// <remarks>
		/// Update an MQTT broker
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="mqttBrokerId"></param>
		/// <param name="updateNetworkMqttBroker"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/mqttBrokers/{mqttBrokerId}")]
		Task<object> UpdateNetworkMqttBrokerAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("mqttBrokerId")] string mqttBrokerId,
			[Body] NetworkMqttBroker updateNetworkMqttBroker,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// deleteNetworkMqttBroker
		/// </summary>
		/// <remarks>
		/// Delete an MQTT broker
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="mqttBrokerId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/mqttBrokers/{mqttBrokerId}")]
		Task DeleteNetworkMqttBrokerAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("mqttBrokerId")] string mqttBrokerId,
			CancellationToken cancellationToken = default);
	}
}
