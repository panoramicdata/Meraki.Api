namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'apparentPower' metric. This will only be present if the 'metric' property equals 'apparentPower'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemApparentPower
{
	/// <summary>
	/// Aggregated apparent power readings in volt-amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public OrganizationSensorReadingsHistoryByIntervalItemApparentPowerDraw Draw { get; set; } = new();
}
