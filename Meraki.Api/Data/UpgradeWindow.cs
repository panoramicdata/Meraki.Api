namespace Meraki.Api.Data;

/// <summary>
/// Upgrade window
/// </summary>
[DataContract]
public class UpgradeWindow
{
	/// <summary>
	/// Hour of day
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "hourOfDay")]
	public string HourOfDay { get; set; } = string.Empty;

	/// <summary>
	/// Day of week
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dayOfWeek")]
	public string DayOfWeek { get; set; } = string.Empty;
}
