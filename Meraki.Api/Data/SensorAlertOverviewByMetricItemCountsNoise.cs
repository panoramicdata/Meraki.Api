namespace Meraki.Api.Data;

/// <summary>
/// Object containing the number of sensor alerts that occurred due to noise readings
/// </summary>
[DataContract]
public class SensorAlertOverviewByMetricItemCountsNoise
{
	/// <summary>
	/// Number of sensor alerts that occurred due to ambient noise readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ambient")]
	public int Ambient { get; set; }
}