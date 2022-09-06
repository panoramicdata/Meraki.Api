namespace Meraki.Api.Interfaces.Products.Sensor;

public interface IOrganizationSensorAlertsProfiles
{
	/// <summary>
	/// Show details of a sensor alert profile for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="id">The profile id</param>
	[ApiOperationId("getNetworkSensorAlertsProfile")]
	[Get("/networks/{networkId}/sensor/alerts/profiles/{id}")]
	Task<SensorAlertsProfile> GetNetworkSensorAlertsProfileAsync(
		string networkId,
		string id,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Lists all sensor alert profiles for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSensorAlertsProfiles")]
	[Get("/networks/{networkId}/sensor/alerts/profiles")]
	Task<List<SensorAlertsProfile>> GetNetworkSensorAlertsProfilesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Creates a sensor alert profile for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="sensorAlertProfileCreateRequest">Body for creating a sensor alert profile</param>
	[ApiOperationId("createNetworkSensorAlertsProfile")]
	[Post("/networks/{networkId}/sensor/alerts/profiles")]
	Task<SensorAlertsProfile> CreateNetworkSensorAlertsProfileAsync(
		string networkId,
		[Body] SensorAlertsProfileCreateRequest sensorAlertsProfileCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates a sensor alert profile for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="id">The sensor alert profile id</param>
	/// <param name="sensorAlertProfileUpdateRequest">Body for updating a sensor alert profile/param>
	[ApiOperationId("updateNetworkSensorAlertsProfile")]
	[Put("/networks/{networkId}/sensor/alerts/profiles/{id}")]
	Task<SensorAlertsProfile> UpdateNetworkSensorAlertsProfileAsync(
		string networkId,
		string id,
		[Body] SensorAlertsProfileUpdateRequest sensorAlertsProfileUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a sensor alert profile from a network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="id">The sensor alerts profile id</param>
	[ApiOperationId("deleteNetworkSensorAlertsProfile")]
	[Delete("/networks/{networkId}/sensor/alerts/profiles/{id}")]
	Task DeleteNetworkSensorAlertsProfileAsync(
		string networkId,
		string id,
		CancellationToken cancellationToken = default);
}
