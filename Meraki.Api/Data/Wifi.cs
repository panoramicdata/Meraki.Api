namespace Meraki.Api.Data;

/// <summary>
/// Wi-fi
/// </summary>
[DataContract]
public class Wifi
{
	/// <summary>
	/// Start time
	/// </summary>
	[DataMember(Name = "startTime")]
	public string StartTime { get; set; } = string.Empty;

	/// <summary>
	/// End time
	/// </summary>
	[DataMember(Name = "endTime")]
	public string EndTime { get; set; } = string.Empty;

	/// <summary>
	/// Utilization total
	/// </summary>
	[DataMember(Name = "utilizationTotal")]
	public float utilizationTotal { get; set; } = 0;

	/// <summary>
	/// Utilization 80211
	/// </summary>
	[DataMember(Name = "utilization80211")]
	public float utilization80211 { get; set; } = 0;

	/// <summary>
	/// Utilization non-80211
	/// </summary>
	[DataMember(Name = "utilizationNon80211")]
	public float utilizationNon80211 { get; set; } = 0;
}
