namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksSensorAlertsOverview
{
	/// <summary>
	/// Return an overview of alert occurrences over a timespan, by metric
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkSensorAlertsOverviewByMetric")]
	[Get("/networks/{networkId}/sensor/alerts/overview/byMetric")]
	Task<List<SensorAlertOverviewByMetricItem>> GetNetworkSensorAlertsOverviewByMetricAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
