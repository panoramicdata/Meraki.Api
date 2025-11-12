namespace Meraki.Api.Interfaces.General.Networks;
/// <summary>
/// I Networks Sensor Alerts Current
/// </summary>
public interface INetworksSensorAlertsCurrent
{
	/// <summary>
	/// Return an overview of currently alerting sensors by metric
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkSensorAlertsCurrentOverviewByMetric")]
	[Get("/networks/{networkId}/sensor/alerts/current/overview/byMetric")]
	Task<NetworkSensorAlertsCurrentByMetricOverview> GetNetworkSensorAlertsCurrentOverviewByMetricAsync(string networkId, CancellationToken cancellationToken = default);
}
