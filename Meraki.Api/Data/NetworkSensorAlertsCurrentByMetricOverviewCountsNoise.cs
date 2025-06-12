namespace Meraki.Api.Data;

/// <summary>
/// Object containing the number of sensors that are currently alerting due to noise readings
/// </summary>
[DataContract]
public class NetworkSensorAlertsCurrentByMetricOverviewCountsNoise
{
	/// <summary>
	/// Number of sensors that are currently alerting due to ambient noise readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ambient")]
	public int Ambient { get; set; }
}