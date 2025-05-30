namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'button' metric. This will only be present if the 'metric' property equals 'button'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemButton
{
	/// <summary>
	/// Accumulated counts of button press readings.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "pressType")]
	public OrganizationSensorReadingsHistoryByIntervalItemButtonPressType PressType { get; set; } = new();
}
