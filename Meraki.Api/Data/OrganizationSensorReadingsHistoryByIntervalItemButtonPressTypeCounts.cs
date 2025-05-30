namespace Meraki.Api.Data;

/// <summary>
/// Accumulated button presses by press type.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemButtonPressTypeCounts
{
	/// <summary>
	/// Number of times that a long press was performed.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "long")]
	public int LongPress { get; set; }

	/// <summary>
	/// Number of times that a short press was performed.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "short")]
	public int ShortPress { get; set; }
}