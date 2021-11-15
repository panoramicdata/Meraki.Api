namespace Meraki.Api.Data;

/// <summary>
/// Usage history
/// </summary>
[DataContract]
public class UsageHistory
{
	/// <summary>
	/// startTs
	/// </summary>
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// endTs
	/// </summary>
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Total Kbps
	/// </summary>
	[DataMember(Name = "totalKbps")]
	public int TotalKbps { get; set; } = 0;

	/// <summary>
	/// Sent Kbps
	/// </summary>
	[DataMember(Name = "sentKbps")]
	public int SentKbps { get; set; } = 0;

	/// <summary>
	/// Received Kbps
	/// </summary>
	[DataMember(Name = "receivedKbps")]
	public int ReceivedKbps { get; set; } = 0;
}
