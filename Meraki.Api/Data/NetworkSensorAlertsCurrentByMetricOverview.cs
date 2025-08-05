namespace Meraki.Api.Data;

/// <summary>
/// Network Sensor Alerts Current By Metric Overview
/// </summary>
[DataContract]
public class NetworkSensorAlertsCurrentByMetricOverview
{
	/// <summary>
	/// List of metrics that are supported for alerts, based on available sensor devices in the network. enum = ["apparentPower", "co2", "current", "door", "frequency", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "supportedMetrics")]
	public List<string> SupportedMetrics { get; set; } = [];

	/// <summary>
	/// Counts of currently alerting sensors, aggregated by alerting metric
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public NetworkSensorAlertsCurrentByMetricOverviewCounts Counts { get; set; } = new();
}
