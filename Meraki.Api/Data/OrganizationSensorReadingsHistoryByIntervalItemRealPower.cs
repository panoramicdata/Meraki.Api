namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'realPower' metric. This will only be present if the 'metric' property equals 'realPower'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemRealPower
{
	/// <summary>
	/// Aggregated real power readings in watts.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public OrganizationSensorReadingsHistoryByIntervalItemRealPowerDraw Draw { get; set; } = new();
}
