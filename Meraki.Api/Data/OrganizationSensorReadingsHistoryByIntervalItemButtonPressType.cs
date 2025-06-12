namespace Meraki.Api.Data;

/// <summary>
/// Accumulated counts of button press readings.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemButtonPressType
{
	/// <summary>
	/// Accumulated button presses by press type.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSensorReadingsHistoryByIntervalItemButtonPressTypeCounts Counts { get; set; } = new();
}
