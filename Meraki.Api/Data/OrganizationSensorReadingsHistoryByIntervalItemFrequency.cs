namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'frequency' metric. This will only be present if the 'metric' property equals 'frequency'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemFrequency
{
	/// <summary>
	/// Aggregated electrical current frequency readings in hertz.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public OrganizationSensorReadingsHistoryByIntervalItemFrequencyDraw Draw { get; set; } = new();
}
