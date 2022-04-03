namespace Meraki.Api.Data;

/// <summary>
/// Schedules
/// </summary>
[DataContract]
public class WirelessSsidOutageSchedule
{
	/// <summary>
	/// If true, the SSID outage schedule is enabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// List of outage ranges. Has a start date and time, and end date and time. If this parameter is passed in along with rangesInSeconds parameter, this will take precedence.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ranges")]
	public List<WirelessSsidOutageRange>? Ranges { get; set; }

	/// <summary>
	/// List of outage ranges in seconds since Sunday at Midnight. Has a start and end. If this parameter is passed in along with the ranges parameter, ranges will take precedence.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rangesInSeconds")]
	public List<WirelessSsidOutageRangeInSecond>? RangesInSeconds { get; set; }
}
