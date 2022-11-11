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
}
