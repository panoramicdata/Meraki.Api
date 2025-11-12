namespace Meraki.Api.Interfaces.Products.Sensor;

/// <summary>
/// I Organization Sensor Gateways Connections Latest
/// </summary>
public interface IOrganizationSensorGatewaysConnectionsLatest
{
	/// <summary>
	/// Returns latest sensor-gateway connectivity data.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="sensorSerials">List of sensor serials to filter connectivity data by sensor.</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationSensorGatewaysConnectionsLatest")]
	[Get("/organizations/{organizationId}/sensor/gateways/connections/latest")]
	Task<List<SensorReadingLatest>> GetOrganizationSensorGatewaysConnectionsLatestAsync(
		string organizationId,
		int? perPage,
		string? startingAfter = null,
		string? endingBefore = null,
		[AliasAs("sensorSerials[]")] List<string>? sensorSerials = null,
		CancellationToken cancellationToken = default
		);
}
