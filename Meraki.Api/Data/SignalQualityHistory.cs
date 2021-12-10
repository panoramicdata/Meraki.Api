namespace Meraki.Api.Data;

/// <summary>
/// Signal quality history
/// </summary>
[DataContract]
public class SignalQualityHistory
{
	/// <summary>
	/// StartTs
	/// </summary>
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// EndTs
	/// </summary>
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Snr
	/// </summary>
	[DataMember(Name = "snr")]
	public int Snr { get; set; }

	/// <summary>
	/// Rssi
	/// </summary>
	[DataMember(Name = "rssi")]
	public int Rssi { get; set; }
}
