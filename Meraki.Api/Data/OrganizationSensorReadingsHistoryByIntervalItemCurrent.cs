namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'current' metric. This will only be present if the 'metric' property equals 'current'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemCurrent
{
	/// <summary>
	/// Aggregated electrical current readings in amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public OrganizationSensorReadingsHistoryByIntervalItemCurrentDraw Draw { get; set; } = new();
}
