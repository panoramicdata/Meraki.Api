namespace Meraki.Api.Data;

/// <summary>
/// Uplink usage history
/// </summary>
[DataContract]
public class UplinkUsageHistory
{
	/// <summary>
	/// Start time
	/// </summary>
	[DataMember(Name = "startTime")]
	public DateTime StartTimeUtc { get; set; }

	/// <summary>
	/// Start time
	/// </summary>
	[DataMember(Name = "endTime")]
	public DateTime EndTimeUtc { get; set; }

	/// <summary>
	/// Interface Usage
	/// </summary>
	[DataMember(Name = "byInterface")]
	public List<UplinkUsage> UplinkUsage { get; set; } = [];
}
