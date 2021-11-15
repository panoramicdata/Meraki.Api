using System.Runtime.Serialization;

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
	[DataMember(Name = "hourOfDay")]
	public string HourOfDay { get; set; } = string.Empty;

	/// <summary>
	/// Day of week
	/// </summary>
	[DataMember(Name = "dayOfWeek")]
	public string DayOfWeek { get; set; } = string.Empty;
}
