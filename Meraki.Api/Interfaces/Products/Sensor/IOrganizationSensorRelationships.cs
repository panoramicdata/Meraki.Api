namespace Meraki.Api.Interfaces.Products.Sensor;

public interface IOrganizationSensorRelationships
{
	/// <summary>
	/// List the sensor roles for a given sensor or camera device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The device serial</param>
	[ApiOperationId("getDeviceSensorRelationships")]
	[Get("/devices/{serial}/sensor/relationships")]
	Task<List<SensorRelationship>> GetDeviceSensorRelationshipsAsync(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the sensor roles for devices in a given network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSensorRelationships")]
	[Get("/networks/{networkId}/sensor/alerts/profiles")]
	Task<List<SensorRelationship>> GetNetworkSensorRelationshipsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Assign one or more sensor roles to a given sensor or camera device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The device serial</param>
	/// <param name="sensorRelationshipUpdateRequest">Body for updating a sensor role/param>
	[ApiOperationId("updateDeviceSensorRelationships")]
	[Put("/devices/{serial}/sensor/relationships")]
	Task<SensorAlertsProfile> UpdateNetworkSensorAlertsProfileAsync(
		string serial,
		[Body] SensorRelationshipUpdateRequest sensorRelationshipUpdateRequest,
		CancellationToken cancellationToken = default
		);
}
