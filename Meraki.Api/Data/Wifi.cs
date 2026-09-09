namespace Meraki.Api.Data;

/// <summary>
/// Wi-fi
/// </summary>
[DataContract]
[DebuggerDisplay("[{StartTime} to {EndTime}]: {UtilizationTotal}%")]
public class Wifi
{
	/// <summary>
	/// Start time
	/// </summary>
	[DataMember(Name = "start_ts")]
	public DateTime StartTime { get; set; }

	/// <summary>
	/// End time
	/// </summary>
	[DataMember(Name = "end_ts")]
	public DateTime EndTime { get; set; }

	/// <summary>
	/// Utilization total
	/// </summary>
	[DataMember(Name = "utilization")]
	public double UtilizationTotal { get; set; }

	/// <summary>
	/// Utilization wifi
	/// </summary>
	[DataMember(Name = "wifi")]
	public double UtilizationWifi { get; set; }

	/// <summary>
	/// Utilization non-wifi
	/// </summary>
	[DataMember(Name = "non_wifi")]
	public double UtilizationNonWifi { get; set; }

	/// <summary>
	/// The start time of the channel utilization interval, as the current API names it
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTime")]
	public DateTime? StartTimeUtc { get; set; }

	/// <summary>
	/// The end time of the channel utilization interval, as the current API names it
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTime")]
	public DateTime? EndTimeUtc { get; set; }

	/// <summary>
	/// Percentage of total channel utilization for the given radio, as the current API names it
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "utilizationTotal")]
	public double? UtilizationTotalPercent { get; set; }

	/// <summary>
	/// Percentage of wifi channel utilization for the given radio, as the current API names it
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "utilization80211")]
	public double? Utilization80211 { get; set; }

	/// <summary>
	/// Percentage of non-wifi channel utilization for the given radio, as the current API names it
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "utilizationNon80211")]
	public double? UtilizationNon80211 { get; set; }
}
